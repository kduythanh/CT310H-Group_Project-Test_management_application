using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManagementApp
{
    public partial class frmTrangChuHS : Form
    {
        public frmTrangChuHS()
        {
            InitializeComponent();
            LoadHS();
            LoadMonHoc();
            btnVaoThi.Enabled = false;
        }

        void LoadHS()
        {
            txtHocSinh.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";
        }

        private void UpdateVaoThiButtonState()
        {
            btnVaoThi.Enabled = (cboChonMonHoc.SelectedIndex != -1 && cboChonDeThi.SelectedIndex != -1);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa thông tin đăng nhập
                Session.TenTaiKhoan = null;
                Session.HoTen = null;
                Session.Role = -1;

                // Đóng form hiện tại và quay lại form đăng nhập
                this.Close();
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.Show();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.Show();
        }


        private void LoadMonHoc()
        {
            if (!clsDatabase.OpenConnection())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT MA_MON, TEN_MON FROM MON_HOC";
            SqlDataAdapter da = new SqlDataAdapter(query, clsDatabase.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Disable event before updating the data source
            cboChonMonHoc.SelectedIndexChanged -= cboChonMonHoc_SelectedIndexChanged;
            cboChonMonHoc.DisplayMember = "TEN_MON";
            cboChonMonHoc.ValueMember = "MA_MON";
            cboChonMonHoc.DataSource = dt;
            cboChonMonHoc.SelectedIndex = -1; // Ensure default state
            cboChonMonHoc.SelectedIndexChanged += cboChonMonHoc_SelectedIndexChanged;

            clsDatabase.CloseConnection();
        }

        
        private void LoadDeThi(string maMon)
        {
            if (!clsDatabase.OpenConnection())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT MA_DE_THI, TEN_DE_THI FROM DE_THI WHERE MA_MON = @maMon AND TRANG_THAI = 1";
            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
            cmd.Parameters.AddWithValue("@maMon", maMon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Disable event before updating the data source
            cboChonDeThi.SelectedIndexChanged -= cboChonDeThi_SelectedIndexChanged;
            if (dt.Rows.Count == 0)
            {
                // Nếu không có đề thi, tạo một DataTable mới với một dòng mặc định
                DataTable dtDefault = new DataTable();
                dtDefault.Columns.Add("MA_DE_THI", typeof(string));
                dtDefault.Columns.Add("TEN_DE_THI", typeof(string));
                dtDefault.Rows.Add("", "Chưa có đề thi");

                cboChonDeThi.DataSource = dtDefault;
                cboChonDeThi.DisplayMember = "TEN_DE_THI";
                cboChonDeThi.ValueMember = "MA_DE_THI";

                // Đảm bảo button Vào Thi bị vô hiệu hóa
                btnVaoThi.Enabled = false;
            }
            else
            {
                cboChonDeThi.DataSource = dt;
                cboChonDeThi.DisplayMember = "TEN_DE_THI";
                cboChonDeThi.ValueMember = "MA_DE_THI";
                cboChonDeThi.SelectedIndex = -1; // Ensure default state
            }
            cboChonDeThi.SelectedIndexChanged += cboChonDeThi_SelectedIndexChanged;

            clsDatabase.CloseConnection();
        }

        private void cboChonMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonMonHoc.SelectedValue == null || cboChonMonHoc.SelectedIndex == -1)
                return;

            string maMon = cboChonMonHoc.SelectedValue.ToString();
            LoadDeThi(maMon);
            UpdateVaoThiButtonState();
        }

        private void cboChonDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonDeThi.SelectedValue == null || cboChonDeThi.SelectedIndex == -1)
                return;

            string maDeThi = cboChonDeThi.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maDeThi))
            {
                // Xóa các thông tin giáo viên và thời gian
                txtGVRaDe.Text = "";
                txtThoiGianLam.Text = "";
                btnVaoThi.Enabled = false;
                return;
            }
            LoadGiaoVienVaThoiGian(maDeThi);
            UpdateVaoThiButtonState();
        }


        private void LoadGiaoVienVaThoiGian(string maDeThi)
        {
            if (!clsDatabase.OpenConnection())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                SELECT T.HO_TEN AS GiaoVien, D.THOI_LUONG 
                FROM DE_THI D 
                JOIN TAI_KHOAN T ON D.MA_TK = T.MA_TK 
                WHERE D.MA_DE_THI = @maDeThi";

            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
            cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtGVRaDe.Text = reader["GiaoVien"].ToString();
                txtThoiGianLam.Text = reader["THOI_LUONG"].ToString();
            }

            reader.Close();
            clsDatabase.CloseConnection();
        }

        private void btnXemLichSu_Click(object sender, EventArgs e)
        {
            frmXemLichSuLamBai lichSuForm = new frmXemLichSuLamBai();
            lichSuForm.Show();
        }

        private void btnVaoThi_Click(object sender, EventArgs e)
        {
            if (cboChonDeThi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenDeThi = ((DataRowView)cboChonDeThi.SelectedItem)["TEN_DE_THI"].ToString();
            string maDeThi = cboChonDeThi.SelectedValue.ToString();
            frmXacNhanThi confirmForm = new frmXacNhanThi(maDeThi,tenDeThi);
            confirmForm.Show();
        }

    }
}

