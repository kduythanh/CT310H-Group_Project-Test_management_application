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
    public partial class frmLamBaiThi: Form
    {
        private string maDeThi;
        public frmLamBaiThi(string maDeThi)
        {
            InitializeComponent();
            maDeThi = maDeThi;
        }

        private void frmLamBaiThi_Load(object sender, EventArgs e)
        {

        }
    }
}
