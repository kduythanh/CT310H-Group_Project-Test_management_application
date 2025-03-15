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
    public partial class frmXacNhanThi: Form
    {
        private string selectedMaDeThi;
        public frmXacNhanThi(string maDeThi)
        {
            InitializeComponent();
            selectedMaDeThi = maDeThi;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtMatKhau.Text.Trim();
            string maDeThi = selectedMaDeThi; 

            if (string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsDatabase.OpenConnection())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT MAT_KHAU_DE FROM DE_THI WHERE MA_DE_THI = @maDeThi";
            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
            cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
            object result = cmd.ExecuteScalar();
            clsDatabase.CloseConnection();

            if (result != null && result.ToString() == enteredPassword)
            {
                frmLamBaiThi examForm = new frmLamBaiThi(maDeThi);
                this.Hide();
                examForm.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
