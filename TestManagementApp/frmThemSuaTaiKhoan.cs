﻿using System;
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
    public partial class frmThemSuaTaiKhoan: Form
    {
        public event EventHandler AccountAdded;
        private string existingAccountName = null;
        private string originalAccountName;
        private string originalFullName;
        private int originalRole;

        public frmThemSuaTaiKhoan()
        {
            InitializeComponent();
            LoadRoleData();
            cboRole.SelectedIndex = 0;
            lblTitle.Text = "Thêm Tài khoản"; // Default title for add mode
        }

        public frmThemSuaTaiKhoan(string accountName, string fullName, int role) : this()
        {
            existingAccountName = accountName;

            // Store original values for restoring on cancel
            originalAccountName = accountName;
            originalFullName = fullName;
            originalRole = role;

            // Populate fields with existing data (Edit Mode)
            txtAccountName.Text = accountName;
            txtFullName.Text = fullName;
            cboRole.SelectedValue = role;

            
            txtAccountName.Enabled = false;
            lblTitle.Text = "Sửa Tài khoản"; // Edit Mode: Change title
        }

        private void frmThemSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            if (existingAccountName != null)
            {
                txtAccountName.Enabled = false;
            }
        }

        private void LoadRoleData()
        {
            DataTable roleTable = new DataTable();
            roleTable.Columns.Add("RoleName", typeof(string));  
            roleTable.Columns.Add("RoleValue", typeof(int));   

            roleTable.Rows.Add("Học sinh", 0);
            roleTable.Rows.Add("Giáo viên", 1);

            cboRole.DataSource = roleTable;
            cboRole.DisplayMember = "RoleName"; 
            cboRole.ValueMember = "RoleValue";  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (existingAccountName == null) // Add mode
            {
                txtAccountName.Clear();
                txtFullName.Clear();
                txtPassword.Clear();
                cboRole.SelectedIndex = 0;
            }
            else // Edit mode
            {
                txtAccountName.Text = originalAccountName;
                txtFullName.Text = originalFullName;
                txtPassword.Clear();
                cboRole.SelectedIndex = originalRole;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cboRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string accountName = txtAccountName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            int role = Convert.ToInt32(cboRole.SelectedValue);

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd;

                if (existingAccountName == null) // Add Mode: Insert new account
                {
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM TAI_KHOAN WHERE MA_TK = @MA_TK", clsDatabase.con);
                    checkCmd.Parameters.AddWithValue("@MA_TK", accountName);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd = new SqlCommand("INSERT INTO TAI_KHOAN (MA_TK, HO_TEN, MAT_KHAU, ROLE) VALUES (@MA_TK, @HO_TEN, @MAT_KHAU, @ROLE)", clsDatabase.con);
                }
                else // Edit Mode: Update existing account
                {
                    cmd = new SqlCommand("UPDATE TAI_KHOAN SET HO_TEN = @HO_TEN, MAT_KHAU = @MAT_KHAU, ROLE = @ROLE WHERE MA_TK = @MA_TK", clsDatabase.con);
                }

                cmd.Parameters.AddWithValue("@MA_TK", accountName);
                cmd.Parameters.AddWithValue("@HO_TEN", fullName);
                cmd.Parameters.AddWithValue("@MAT_KHAU", password);
                cmd.Parameters.AddWithValue("@ROLE", role);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show(existingAccountName == null ? "Thêm tài khoản thành công!" : "Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountAdded?.Invoke(this, EventArgs.Empty);
                    this.Close(); // Close the form after confirming
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }
    }
}
