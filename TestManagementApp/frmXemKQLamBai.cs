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
    public partial class frmXemKQLamBai : Form
    {
        public frmXemKQLamBai(string maDeThi, string tenDeThi)
        {
            InitializeComponent();
            loadKQLamBai(maDeThi);
            lblTenDeThi.Text = tenDeThi;
        }

        void loadKQLamBai (string maDeThi)
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = @"
                SELECT T.MA_TK, T.HO_TEN, B.THOI_GIAN_LAM, B.DIEM FROM BAI_THI B JOIN TAI_KHOAN T ON B.MA_TK = T.MA_TK 
                WHERE B.MA_DE_THI = @MADE";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                cmd.Parameters.AddWithValue("@MADE", maDeThi);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.Columns.Add("STT", typeof(int));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }

                DataTable dtFinal = dt.DefaultView.ToTable(false, "STT", "MA_TK", "HO_TEN", "THOI_GIAN_LAM", "DIEM");

                dgvKetQuaLamBai.DataSource = dtFinal;

                dgvKetQuaLamBai.Columns["STT"].HeaderText = "STT";
                dgvKetQuaLamBai.Columns["MA_TK"].HeaderText = "Tên tài khoản";
                dgvKetQuaLamBai.Columns["HO_TEN"].HeaderText = "Họ tên học sinh";
                dgvKetQuaLamBai.Columns["THOI_GIAN_LAM"].HeaderText = "Thời gian làm bài";
                dgvKetQuaLamBai.Columns["DIEM"].HeaderText = "Điểm";

                dgvKetQuaLamBai.ReadOnly = true;
                dgvKetQuaLamBai.AllowUserToAddRows = false;
                dgvKetQuaLamBai.AllowUserToDeleteRows = false;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChuGV frmTrangChuGV = new frmTrangChuGV();
            frmTrangChuGV.Show();
        }
    }
}
