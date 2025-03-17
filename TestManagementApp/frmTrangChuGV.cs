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
    public partial class frmTrangChuGV : Form
    {
        public frmTrangChuGV()
        {
            InitializeComponent();
            LoadGV();
        }

        void LoadGV()
        {
            txtGiaoVien.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";
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

        private void btnThemDeThi_Click(object sender, EventArgs e)
        {
            frmTaoDeThi frmTaoDeThi = new frmTaoDeThi();
            frmTaoDeThi.Show();
        }

        private void btnSuaCauHoi_Click(object sender, EventArgs e)
        {
            frmTaoCauHoi frmTaoCauHoi = new frmTaoCauHoi();
            frmTaoCauHoi.Show();
        }
    }
}
