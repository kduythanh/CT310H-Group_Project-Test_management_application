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
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {

        }

        private void cboMaDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXemKetQua.Enabled = cboMaDeThi.SelectedIndex != -1; // Chỉ bật nút khi chọn mã đề
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
