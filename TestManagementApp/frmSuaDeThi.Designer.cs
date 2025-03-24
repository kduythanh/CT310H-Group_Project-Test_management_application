namespace TestManagementApp
{
    partial class frmSuaDeThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblTenDeThi = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.txtTenDeThi = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nmrThoiLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin đề thi";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(38, 67);
            this.lblMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(77, 21);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn học";
            // 
            // lblTenDeThi
            // 
            this.lblTenDeThi.AutoSize = true;
            this.lblTenDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeThi.Location = new System.Drawing.Point(38, 160);
            this.lblTenDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDeThi.Name = "lblTenDeThi";
            this.lblTenDeThi.Size = new System.Drawing.Size(87, 21);
            this.lblTenDeThi.TabIndex = 2;
            this.lblTenDeThi.Text = "Tên Đề thi";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiLuong.Location = new System.Drawing.Point(38, 253);
            this.lblThoiLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(146, 21);
            this.lblThoiLuong.TabIndex = 3;
            this.lblThoiLuong.Text = "Thời lượng (phút)";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(38, 346);
            this.lblMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(86, 21);
            this.lblMK.TabIndex = 4;
            this.lblMK.Text = "Mật khẩu ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(38, 439);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(87, 21);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Enabled = false;
            this.txtMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHoc.Location = new System.Drawing.Point(226, 64);
            this.txtMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(282, 29);
            this.txtMonHoc.TabIndex = 6;
            // 
            // txtTenDeThi
            // 
            this.txtTenDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDeThi.Location = new System.Drawing.Point(226, 157);
            this.txtTenDeThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDeThi.Name = "txtTenDeThi";
            this.txtTenDeThi.Size = new System.Drawing.Size(282, 29);
            this.txtTenDeThi.TabIndex = 7;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(226, 343);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(282, 29);
            this.txtMK.TabIndex = 9;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(226, 436);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(282, 29);
            this.cboTrangThai.TabIndex = 10;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Gold;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.Location = new System.Drawing.Point(405, 502);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 45);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(263, 500);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 49);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // nmrThoiLuong
            // 
            this.nmrThoiLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrThoiLuong.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrThoiLuong.Location = new System.Drawing.Point(226, 251);
            this.nmrThoiLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nmrThoiLuong.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmrThoiLuong.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrThoiLuong.Name = "nmrThoiLuong";
            this.nmrThoiLuong.Size = new System.Drawing.Size(282, 29);
            this.nmrThoiLuong.TabIndex = 16;
            this.nmrThoiLuong.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // frmSuaDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 572);
            this.ControlBox = false;
            this.Controls.Add(this.nmrThoiLuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDeThi);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblThoiLuong);
            this.Controls.Add(this.lblTenDeThi);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSuaDeThi";
            this.Text = "Sửa thông tin đề thi";
            this.Load += new System.EventHandler(this.frmSuaDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblTenDeThi;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox txtTenDeThi;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.NumericUpDown nmrThoiLuong;
    }
}