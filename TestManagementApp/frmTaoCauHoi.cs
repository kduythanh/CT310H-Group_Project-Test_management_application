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
                rdoText.Checked = true;
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void rdoText_CheckedChanged(object sender, EventArgs e)
        {
            hienThiTruongNoiDung();
        }

        private void rdoImage_CheckedChanged(object sender, EventArgs e)
        {
            hienThiTruongNoiDung();
        }

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
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
