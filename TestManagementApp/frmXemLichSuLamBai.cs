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
    public partial class frmXemLichSuLamBai: Form
    {
        public frmXemLichSuLamBai()
        {
            InitializeComponent();
            LoadLichSuBaiLam();
            lblTenMaHS.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";
        }

        void LoadLichSuBaiLam()
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = @"
            SELECT 
                DT.TEN_DE_THI AS TenDeThi, 
                BT.THOI_GIAN_LAM AS ThoiGianLam, 
                BT.DIEM AS Diem
            FROM BAI_THI BT
            JOIN DE_THI DT ON BT.MA_DE_THI = DT.MA_DE_THI
            WHERE BT.MA_TK = @tenTaiKhoan";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                cmd.Parameters.AddWithValue("@tenTaiKhoan", Session.TenTaiKhoan);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.Columns.Add("STT", typeof(int));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }

                DataTable dtFinal = dt.DefaultView.ToTable(false, "STT", "TenDeThi", "ThoiGianLam", "Diem");

                dgvKetQuaLamBai.DataSource = dtFinal;

                dgvKetQuaLamBai.Columns["STT"].HeaderText = "STT";
                dgvKetQuaLamBai.Columns["TenDeThi"].HeaderText = "Tên đề thi";
                dgvKetQuaLamBai.Columns["ThoiGianLam"].HeaderText = "Thời gian làm bài";
                dgvKetQuaLamBai.Columns["Diem"].HeaderText = "Điểm";

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
        }
    }
}
