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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Session.Role == 0)
            {
                frmTrangChuHS frmTrangChuHS = new frmTrangChuHS();
                frmTrangChuHS.Show();
            }
            else if (Session.Role == 1) 
            {
                frmTrangChuGV frmTrangChuGV = new frmTrangChuGV();
                frmTrangChuGV.Show();
            } 
            else
            {
                Application.Exit();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauHienTai = txtMKHienTai.Text.Trim();
            string matKhauMoi = txtMKMoi.Text.Trim();
            string xacNhanMKMoi = txtXNMKMoi.Text.Trim();
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT * FROM TAI_KHOAN WHERE MA_TK = @MATK", clsDatabase.con);
                com.Parameters.AddWithValue("@MATK", Session.TenTaiKhoan);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read()) 
                { 
                    if (dr["MAT_KHAU"].ToString() != matKhauHienTai)
                    {
                        MessageBox.Show("Mật khẩu hiện tại chưa chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                        return;
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                if (matKhauMoi != xacNhanMKMoi)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới chưa trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand com1 = new SqlCommand("UPDATE TAI_KHOAN SET MAT_KHAU = @MATKHAU WHERE MA_TK = @MATK", clsDatabase.con);
                com1.Parameters.AddWithValue("@MATK", Session.TenTaiKhoan);
                com1.Parameters.AddWithValue("@MATKHAU", matKhauMoi);
                com1.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Session.Role == 0)
                {
                    frmTrangChuHS frmTrangChuHS = new frmTrangChuHS();
                    frmTrangChuHS.Show();
                }
                else if (Session.Role == 1)
                {
                    frmTrangChuGV frmTrangChuGV = new frmTrangChuGV();
                    frmTrangChuGV.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi kết nối đến CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }
    }
}
