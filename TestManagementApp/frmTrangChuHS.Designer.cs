﻿namespace TestManagementApp
{
    partial class frmTrangChuHS
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
            this.btnVaoThi = new System.Windows.Forms.Button();
            this.btnXemLichSu = new System.Windows.Forms.Button();
            this.lblChonMonHoc = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.txtHocSinh = new System.Windows.Forms.TextBox();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.cboChonMonHoc = new System.Windows.Forms.ComboBox();
            this.cboChonDeThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGVRaDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianLam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhut = new System.Windows.Forms.Label();
            this.grpVaoThi = new System.Windows.Forms.GroupBox();
            this.grpChucNangKhac = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.grpVaoThi.SuspendLayout();
            this.grpChucNangKhac.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaoThi
            // 
            this.btnVaoThi.BackColor = System.Drawing.Color.Yellow;
            this.btnVaoThi.Enabled = false;
            this.btnVaoThi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaoThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVaoThi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVaoThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVaoThi.Location = new System.Drawing.Point(558, 198);
            this.btnVaoThi.Name = "btnVaoThi";
            this.btnVaoThi.Size = new System.Drawing.Size(89, 29);
            this.btnVaoThi.TabIndex = 15;
            this.btnVaoThi.Text = "Vào thi";
            this.btnVaoThi.UseVisualStyleBackColor = false;
            this.btnVaoThi.Click += new System.EventHandler(this.btnVaoThi_Click);
            // 
            // btnXemLichSu
            // 
            this.btnXemLichSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemLichSu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXemLichSu.Location = new System.Drawing.Point(385, 35);
            this.btnXemLichSu.Name = "btnXemLichSu";
            this.btnXemLichSu.Size = new System.Drawing.Size(215, 29);
            this.btnXemLichSu.TabIndex = 14;
            this.btnXemLichSu.Text = "Xem lịch sử làm bài";
            this.btnXemLichSu.UseVisualStyleBackColor = true;
            this.btnXemLichSu.Click += new System.EventHandler(this.btnXemLichSu_Click);
            // 
            // lblChonMonHoc
            // 
            this.lblChonMonHoc.AutoSize = true;
            this.lblChonMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChonMonHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChonMonHoc.Location = new System.Drawing.Point(12, 34);
            this.lblChonMonHoc.Name = "lblChonMonHoc";
            this.lblChonMonHoc.Size = new System.Drawing.Size(125, 21);
            this.lblChonMonHoc.TabIndex = 12;
            this.lblChonMonHoc.Text = "Chọn môn học:";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDangXuat.Location = new System.Drawing.Point(577, 25);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 29);
            this.btnDangXuat.TabIndex = 11;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // txtHocSinh
            // 
            this.txtHocSinh.Enabled = false;
            this.txtHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHocSinh.Location = new System.Drawing.Point(194, 25);
            this.txtHocSinh.Name = "txtHocSinh";
            this.txtHocSinh.Size = new System.Drawing.Size(343, 29);
            this.txtHocSinh.TabIndex = 10;
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoTenGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoTenGV.Location = new System.Drawing.Point(41, 28);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(80, 21);
            this.lblHoTenGV.TabIndex = 9;
            this.lblHoTenGV.Text = "Học sinh:";
            // 
            // cboChonMonHoc
            // 
            this.cboChonMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonMonHoc.FormattingEnabled = true;
            this.cboChonMonHoc.Location = new System.Drawing.Point(165, 31);
            this.cboChonMonHoc.Name = "cboChonMonHoc";
            this.cboChonMonHoc.Size = new System.Drawing.Size(343, 29);
            this.cboChonMonHoc.TabIndex = 18;
            // 
            // cboChonDeThi
            // 
            this.cboChonDeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonDeThi.FormattingEnabled = true;
            this.cboChonDeThi.Location = new System.Drawing.Point(165, 87);
            this.cboChonDeThi.Name = "cboChonDeThi";
            this.cboChonDeThi.Size = new System.Drawing.Size(343, 29);
            this.cboChonDeThi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn đề thi:";
            // 
            // txtGVRaDe
            // 
            this.txtGVRaDe.Enabled = false;
            this.txtGVRaDe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGVRaDe.Location = new System.Drawing.Point(165, 143);
            this.txtGVRaDe.Name = "txtGVRaDe";
            this.txtGVRaDe.Size = new System.Drawing.Size(343, 29);
            this.txtGVRaDe.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giáo viên ra đề:";
            // 
            // txtThoiGianLam
            // 
            this.txtThoiGianLam.Enabled = false;
            this.txtThoiGianLam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtThoiGianLam.Location = new System.Drawing.Point(165, 199);
            this.txtThoiGianLam.Name = "txtThoiGianLam";
            this.txtThoiGianLam.Size = new System.Drawing.Size(291, 29);
            this.txtThoiGianLam.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thời gian làm bài:";
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.Location = new System.Drawing.Point(462, 202);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(46, 21);
            this.lblPhut.TabIndex = 25;
            this.lblPhut.Text = "phút";
            // 
            // grpVaoThi
            // 
            this.grpVaoThi.Controls.Add(this.lblPhut);
            this.grpVaoThi.Controls.Add(this.txtThoiGianLam);
            this.grpVaoThi.Controls.Add(this.label3);
            this.grpVaoThi.Controls.Add(this.txtGVRaDe);
            this.grpVaoThi.Controls.Add(this.label2);
            this.grpVaoThi.Controls.Add(this.cboChonDeThi);
            this.grpVaoThi.Controls.Add(this.label1);
            this.grpVaoThi.Controls.Add(this.cboChonMonHoc);
            this.grpVaoThi.Controls.Add(this.btnVaoThi);
            this.grpVaoThi.Controls.Add(this.lblChonMonHoc);
            this.grpVaoThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVaoThi.Location = new System.Drawing.Point(29, 69);
            this.grpVaoThi.Name = "grpVaoThi";
            this.grpVaoThi.Size = new System.Drawing.Size(688, 253);
            this.grpVaoThi.TabIndex = 26;
            this.grpVaoThi.TabStop = false;
            this.grpVaoThi.Text = "Vào thi";
            // 
            // grpChucNangKhac
            // 
            this.grpChucNangKhac.Controls.Add(this.btnDoiMatKhau);
            this.grpChucNangKhac.Controls.Add(this.btnXemLichSu);
            this.grpChucNangKhac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNangKhac.Location = new System.Drawing.Point(29, 328);
            this.grpChucNangKhac.Name = "grpChucNangKhac";
            this.grpChucNangKhac.Size = new System.Drawing.Size(688, 85);
            this.grpChucNangKhac.TabIndex = 27;
            this.grpChucNangKhac.TabStop = false;
            this.grpChucNangKhac.Text = "Chức năng khác";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(61, 35);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(215, 29);
            this.btnDoiMatKhau.TabIndex = 15;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmTrangChuHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 433);
            this.ControlBox = false;
            this.Controls.Add(this.grpChucNangKhac);
            this.Controls.Add(this.grpVaoThi);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.txtHocSinh);
            this.Controls.Add(this.lblHoTenGV);
            this.Name = "frmTrangChuHS";
            this.Text = "Trang chủ Học sinh";
            this.grpVaoThi.ResumeLayout(false);
            this.grpVaoThi.PerformLayout();
            this.grpChucNangKhac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVaoThi;
        private System.Windows.Forms.Button btnXemLichSu;
        private System.Windows.Forms.Label lblChonMonHoc;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TextBox txtHocSinh;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.ComboBox cboChonMonHoc;
        private System.Windows.Forms.ComboBox cboChonDeThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGVRaDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiGianLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.GroupBox grpVaoThi;
        private System.Windows.Forms.GroupBox grpChucNangKhac;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}