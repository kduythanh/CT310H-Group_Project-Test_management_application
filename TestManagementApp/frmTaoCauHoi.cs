using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManagementApp
{
    public partial class frmTaoCauHoi : Form
    {
        public frmTaoCauHoi()
        {
            InitializeComponent();
        }

        private void frmTaoCauHoi_Load(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                loadDeThi();
                loadCauHoi();
                rdoText.Checked = true;
                dgvDanhSachCauHoi.AutoGenerateColumns = false;
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // kiểm tra xem người dùng chọn nhập văn bản hay chọn ảnh để hiển thị
        private void hienThiTruongNoiDung()
        {
            if (rdoText.Checked)
            {
                rtbNoiDung.Visible = true; // Hiển thị ô nhập văn bản
                picNoiDung.Visible = false; // Ẩn PictureBox
                btnChonAnh.Visible = false; // Ẩn nút chọn ảnh
            }
            else if (rdoImage.Checked)
            {
                rtbNoiDung.Visible = false; // Ẩn ô nhập văn bản
                picNoiDung.Visible = true; // Hiển thị PictureBox
                btnChonAnh.Visible = true; // Hiển thị nút chọn ảnh
            }
        }

        // hiển thị trường nhập văn bản nếu người dùng chọn nhập văn bản
        private void rdoText_CheckedChanged(object sender, EventArgs e)
        {
            hienThiTruongNoiDung();
        }

        // hiển thị trường chọn ảnh nếu người dùng chọn nhập ảnh
        private void rdoImage_CheckedChanged(object sender, EventArgs e)
        {
            hienThiTruongNoiDung();
        }

        // lấy thông tin các đề thi từ csdl và hiển thị lên ComboBox
        private void loadDeThi()
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    // Tạo câu lệnh truy vấn
                    string query = "SELECT MA_DE_THI, TEN_DE_THI FROM DE_THI";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán dữ liệu vào ComboBox môn học
                    cboTenDeThi.DataSource = dt;
                    cboTenDeThi.DisplayMember = "TEN_DE_THI"; // Hiển thị tên môn học
                    cboTenDeThi.ValueMember = "MA_DE_THI";    // Lưu giá trị là mã môn học
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu môn học: " + ex.Message);
                }
                finally
                {
                    clsDatabase.CloseConnection(); // Đóng kết nối sau khi thực thi
                }
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chọn ảnh từ máy tính
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    picNoiDung.Image = Image.FromFile(filePath);
                    picNoiDung.SizeMode = PictureBoxSizeMode.StretchImage; // Hiển thị ảnh vừa với khung
                }
            }
        }

        // Lưu ảnh vào thư mục "Image" trong project và trả về đường dẫn 
        private string getPath(Image image)
        {
            try
            {
                // Lấy đường dẫn thư mục gốc của project
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;

                // Chuyển đến thư mục "Image" trong project
                string imagePath = Path.Combine(projectPath, "Image");

                // Kiểm tra nếu thư mục "Image" chưa tồn tại thì tạo mới
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                // Tạo tên file duy nhất
                string fileName = Guid.NewGuid().ToString("N").Substring(0, 8) + ".png";
                string fullPath = Path.Combine(imagePath, fileName);

                // Lưu ảnh vào thư mục
                image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);

                return fullPath; // Trả về đường dẫn ảnh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                return null;
            }
        }

        // thêm một câu hỏi mới vào csdl
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    // tạo ngẫu nhiên mã câu hỏi trước khi thêm vào csdl
                    string maCauHoi = Guid.NewGuid().ToString("N").Substring(0, 8);
                    string noiDung;
                    int loaiNoiDung;
                    if (rdoText.Checked)
                    { // nếu người dùng chọn nhập văn bản thì lấy nội dung từ RichTextBox
                        noiDung = rtbNoiDung.Text;
                        loaiNoiDung = 0;
                    }
                    else 
                    { // nếu người dùng chọn nhập ảnh thì lưu ảnh vào thư mục và lấy đường dẫn
                        string filePath = getPath(picNoiDung.Image);
                        loaiNoiDung = 1;
                        if (string.IsNullOrEmpty(filePath))
                        {
                            MessageBox.Show("Lưu ảnh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        noiDung = filePath;
                    }
                    
                    // báo lỗi nếu người dùng chưa chọn đáp án cho câu hỏi
                    if (cboKQ.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn đáp án đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // tạo câu lệnh sql để thêm câu hỏi vào csdl
                    string query = "INSERT INTO CAU_HOI " +
                        "(MA_CAU_HOI, MA_DE_THI, NOI_DUNG, PHUONG_AN_A, PHUONG_AN_B, PHUONG_AN_C, PHUONG_AN_D, DAP_AN, LOAI_NOI_DUNG) " +
                       "VALUES (@MA_CAU_HOI, @MA_DE_THI, @NOI_DUNG, @PA_A, @PA_B, @PA_C, @PA_D, @DAP_AN, @LOAI_NOI_DUNG)";

                    // truyền biến vao câu lệnh sql
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                    cmd.Parameters.AddWithValue("@MA_CAU_HOI", maCauHoi);
                    cmd.Parameters.AddWithValue("@MA_DE_THI", cboTenDeThi.SelectedValue);
                    cmd.Parameters.AddWithValue("@NOI_DUNG", noiDung);
                    cmd.Parameters.AddWithValue("@PA_A", txtDapAnA.Text);
                    cmd.Parameters.AddWithValue("@PA_B", txtDapAnB.Text);
                    cmd.Parameters.AddWithValue("@PA_C", txtDapAnC.Text);
                    cmd.Parameters.AddWithValue("@PA_D", txtDapAnD.Text);
                    cmd.Parameters.AddWithValue("@DAP_AN", cboKQ.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LOAI_NOI_DUNG", loaiNoiDung);
                    
                    // thực thi câu lệnh
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // xóa thông tin đã nhập để người dùng nhập câu hỏi mới
                    rtbNoiDung.Clear();
                    picNoiDung.Image = null;
                    txtDapAnA.Clear();
                    txtDapAnB.Clear();
                    txtDapAnC.Clear();
                    txtDapAnD.Clear();
                    cboKQ.SelectedIndex = -1;

                    loadCauHoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm câu hỏi: " + ex.Message);
                }
                finally
                {
                    clsDatabase.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear các nội dung cũ khi người dùng đổi đề thi
        private void cboTenDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCauHoi();

            rtbNoiDung.Clear();
            picNoiDung.Image = null;
            txtDapAnA.Clear();
            txtDapAnB.Clear();
            txtDapAnC.Clear();
            txtDapAnD.Clear();
            cboKQ.SelectedIndex = -1;

        }

        // load danh sách câu hỏi của đề thi đã chọn
        private void loadCauHoi()
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    string query = "SELECT * FROM CAU_HOI WHERE MA_DE_THI = @MA_DE_THI";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                    cmd.Parameters.AddWithValue("@MA_DE_THI", cboTenDeThi.SelectedValue?.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachCauHoi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu câu hỏi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // hiển thị nội dung câu hỏi khi người dùng chọn một câu hỏi trong danh sách
        private void dgvDanhSachCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo nhấp vào một hàng hợp lệ
            {

                DataGridViewRow row = dgvDanhSachCauHoi.Rows[e.RowIndex];

                if (clsDatabase.OpenConnection())
                {
                    try
                    {
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        string maCauHoi = row.Cells["colMaCauHoi"].Value?.ToString(); // Sử dụng tên cột hiển thị
                        if (string.IsNullOrEmpty(maCauHoi))
                        {
                            MessageBox.Show("Không tìm thấy mã câu hỏi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string query = "SELECT LOAI_NOI_DUNG, NOI_DUNG, PHUONG_AN_A, PHUONG_AN_B, PHUONG_AN_C, PHUONG_AN_D, DAP_AN " +
                                      "FROM CAU_HOI WHERE MA_CAU_HOI = @MA_CAU_HOI";
                        SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                        cmd.Parameters.AddWithValue("@MA_CAU_HOI", maCauHoi);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int loaiNoiDung = Convert.ToInt32(reader["LOAI_NOI_DUNG"]);
                            string noiDung = reader["NOI_DUNG"].ToString();

                            // Hiển thị nội dung câu hỏi
                            if (loaiNoiDung == 0) // Text
                            {
                                rdoText.Checked = true;
                                rtbNoiDung.Text = noiDung;
                            }
                            else if (loaiNoiDung == 1) // Image
                            {
                                rdoImage.Checked = true;
                                try
                                {
                                    picNoiDung.Image = Image.FromFile(noiDung);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    picNoiDung.Image = null;
                                }
                            }

                            // Gán các đáp án vào TextBox
                            txtDapAnA.Text = reader["PHUONG_AN_A"].ToString();
                            txtDapAnB.Text = reader["PHUONG_AN_B"].ToString();
                            txtDapAnC.Text = reader["PHUONG_AN_C"].ToString();
                            txtDapAnD.Text = reader["PHUONG_AN_D"].ToString();

                            // Gán đáp án đúng vào ComboBox
                            string dapAn = reader["DAP_AN"].ToString();
                            if (!string.IsNullOrEmpty(dapAn))
                            {
                                switch (dapAn)
                                {
                                    case "A":
                                        cboKQ.SelectedIndex = 0;
                                        break;
                                    case "B":
                                        cboKQ.SelectedIndex = 1;
                                        break;
                                    case "C":
                                        cboKQ.SelectedIndex = 2;
                                        break;
                                    case "D":
                                        cboKQ.SelectedIndex = 3;
                                        break;
                                    default:
                                        cboKQ.SelectedIndex = -1;
                                        break;
                                }
                            }
                            else
                            {
                                cboKQ.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy câu hỏi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        clsDatabase.CloseConnection();
                    }
                }
            }
        }

        // xoá câu hỏi mà người dùng đã chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    if (dgvDanhSachCauHoi.SelectedRows.Count > 0)
                    {
                        btnXoa.Enabled = true;
                        string maCauHoi = dgvDanhSachCauHoi.SelectedRows[0].Cells["colMaCauHoi"].Value?.ToString();
                        if (string.IsNullOrEmpty(maCauHoi))
                        {
                            MessageBox.Show("Không tìm thấy mã câu hỏi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Hiển thị hộp thoại xác nhận trước khi xóa
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.No) return;
                        // Xóa ở bảng CHI_TIET_BAI_THI trước
                        string query = "DELETE FROM CHI_TIET_BAI_THI WHERE MA_CAU_HOI = @MA_CAU_HOI";
                        SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                        cmd.Parameters.AddWithValue("@MA_CAU_HOI", maCauHoi);
                        cmd.ExecuteNonQuery();
                        // Xóa ở bảng CAU_HOI
                        query = "DELETE FROM CAU_HOI WHERE MA_CAU_HOI = @MA_CAU_HOI";
                        cmd = new SqlCommand(query, clsDatabase.con);
                        cmd.Parameters.AddWithValue("@MA_CAU_HOI", maCauHoi);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rtbNoiDung.Clear();
                        picNoiDung.Image = null;
                        txtDapAnA.Clear();
                        txtDapAnB.Clear();
                        txtDapAnC.Clear();
                        txtDapAnD.Clear();
                        loadCauHoi();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn câu hỏi cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa câu hỏi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    clsDatabase.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear các thông tin đã nhập 
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Clear();
            picNoiDung.Image = null;
            txtDapAnA.Clear();
            txtDapAnB.Clear();
            txtDapAnC.Clear();
            txtDapAnD.Clear();
            cboKQ.SelectedIndex = -1;
            dgvDanhSachCauHoi.ClearSelection();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        // sửa các thông tin về câu hỏi mà người dùng đã chọn
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    if (dgvDanhSachCauHoi.SelectedRows.Count > 0)
                    {
                        btnSua.Enabled = true;
                        string maCauHoi = dgvDanhSachCauHoi.SelectedRows[0].Cells["colMaCauHoi"].Value?.ToString();
                        if (string.IsNullOrEmpty(maCauHoi))
                        {
                            MessageBox.Show("Không tìm thấy mã câu hỏi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string noiDung;
                        int loaiNoiDung;
                        if (rdoText.Checked)
                        {
                            noiDung = rtbNoiDung.Text;
                            loaiNoiDung = 0;
                        }
                        else
                        {
                            string filePath = getPath(picNoiDung.Image);
                            loaiNoiDung = 1;
                            if (string.IsNullOrEmpty(filePath))
                            {
                                MessageBox.Show("Lưu ảnh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            noiDung = filePath;
                        }
                        if (cboKQ.SelectedItem == null)
                        {
                            MessageBox.Show("Vui lòng chọn đáp án đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string query = "UPDATE CAU_HOI " +
                            "SET NOI_DUNG = @NOI_DUNG, PHUONG_AN_A = @PA_A, PHUONG_AN_B = @PA_B, PHUONG_AN_C = @PA_C, PHUONG_AN_D = @PA_D, DAP_AN = @DAP_AN, LOAI_NOI_DUNG = @LOAI_NOI_DUNG " +
                            "WHERE MA_CAU_HOI = @MA_CAU_HOI";
                        SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                        cmd.Parameters.AddWithValue("@MA_CAU_HOI", maCauHoi);
                        cmd.Parameters.AddWithValue("@NOI_DUNG", noiDung);
                        cmd.Parameters.AddWithValue("@PA_A", txtDapAnA.Text);
                        cmd.Parameters.AddWithValue("@PA_B", txtDapAnB.Text);
                        cmd.Parameters.AddWithValue("@PA_C", txtDapAnC.Text);
                        cmd.Parameters.AddWithValue("@PA_D", txtDapAnD.Text);
                        cmd.Parameters.AddWithValue("@DAP_AN", cboKQ.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue("@LOAI_NOI_DUNG", loaiNoiDung);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadCauHoi();
                    }
                    else 
                    {
                        MessageBox.Show("Vui lòng chọn câu hỏi cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa câu hỏi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    clsDatabase.CloseConnection();

                }
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
