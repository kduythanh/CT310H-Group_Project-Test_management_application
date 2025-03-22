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
    public partial class frmTrangChuGV : Form
    {
        public frmTrangChuGV()
        {
            InitializeComponent();
            LoadGV();
            loadDeThi();
            dgvDeThi.AutoGenerateColumns = false;
        }

        void LoadGV()
        {
            txtGiaoVien.Text = Session.HoTen + " (" + Session.TenTaiKhoan + ")";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa thông tin đăng nhập
                Session.TenTaiKhoan = null;
                Session.HoTen = null;
                Session.Role = -1;

                // Đóng form hiện tại và quay lại form đăng nhập
                this.Close();
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.Show();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.Show();
        }

        private void btnThemDeThi_Click(object sender, EventArgs e)
        {
            using (frmTaoDeThi frmTaoDeThi = new frmTaoDeThi())
            {
                frmTaoDeThi.ShowDialog(); // Hiển thị form dưới dạng dialog để chờ xử lý
                if (frmTaoDeThi.IsDataAdded) // Kiểm tra xem dữ liệu đã được thêm không
                {
                    loadDeThi(); // Load lại dữ liệu nếu có dữ liệu mới
                }
            }
        }

        private void btnSuaCauHoi_Click(object sender, EventArgs e)
        {
            frmTaoCauHoi frmTaoCauHoi = new frmTaoCauHoi();
            frmTaoCauHoi.Show();
        }

        private void loadDeThi()
        {
            if (clsDatabase.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT DT.MA_DE_THI, DT.TEN_DE_THI, MH.MA_MON, MH.TEN_MON, DT.MA_TK, DT.MAT_KHAU_DE, DT.THOI_LUONG, DT.TRANG_THAI " +
                    "FROM DE_THI DT JOIN MON_HOC MH ON DT.MA_MON = MH.MA_MON WHERE MA_TK = @MA_TK;",
                    clsDatabase.con);
                cmd.Parameters.AddWithValue("@MA_TK", Session.TenTaiKhoan);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);


                dgvDeThi.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDeThi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cột hiện tại có phải là colTrangThai không
            if (dgvDeThi.Columns[e.ColumnIndex].Name == "colTrangThai" && e.Value != null)
            {
                int trangThai = Convert.ToInt32(e.Value);
                e.Value = (trangThai == 0) ? "đã đóng" : "đang mở"; // Chỉ thay đổi hiển thị
                e.FormattingApplied = true; // Đánh dấu là đã áp dụng định dạng
            }
        }

        private void btnXoaDeThi_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    if (dgvDeThi.SelectedRows.Count > 0)
                    {
                        string maDeThi = dgvDeThi.SelectedRows[0].Cells["colMaDeThi"].Value?.ToString();
                        if (string.IsNullOrEmpty(maDeThi))
                        {
                            MessageBox.Show("Không tìm thấy mã đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Hiển thị hộp thoại xác nhận trước khi xóa
                        DialogResult result = MessageBox.Show(
                            "Bạn có chắc chắn muốn xóa đề thi này không?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            string query = "DELETE FROM DE_THI WHERE MA_DE_THI = @MA_DE_THI";
                            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                            cmd.Parameters.AddWithValue("@MA_DE_THI", maDeThi);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDeThi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn đề thi cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa đề thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSuaDeThi_Click(object sender, EventArgs e)
        {
            if (clsDatabase.OpenConnection())
            {
                try
                {
                    if (dgvDeThi.SelectedRows.Count > 0)
                    {
                        string maDeThi = dgvDeThi.SelectedRows[0].Cells["colMaDeThi"].Value?.ToString();
                        if (string.IsNullOrEmpty(maDeThi))
                        {
                            MessageBox.Show("Không tìm thấy mã đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (var formSuaDeThi = new frmSuaDeThi())
                        {
                            // Truyền dữ liệu từ hàng được chọn vào form sửa
                            formSuaDeThi.MaDeThi = maDeThi;
                            formSuaDeThi.ShowDialog();
                            if (formSuaDeThi.IsUpdated) // Kiểm tra xem dữ liệu đã được thêm không
                            {
                                loadDeThi(); // Load lại dữ liệu nếu có dữ liệu mới
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn đề thi cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi sửa đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvDeThi_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có ít nhất một hàng được chọn
            if (dgvDeThi.SelectedRows.Count > 0)
            {
                btnSuaDeThi.Enabled = true;
                btnSuaCauHoi.Enabled = true;
                btnXoaDeThi.Enabled = true;
                btnXemKetQua.Enabled = true;
            }
            else
            {
                btnSuaDeThi.Enabled = false;
                btnSuaCauHoi.Enabled = false;
                btnXoaDeThi.Enabled = false;
                btnXemKetQua.Enabled = false;
            }
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            if (dgvDeThi.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng đang chọn
                string maDeThi = dgvDeThi.SelectedRows[0].Cells["colMaDeThi"].Value?.ToString();
                string tenDeThi = dgvDeThi.SelectedRows[0].Cells["colTenDeThi"].Value?.ToString();

                if (!string.IsNullOrEmpty(maDeThi) && !string.IsNullOrEmpty(tenDeThi))
                {
                    // Mở form Xem Kết Quả và truyền dữ liệu
                    this.Hide();
                    frmXemKQLamBai frmXemKQ = new frmXemKQLamBai(maDeThi, tenDeThi);
                    frmXemKQ.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
