namespace TestManagementApp
{
    partial class frmTrangChuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lblChonMonHoc = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiTaiKhoan
            // 
            this.cboLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTaiKhoan.FormattingEnabled = true;
            this.cboLoaiTaiKhoan.Items.AddRange(new object[] {
            "Giáo viên",
            "Học sinh"});
            this.cboLoaiTaiKhoan.Location = new System.Drawing.Point(273, 91);
            this.cboLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            this.cboLoaiTaiKhoan.Size = new System.Drawing.Size(464, 36);
            this.cboLoaiTaiKhoan.TabIndex = 20;
            this.cboLoaiTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTaiKhoan_SelectedIndexChanged);
            // 
            // lblChonMonHoc
            // 
            this.lblChonMonHoc.AutoSize = true;
            this.lblChonMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChonMonHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChonMonHoc.Location = new System.Drawing.Point(48, 95);
            this.lblChonMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonMonHoc.Name = "lblChonMonHoc";
            this.lblChonMonHoc.Size = new System.Drawing.Size(201, 28);
            this.lblChonMonHoc.TabIndex = 19;
            this.lblChonMonHoc.Text = "Chọn loại tài khoản:";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoTenGV.Location = new System.Drawing.Point(47, 26);
            this.lblHoTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(657, 37);
            this.lblHoTenGV.TabIndex = 21;
            this.lblHoTenGV.Text = "TRANG QUẢN LÝ TÀI KHOẢN CỦA QUẢN TRỊ VIÊN";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDangXuat.Location = new System.Drawing.Point(825, 26);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(144, 36);
            this.btnDangXuat.TabIndex = 22;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(48, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách tài khoản:";
            // 
            // dgvDSTaiKhoan
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTaiKhoan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(53, 202);
            this.dgvDSTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSTaiKhoan.RowHeadersWidth = 51;
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(685, 299);
            this.dgvDSTaiKhoan.TabIndex = 24;
            this.dgvDSTaiKhoan.Click += new System.EventHandler(this.dgvDSTaiKhoan_SelectionChanged);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Enabled = false;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoaTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(775, 444);
            this.btnXoaTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(247, 36);
            this.btnXoaTaiKhoan.TabIndex = 27;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Enabled = false;
            this.btnSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(775, 334);
            this.btnSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(247, 36);
            this.btnSuaTaiKhoan.TabIndex = 26;
            this.btnSuaTaiKhoan.Text = "Cập nhật thông tin";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(775, 223);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(247, 36);
            this.btnThemTaiKhoan.TabIndex = 25;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản mới";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnSuaTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.dgvDSTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblHoTenGV);
            this.Controls.Add(this.cboLoaiTaiKhoan);
            this.Controls.Add(this.lblChonMonHoc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChuAdmin";
            this.Text = "Trang chủ Quản trị viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiTaiKhoan;
        private System.Windows.Forms.Label lblChonMonHoc;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
    }
}