namespace TestManagementApp
{
    partial class frmTaoDeThi
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
            this.lblTaoDeThi = new System.Windows.Forms.Label();
            this.lblMaDeThi = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblTenDeThi = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMaDeThi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDeThi = new System.Windows.Forms.TextBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nmrThoiGian = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaoDeThi
            // 
            this.lblTaoDeThi.AutoSize = true;
            this.lblTaoDeThi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoDeThi.Location = new System.Drawing.Point(187, 14);
            this.lblTaoDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaoDeThi.Name = "lblTaoDeThi";
            this.lblTaoDeThi.Size = new System.Drawing.Size(182, 32);
            this.lblTaoDeThi.TabIndex = 0;
            this.lblTaoDeThi.Text = "Tạo Đề thi mới";
            // 
            // lblMaDeThi
            // 
            this.lblMaDeThi.AutoSize = true;
            this.lblMaDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDeThi.Location = new System.Drawing.Point(40, 80);
            this.lblMaDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDeThi.Name = "lblMaDeThi";
            this.lblMaDeThi.Size = new System.Drawing.Size(84, 21);
            this.lblMaDeThi.TabIndex = 1;
            this.lblMaDeThi.Text = "Mã Đề thi";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(40, 167);
            this.lblMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(77, 21);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học";
            // 
            // lblTenDeThi
            // 
            this.lblTenDeThi.AutoSize = true;
            this.lblTenDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeThi.Location = new System.Drawing.Point(40, 254);
            this.lblTenDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDeThi.Name = "lblTenDeThi";
            this.lblTenDeThi.Size = new System.Drawing.Size(87, 21);
            this.lblTenDeThi.TabIndex = 3;
            this.lblTenDeThi.Text = "Tên Đề thi";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(40, 341);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(134, 21);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "Thời gian (phút)";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(40, 428);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(82, 21);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMaDeThi
            // 
            this.txtMaDeThi.Enabled = false;
            this.txtMaDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDeThi.Location = new System.Drawing.Point(202, 77);
            this.txtMaDeThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDeThi.Name = "txtMaDeThi";
            this.txtMaDeThi.Size = new System.Drawing.Size(322, 29);
            this.txtMaDeThi.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(202, 425);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(322, 29);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDeThi
            // 
            this.txtTenDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDeThi.Location = new System.Drawing.Point(202, 251);
            this.txtTenDeThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDeThi.Name = "txtTenDeThi";
            this.txtTenDeThi.Size = new System.Drawing.Size(322, 29);
            this.txtTenDeThi.TabIndex = 10;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(202, 164);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(322, 29);
            this.cboMonHoc.TabIndex = 11;
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.BackColor = System.Drawing.Color.Lime;
            this.btnTaoDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDe.ForeColor = System.Drawing.Color.White;
            this.btnTaoDe.Location = new System.Drawing.Point(263, 516);
            this.btnTaoDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(128, 49);
            this.btnTaoDe.TabIndex = 12;
            this.btnTaoDe.Text = "Tạo Đề";
            this.btnTaoDe.UseVisualStyleBackColor = false;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCauHoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemCauHoi.Location = new System.Drawing.Point(395, 516);
            this.btnThemCauHoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(128, 49);
            this.btnThemCauHoi.TabIndex = 13;
            this.btnThemCauHoi.Text = "Thêm Câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = false;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(128, 516);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 49);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // nmrThoiGian
            // 
            this.nmrThoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrThoiGian.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrThoiGian.Location = new System.Drawing.Point(202, 339);
            this.nmrThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.nmrThoiGian.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmrThoiGian.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrThoiGian.Name = "nmrThoiGian";
            this.nmrThoiGian.Size = new System.Drawing.Size(322, 29);
            this.nmrThoiGian.TabIndex = 15;
            this.nmrThoiGian.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // frmTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 604);
            this.ControlBox = false;
            this.Controls.Add(this.nmrThoiGian);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.btnTaoDe);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.txtTenDeThi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaDeThi);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTenDeThi);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lblMaDeThi);
            this.Controls.Add(this.lblTaoDeThi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTaoDeThi";
            this.Text = "Tạo Đề thi";
            this.Load += new System.EventHandler(this.frmTaoDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaoDeThi;
        private System.Windows.Forms.Label lblMaDeThi;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblTenDeThi;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMaDeThi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDeThi;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.NumericUpDown nmrThoiGian;
    }
}