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
    public partial class frmTrangChuAdmin : Form
    {
        public frmTrangChuAdmin()
        {
            InitializeComponent();
            cboLoaiTaiKhoan.SelectedIndex = 0;
            LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
        }
        void LoadTaiKhoan(string role)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MA_TK, HO_TEN FROM TAI_KHOAN WHERE ROLE = @ROLE", clsDatabase.con);
                if (role == "Giáo viên") com.Parameters.AddWithValue("@ROLE", 1);
                else if (role == "Học sinh") com.Parameters.AddWithValue("@ROLE", 0);
                else return;

                // Đọc dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị dữ liệu lên DataGridView
                dgvDSTaiKhoan.DataSource = dt;
                dgvDSTaiKhoan.Columns["MA_TK"].HeaderText = "Tên tài khoản";
                dgvDSTaiKhoan.Columns["HO_TEN"].HeaderText = "Họ và tên";
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cboLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
        }

        private void btnThemDeThi_Click(object sender, EventArgs e)
        {

        }

        private void frmTrangChuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
