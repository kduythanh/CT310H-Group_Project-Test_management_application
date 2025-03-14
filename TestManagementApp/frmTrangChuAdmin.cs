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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TestManagementApp
{
    public partial class frmTrangChuAdmin : Form
    {
        public frmTrangChuAdmin()
        {
            InitializeComponent();
            cboLoaiTaiKhoan.SelectedIndex = 0;
            LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
            btnSuaTaiKhoan.Enabled = false;
            btnXoaTaiKhoan.Enabled = false;
        }
        void LoadTaiKhoan(string role)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MA_TK, HO_TEN FROM TAI_KHOAN WHERE ROLE = @ROLE", clsDatabase.con);
                if (role == "Giáo viên") com.Parameters.AddWithValue("@ROLE", 1);
                else if (role == "Học sinh") com.Parameters.AddWithValue("@ROLE", 0);
                else return;

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDSTaiKhoan.DataSource = dt;
                dgvDSTaiKhoan.Columns["MA_TK"].HeaderText = "Tên tài khoản";
                dgvDSTaiKhoan.Columns["HO_TEN"].HeaderText = "Họ và tên";
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.TenTaiKhoan = null;
                Session.HoTen = null;
                Session.Role = -1;

                this.Close();
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.Show();
            }
        }

        private void cboLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
        }

        private void frmTrangChuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemSuaTaiKhoan frm = new frmThemSuaTaiKhoan();
            frm.AccountAdded += (s, ev) => LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
            frm.Show();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvDSTaiKhoan.SelectedRows.Count > 0)
            {
                string accountName = dgvDSTaiKhoan.SelectedRows[0].Cells["MA_TK"].Value.ToString();
                string fullName = dgvDSTaiKhoan.SelectedRows[0].Cells["HO_TEN"].Value.ToString();
                int role = cboLoaiTaiKhoan.SelectedIndex == 0 ? 1 : 0; 

                frmThemSuaTaiKhoan frm = new frmThemSuaTaiKhoan(accountName, fullName, role);
                frm.AccountAdded += (s, ev) => LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                btnSuaTaiKhoan.Enabled = true;
            }
        }

        private void dgvDSTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            // Enable the delete button only if a row is selected
            btnXoaTaiKhoan.Enabled = dgvDSTaiKhoan.SelectedRows.Count > 0;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvDSTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row's MA_TK value
            string accountName = dgvDSTaiKhoan.SelectedRows[0].Cells["MA_TK"].Value.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản với MA_TK = {accountName} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TAI_KHOAN WHERE MA_TK = @MA_TK", clsDatabase.con);
                    cmd.Parameters.AddWithValue("@MA_TK", accountName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTaiKhoan(cboLoaiTaiKhoan.SelectedItem.ToString()); // Refresh account list
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    clsDatabase.CloseConnection();
                }
            }
        }

    }
}
