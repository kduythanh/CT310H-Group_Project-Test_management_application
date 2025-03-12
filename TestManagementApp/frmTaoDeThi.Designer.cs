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
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtTenDeThi = new System.Windows.Forms.TextBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaoDeThi
            // 
            this.lblTaoDeThi.AutoSize = true;
            this.lblTaoDeThi.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoDeThi.Location = new System.Drawing.Point(249, 17);
            this.lblTaoDeThi.Name = "lblTaoDeThi";
            this.lblTaoDeThi.Size = new System.Drawing.Size(229, 35);
            this.lblTaoDeThi.TabIndex = 0;
            this.lblTaoDeThi.Text = "Tạo Đề Thi Mới";
            // 
            // lblMaDeThi
            // 
            this.lblMaDeThi.AutoSize = true;
            this.lblMaDeThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDeThi.Location = new System.Drawing.Point(100, 97);
            this.lblMaDeThi.Name = "lblMaDeThi";
            this.lblMaDeThi.Size = new System.Drawing.Size(105, 24);
            this.lblMaDeThi.TabIndex = 1;
            this.lblMaDeThi.Text = "Mã Đề Thi";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(100, 204);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(94, 24);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn Học";
            // 
            // lblTenDeThi
            // 
            this.lblTenDeThi.AutoSize = true;
            this.lblTenDeThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeThi.Location = new System.Drawing.Point(100, 311);
            this.lblTenDeThi.Name = "lblTenDeThi";
            this.lblTenDeThi.Size = new System.Drawing.Size(113, 24);
            this.lblTenDeThi.TabIndex = 3;
            this.lblTenDeThi.Text = "Tên Đề Thi";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(100, 418);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(168, 24);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "Thời Gian (Phút)";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(100, 525);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 24);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtMaDeThi
            // 
            this.txtMaDeThi.Location = new System.Drawing.Point(297, 97);
            this.txtMaDeThi.Name = "txtMaDeThi";
            this.txtMaDeThi.Size = new System.Drawing.Size(428, 22);
            this.txtMaDeThi.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(297, 531);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(428, 22);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(297, 424);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(428, 22);
            this.txtThoiGian.TabIndex = 9;
            // 
            // txtTenDeThi
            // 
            this.txtTenDeThi.Location = new System.Drawing.Point(297, 317);
            this.txtTenDeThi.Name = "txtTenDeThi";
            this.txtTenDeThi.Size = new System.Drawing.Size(428, 22);
            this.txtTenDeThi.TabIndex = 10;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(297, 210);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(428, 24);
            this.cmbMonHoc.TabIndex = 11;
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.BackColor = System.Drawing.Color.Lime;
            this.btnTaoDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDe.ForeColor = System.Drawing.Color.White;
            this.btnTaoDe.Location = new System.Drawing.Point(421, 606);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(115, 60);
            this.btnTaoDe.TabIndex = 12;
            this.btnTaoDe.Text = "Tạo Đề";
            this.btnTaoDe.UseVisualStyleBackColor = false;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemCauHoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCauHoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemCauHoi.Location = new System.Drawing.Point(574, 606);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(151, 60);
            this.btnThemCauHoi.TabIndex = 13;
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = false;
            // 
            // frmTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 701);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.btnTaoDe);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.txtTenDeThi);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaDeThi);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTenDeThi);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lblMaDeThi);
            this.Controls.Add(this.lblTaoDeThi);
            this.Name = "frmTaoDeThi";
            this.Text = "frmTaoDeThi";
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
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtTenDeThi;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.Button btnThemCauHoi;
    }
}