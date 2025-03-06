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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT * FROM TAI_KHOAN WHERE MA_TK = @MATK AND MAT_KHAU = @MATKHAU", clsDatabase.con);
                com.Parameters.AddWithValue("@MATK", tenDangNhap);
                com.Parameters.AddWithValue("@MATKHAU", matKhau);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    Session.TenTaiKhoan = dr["MA_TK"].ToString();
                    Session.HoTen = dr["HO_TEN"].ToString();
                    Session.Role = Convert.ToInt32(dr["ROLE"]);

                    this.Hide();
                    Form mainForm = null;
                    switch (Session.Role)
                    {
                        case 0:
                            mainForm = new frmTrangChuHS();
                            mainForm.Show();
                            break;
                        case 1:
                            mainForm = new frmTrangChuGV();
                            mainForm.Show();
                            break;
                        case 2:
                            mainForm = new frmTrangChuAdmin();
                            mainForm.Show();
                            break;
                        default:
                            MessageBox.Show("Tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
