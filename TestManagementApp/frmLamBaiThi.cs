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
    public partial class frmLamBaiThi : Form
    {
        private string maDeThi;
        private int thoiLuong;
        private int remainingTime;
        private System.Windows.Forms.Timer countdownTimer;
        private List<CauHoi> cauHoiList;
        private int currentQuestionIndex = 0;
        private string maBaiThi;
        private List<string> studentAnswers;


        public frmLamBaiThi(string maDeThi, string maTK, string tenDeThi)
        {
            InitializeComponent();
            btnThoat.Enabled = false;
            this.maDeThi = maDeThi;
            LoadExamInfo();
            SetupCountdown();
            this.maBaiThi = GenerateMaBaiThi(maTK, maDeThi);
            this.lbl_TenBaiThi.Text = tenDeThi;
            // danh sách đáp án người dùng chọn
            studentAnswers = new List<string>();
            LoadQuestions();
            lblSoCauHoi.Text = "Đề thi gồm có " + cauHoiList.Count + " câu.";
        }

        private void frmLamBaiThi_Load(object sender, EventArgs e)
        {
            DisplayQuestion();
            dgvDapAn.Visible = false;
            lblKetQua.Visible = false;
        }

        private void LoadExamInfo()
        {
            if (clsDatabase.OpenConnection())
            {
                string query = "SELECT THOI_LUONG FROM DE_THI WHERE MA_DE_THI = @maDeThi";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
                    thoiLuong = Convert.ToInt32(cmd.ExecuteScalar());
                }
                clsDatabase.CloseConnection();
            }
        }

        private void LoadQuestions()
        {
            cauHoiList = new List<CauHoi>();
            if (clsDatabase.OpenConnection())
            {
                string query = "SELECT * FROM CAU_HOI WHERE MA_DE_THI = @maDeThi";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cauHoiList.Add(new CauHoi
                            {
                                MaCauHoi = reader["MA_CAU_HOI"].ToString(),
                                NoiDung = reader["NOI_DUNG"].ToString(),
                                PhuongAnA = reader["PHUONG_AN_A"].ToString(),
                                PhuongAnB = reader["PHUONG_AN_B"].ToString(),
                                PhuongAnC = reader["PHUONG_AN_C"].ToString(),
                                PhuongAnD = reader["PHUONG_AN_D"].ToString(),
                                DapAn = reader["DAP_AN"].ToString(),
                                LoaiNoiDung = Convert.ToInt32(reader["LOAI_NOI_DUNG"])
                            });
                        }
                    }
                }
                clsDatabase.CloseConnection();

            }
            // gán full null cho danh sách chọn đáp án khi mới mở đề thi
            foreach (var _ in cauHoiList)
            {
                studentAnswers.Add(null);
            }
        }

        private void SetupCountdown()
        {
            remainingTime = thoiLuong * 60;
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTick;
            countdownTimer.Start();
        }

        private void CountdownTick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
                label1.Text = timeSpan.ToString(@"mm\:ss");
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("Hết giờ làm bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubmitExam();
            }
        }

        private void DisplayQuestion()
        {
            if (cauHoiList.Count == 0) return;

            var question = cauHoiList[currentQuestionIndex];
            if (question.LoaiNoiDung == 0)
            {
                lblCauHoi.Visible = true;
                picNoiDung.Visible = false;
                lblCauHoi.Text = $"Câu {currentQuestionIndex + 1}. {question.NoiDung}";
            }
            else if (question.LoaiNoiDung == 1)
            {
                //lblCauHoi.Visible = false;
                lblCauHoi.Text = $"Câu {currentQuestionIndex + 1}. ";
                picNoiDung.Visible = true;
                try
                {
                    picNoiDung.Image = Image.FromFile(question.NoiDung); // Load image from file path
                    picNoiDung.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image to fit PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picNoiDung.Image = null; // Clear the PictureBox if image loading fails
                }
            }
            radbtnA.Text = "A. " + question.PhuongAnA;
            radbtnB.Text = "B. " + question.PhuongAnB;
            radbtnC.Text = "C. " + question.PhuongAnC;
            radbtnD.Text = "D. " + question.PhuongAnD;

            radbtnA.Checked = false;
            radbtnB.Checked = false;
            radbtnC.Checked = false;
            radbtnD.Checked = false;

            // Load đáp án đã chọn nếu có
            string selectedAnswer = studentAnswers[currentQuestionIndex];
            if (selectedAnswer == "A") radbtnA.Checked = true;
            if (selectedAnswer == "B") radbtnB.Checked = true;
            if (selectedAnswer == "C") radbtnC.Checked = true;
            if (selectedAnswer == "D") radbtnD.Checked = true;

            btnCauTruoc.Enabled = currentQuestionIndex > 0;
            btnCauSau.Enabled = currentQuestionIndex < cauHoiList.Count - 1;

        }

        private void BtnCauTruoc_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer(); //Lưu đáp án trước khi chuyển câu
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }

        private void BtnCauSau_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            if (currentQuestionIndex < cauHoiList.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi bài thi không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            countdownTimer.Stop();
            SubmitExam();
            btnNopBai.Enabled = false;
            btnThoat.Enabled = true;

        }

        // hàm lưu đáp án khi chọn
        private void SaveCurrentAnswer()
        {
            // Lưu phương án chọn vào danh sách studentAnswers
            studentAnswers[currentQuestionIndex] = GetSelectedAnswer();
        }

        private void SubmitExam()
        {
            // Chỉ lưu CHI_TIET_BAI_THI

            if (clsDatabase.OpenConnection())
            {
                for (int i = 0; i < cauHoiList.Count; i++)
                {
                    var question = cauHoiList[i];
                    string studentAnswer = studentAnswers[i];
                    string result = (studentAnswer == question.DapAn) ? "Đúng" : "Sai";

                    string insertQuery = "INSERT INTO CHI_TIET_BAI_THI (MA_BAI_THI, MA_CAU_HOI, PHUONG_AN_CHON, KET_QUA) " +
                                         "VALUES (@maBaiThi, @maCauHoi, @phuongAnChon, @ketQua)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, clsDatabase.con))
                    {
                        cmd.Parameters.AddWithValue("@maBaiThi", maBaiThi);
                        cmd.Parameters.AddWithValue("@maCauHoi", question.MaCauHoi);
                        cmd.Parameters.AddWithValue("@phuongAnChon", (object)studentAnswer ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ketQua", result);
                        cmd.ExecuteNonQuery();
                    }
                }
                clsDatabase.CloseConnection();
            }
            TinhDiemVaHienThi();
            DisplayResults();
        }


        private string GetSelectedAnswer()
        {
            if (radbtnA.Checked) return "A";
            if (radbtnB.Checked) return "B";
            if (radbtnC.Checked) return "C";
            if (radbtnD.Checked) return "D";
            return null;
        }

        private void DisplayResults()
        {
            dgvDapAn.Rows.Clear();
            dgvDapAn.Visible = true;
            lblKetQua.Visible = true;

            if (clsDatabase.OpenConnection())
            {
                string query = "SELECT C.MA_CAU_HOI, C.PHUONG_AN_CHON, Q.DAP_AN " +
                               "FROM CHI_TIET_BAI_THI C " +
                               "JOIN CAU_HOI Q ON C.MA_CAU_HOI = Q.MA_CAU_HOI " +
                               "WHERE C.MA_BAI_THI = @maBaiThi";

                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@maBaiThi", maBaiThi);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int stt = 1;
                        while (reader.Read())
                        {
                            string studentAnswer = reader["PHUONG_AN_CHON"]?.ToString();
                            string correctAnswer = reader["DAP_AN"].ToString();
                            string status = studentAnswer == correctAnswer ? "Đúng" : "Sai";

                            dgvDapAn.Rows.Add(stt, studentAnswer ?? "No Answer", correctAnswer, status);
                            stt++;
                        }
                    }
                }
                clsDatabase.CloseConnection();
            }
        }
        private string GenerateMaBaiThi(string maTk, string maDeThi)
        {
            string newMaBaiThi = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper(); // Generate unique ID

            if (clsDatabase.OpenConnection())
            {
                string query = "INSERT INTO BAI_THI (MA_BAI_THI, MA_DE_THI, MA_TK, THOI_GIAN_LAM, DIEM) " +
                               "VALUES (@maBaiThi, @maDeThi, @maTk, GETDATE(), NULL)";

                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@maBaiThi", newMaBaiThi);
                    cmd.Parameters.AddWithValue("@maDeThi", maDeThi);
                    cmd.Parameters.AddWithValue("@maTk", maTk);
                    cmd.ExecuteNonQuery();
                }

                clsDatabase.CloseConnection();
            }

            return newMaBaiThi;
        }

        private void TinhDiemVaHienThi()
        {
            int soCauDung = 0;
            int tongCau = 0;

            if (clsDatabase.OpenConnection())
            {
                string query = "SELECT C.PHUONG_AN_CHON, Q.DAP_AN " +
                               "FROM CHI_TIET_BAI_THI C " +
                               "JOIN CAU_HOI Q ON C.MA_CAU_HOI = Q.MA_CAU_HOI " +
                               "WHERE C.MA_BAI_THI = @maBaiThi";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@maBaiThi", maBaiThi);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tongCau++;
                            string studentAnswer = reader["PHUONG_AN_CHON"]?.ToString();
                            string correctAnswer = reader["DAP_AN"].ToString();
                            if (!string.IsNullOrEmpty(studentAnswer) && studentAnswer == correctAnswer)
                                soCauDung++;
                        }
                    }
                }
                clsDatabase.CloseConnection();
            }

            double diem = (tongCau > 0) ? ((double)soCauDung / tongCau * 10) : 0;

            // *** CẬP NHẬT ĐIỂM VÀO BẢNG BAI_THI ***
            if (clsDatabase.OpenConnection())
            {
                string updateQuery = "UPDATE BAI_THI SET DIEM = @diem WHERE MA_BAI_THI = @maBaiThi";
                using (SqlCommand cmd = new SqlCommand(updateQuery, clsDatabase.con))
                {
                    cmd.Parameters.AddWithValue("@diem", diem);
                    cmd.Parameters.AddWithValue("@maBaiThi", maBaiThi);
                    cmd.ExecuteNonQuery();
                }
                clsDatabase.CloseConnection();
            }

            lblKetQua.Text = $"Điểm của bài thi: {diem:F2} điểm\nSố câu đúng: {soCauDung}/{tongCau} câu";
        }

    }




    public class CauHoi
    {
        public string MaCauHoi { get; set; }
        public string NoiDung { get; set; }
        public string PhuongAnA { get; set; }
        public string PhuongAnB { get; set; }
        public string PhuongAnC { get; set; }
        public string PhuongAnD { get; set; }
        public string DapAn { get; set; }
        public int LoaiNoiDung { get; set; }
    }
}

