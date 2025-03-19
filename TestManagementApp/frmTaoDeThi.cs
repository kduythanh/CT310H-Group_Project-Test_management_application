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
    public partial class frmTaoDeThi : Form
    {
        public frmTaoDeThi()
        {
            InitializeComponent();
        }

        private void frmTaoDeThi_Load(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                string maDethi = taoMaDeThi(8); // Tạo mã đề thi ngẫu nhiên
                txtMaDeThi.Text = maDethi; // Hiển thị mã đề thi lên TextBox
                LoadMonHoc(); // Gọi hàm load môn học từ CSDL
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // đóng kết nối CSDL khi đóng form
        private void frmTaoDeThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsDatabase.CloseConnection();
        }

        private void LoadMonHoc()
        {
            try
            {
                // Tạo câu lệnh truy vấn
                string query = "SELECT MA_MON, TEN_MON FROM MON_HOC";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán dữ liệu vào ComboBox môn học
                cboMonHoc.DataSource = dt;
                cboMonHoc.DisplayMember = "TEN_MON"; // Hiển thị tên môn học
                cboMonHoc.ValueMember = "MA_MON";    // Lưu giá trị là mã môn học
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu môn học: " + ex.Message);
            }
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtTenDeThi.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtThoiGian.Text, out int thoiGian) || thoiGian <= 0)
                {
                    MessageBox.Show("Thời gian làm bài phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboMonHoc.SelectedIndex == 0) // Giả sử "Chọn môn học" ở index 0
                {
                    MessageBox.Show("Vui lòng chọn môn học hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra kết nối CSDL
                if (clsDatabase.con == null || clsDatabase.con.State == ConnectionState.Closed)
                {
                    if (!clsDatabase.OpenConnection())
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string maTaiKhoan = Session.TenTaiKhoan;
                // Tạo câu lệnh truy vấn
                string query = "INSERT INTO DE_THI (MA_DE_THI, TEN_DE_THI, MA_MON, MA_TK, THOI_LUONG,  MAT_KHAU_DE) " +
                    "VALUES (@MA_DE_THI, @TEN_DE_THI, @MA_MON, @MA_TK, @THOI_LUONG,  @MAT_KHAU_DE)";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@MA_DE_THI", txtMaDeThi.Text);
                    cmd.Parameters.AddWithValue("@TEN_DE_THI", txtTenDeThi.Text);
                    cmd.Parameters.AddWithValue("@THOI_LUONG", thoiGian); // Đã kiểm tra kiểu INT
                    cmd.Parameters.AddWithValue("@MA_MON", cboMonHoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@MA_TK", maTaiKhoan);
                    cmd.Parameters.AddWithValue("@MAT_KHAU_DE", txtMatKhau.Text);

                    // Thực thi câu lệnh truy vấn
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tạo đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tạo đề thi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Đóng kết nối sau khi thực thi
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string taoMaDeThi(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            frmTaoCauHoi frmTaoCauHoi = new frmTaoCauHoi();
            frmTaoCauHoi.Show();
        }
    }
}
