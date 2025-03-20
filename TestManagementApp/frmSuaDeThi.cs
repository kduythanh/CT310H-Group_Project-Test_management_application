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
    public partial class frmSuaDeThi : Form
    {
        public string MaDeThi { get; set; }
        public bool IsUpdated { get; private set; }
        public frmSuaDeThi()
        {
            InitializeComponent();
        }

        private void frmSuaDeThi_Load(object sender, EventArgs e)
        {
            // Khởi tạo ComboBox với giá trị hiển thị và giá trị thực
            cboTrangThai.Items.Add(new { Text = "đã đóng", Value = 0 });
            cboTrangThai.Items.Add(new { Text = "đang mở", Value = 1 });
            cboTrangThai.DisplayMember = "Text"; // Hiển thị "đã đóng" hoặc "đang mở"
            cboTrangThai.ValueMember = "Value";
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    string maDeThi = MaDeThi;
                    SqlCommand cmd = new SqlCommand(
                     "SELECT * FROM DE_THI DT " +
                     "JOIN MON_HOC MH ON DT.MA_MON = MH.MA_MON WHERE MA_DE_THI = @MA_DE_THI", clsDatabase.con);
                    cmd.Parameters.AddWithValue("@MA_DE_THI", maDeThi);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            txtMonHoc.Text = reader["TEN_MON"].ToString();
                            txtTenDeThi.Text = reader["TEN_DE_THI"].ToString();
                            txtMK.Text = reader["MAT_KHAU_DE"].ToString();
                            txtThoiLuong.Text = reader["THOI_LUONG"].ToString();
                            int trangThai = reader["TRANG_THAI"] != DBNull.Value ? Convert.ToInt32(reader["TRANG_THAI"]) : 0;
                            if (trangThai == 0)
                            {
                                cboTrangThai.SelectedIndex = 0;
                            }
                            else
                            {
                                cboTrangThai.SelectedIndex = 1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + " Không thể load dữ liệu");
                }
                finally
                {
                    clsDatabase.CloseConnection();
                }

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    string maDeThi = MaDeThi;
                    if (string.IsNullOrEmpty(maDeThi))
                    {
                        MessageBox.Show("Không tìm thấy mã đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra và chuyển đổi giá trị của THOI_LUONG
                    int thoiLuong;
                    if (!int.TryParse(txtThoiLuong.Text, out thoiLuong))
                    {
                        MessageBox.Show("Thời lượng phải là một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lấy giá trị thực của TRANG_THAI từ ComboBox
                    int trangThai;
                    if (cboTrangThai.SelectedValue != null)
                    {
                        trangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
                    }
                    else
                    {
                        trangThai = 0;
                    }

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE DE_THI SET TEN_DE_THI = @TEN_DE_THI, MAT_KHAU_DE = @MAT_KHAU_DE, THOI_LUONG = @THOI_LUONG, TRANG_THAI = @TRANG_THAI " +
                        "WHERE MA_DE_THI = @MA_DE_THI", clsDatabase.con);

                    cmd.Parameters.AddWithValue("@MA_DE_THI", maDeThi);
                    cmd.Parameters.AddWithValue("@TEN_DE_THI", txtTenDeThi.Text);
                    cmd.Parameters.AddWithValue("@MAT_KHAU_DE", txtMK.Text);
                    cmd.Parameters.AddWithValue("@THOI_LUONG", thoiLuong); 
                    cmd.Parameters.AddWithValue("@TRANG_THAI", trangThai); 

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật đề thi thành công!");
                        IsUpdated = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đề thi thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + " Không thể cập nhật dữ liệu");
                }
                finally
                {
                    clsDatabase.CloseConnection();
                }
            }
        }
    }
}
