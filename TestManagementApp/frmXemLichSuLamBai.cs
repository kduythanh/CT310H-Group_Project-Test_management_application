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
        private string maDeThi;
        public frmXemLichSuLamBai(string maDeThi)
        {
            InitializeComponent();
            this.maDeThi = maDeThi;
            LoadLabels();
            LoadLichSuBaiLam();
        }

        private void LoadLabels()
        {
            lblTenMaHS.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";

            if (!clsDatabase.OpenConnection())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
            SELECT B.DIEM, B.THOI_GIAN_LAM, D.THOI_LUONG, D.TEN_DE_THI, T.HO_TEN AS GV
            FROM BAI_THI B
            JOIN DE_THI D ON B.MA_DE_THI = D.MA_DE_THI
            JOIN TAI_KHOAN T ON D.MA_TK = T.MA_TK
            WHERE B.MA_DE_THI = @maDeThi AND B.MA_TK = @maTk
            ORDER BY B.THOI_GIAN_LAM DESC";

            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
            cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
            cmd.Parameters.AddWithValue("@maTk", Session.TenTaiKhoan);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblDiem.Text = reader["DIEM"].ToString();
                lblTimeLamBai.Text = Convert.ToDateTime(reader["THOI_GIAN_LAM"]).ToString("HH:mm dd/MM/yyyy");
                lblThoiLuong.Text = reader["THOI_LUONG"].ToString() + " phút";
                lblTenBaiThi.Text = reader["TEN_DE_THI"].ToString();
                lblTenGV.Text = reader["GV"].ToString();
                lblMaDe.Text = maDeThi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lịch sử làm bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            reader.Close();
            clsDatabase.CloseConnection();
        }

        void LoadLichSuBaiLam()
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = @"
            SELECT CH.NOI_DUNG AS CauHoi, CTBT.PHUONG_AN_CHON AS PhuongAnChon, CTBT.KET_QUA AS KetQua
            FROM CHI_TIET_BAI_THI CTBT
            JOIN CAU_HOI CH ON CTBT.MA_CAU_HOI = CH.MA_CAU_HOI
            JOIN BAI_THI BT ON CTBT.MA_BAI_THI = BT.MA_BAI_THI
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

                DataTable dtFinal = dt.DefaultView.ToTable(false, "STT", "CauHoi", "PhuongAnChon", "KetQua");

                dgvKetQuaLamBai.DataSource = dtFinal;

                dgvKetQuaLamBai.Columns["STT"].HeaderText = "STT";
                dgvKetQuaLamBai.Columns["CauHoi"].HeaderText = "Nội dung câu hỏi";
                dgvKetQuaLamBai.Columns["PhuongAnChon"].HeaderText = "Phương án chọn";
                dgvKetQuaLamBai.Columns["KetQua"].HeaderText = "Kết quả";

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
