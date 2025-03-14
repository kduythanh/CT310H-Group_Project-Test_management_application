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
    public partial class frmNhapMatKhau : Form
    {
        // Biến để lưu mật khẩu nhập vào
        public string MatKhauNhap { get; private set; } = "";

        public frmNhapMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) // Kiểm tra nếu ô nhập trống
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus(); // Đưa con trỏ về ô nhập mật khẩu
                return; // Dừng xử lý nếu chưa nhập mật khẩu
            }

            // Nếu có mật khẩu, thực hiện xử lý tiếp theo
            this.DialogResult = DialogResult.OK; // Đóng form với kết quả OK
            this.Close();
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Hủy bỏ nhập mật khẩu
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = txtMatKhau.Text.Length > 0;
        }

        private void FormNhapMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhau.Focus(); // Đưa con trỏ chuột vào ô nhập mật khẩu
            txtMatKhau.Text = ""; // Xóa mật khẩu nếu có dữ liệu cũ
        }

    }
}
