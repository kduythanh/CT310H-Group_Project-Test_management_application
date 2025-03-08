using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        void LoadHS()
        {
            txtHocSinh.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";
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
    }
}
