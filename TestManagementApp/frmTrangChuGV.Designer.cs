namespace TestManagementApp
{
    partial class frmTrangChuGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChuGV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblDSDeThi = new System.Windows.Forms.Label();
            this.dgvDeThi = new System.Windows.Forms.DataGridView();
            this.btnThemDeThi = new System.Windows.Forms.Button();
            this.btnSuaDeThi = new System.Windows.Forms.Button();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnXoaDeThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.grpChucNangKhac = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpChucNangKhac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTenGV
            // 
            resources.ApplyResources(this.lblHoTenGV, "lblHoTenGV");
            this.lblHoTenGV.Name = "lblHoTenGV";
            // 
            // txtGiaoVien
            // 
            resources.ApplyResources(this.txtGiaoVien, "txtGiaoVien");
            this.txtGiaoVien.Name = "txtGiaoVien";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnDangXuat, "btnDangXuat");
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblDSDeThi
            // 
            resources.ApplyResources(this.lblDSDeThi, "lblDSDeThi");
            this.lblDSDeThi.Name = "lblDSDeThi";
            // 
            // dgvDeThi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDeThi, "dgvDeThi");
            this.dgvDeThi.Name = "dgvDeThi";
            // 
            // btnThemDeThi
            // 
            resources.ApplyResources(this.btnThemDeThi, "btnThemDeThi");
            this.btnThemDeThi.Name = "btnThemDeThi";
            this.btnThemDeThi.UseVisualStyleBackColor = true;
            // 
            // btnSuaDeThi
            // 
            resources.ApplyResources(this.btnSuaDeThi, "btnSuaDeThi");
            this.btnSuaDeThi.Name = "btnSuaDeThi";
            this.btnSuaDeThi.UseVisualStyleBackColor = true;
            // 
            // btnSuaCauHoi
            // 
            resources.ApplyResources(this.btnSuaCauHoi, "btnSuaCauHoi");
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaDeThi
            // 
            resources.ApplyResources(this.btnXoaDeThi, "btnXoaDeThi");
            this.btnXoaDeThi.Name = "btnXoaDeThi";
            this.btnXoaDeThi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemKetQua);
            this.groupBox1.Controls.Add(this.btnXoaDeThi);
            this.groupBox1.Controls.Add(this.btnSuaCauHoi);
            this.groupBox1.Controls.Add(this.btnSuaDeThi);
            this.groupBox1.Controls.Add(this.btnThemDeThi);
            this.groupBox1.Controls.Add(this.dgvDeThi);
            this.groupBox1.Controls.Add(this.lblDSDeThi);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnXemKetQua
            // 
            resources.ApplyResources(this.btnXemKetQua, "btnXemKetQua");
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            // 
            // grpChucNangKhac
            // 
            this.grpChucNangKhac.Controls.Add(this.btnDoiMatKhau);
            resources.ApplyResources(this.grpChucNangKhac, "grpChucNangKhac");
            this.grpChucNangKhac.Name = "grpChucNangKhac";
            this.grpChucNangKhac.TabStop = false;
            // 
            // btnDoiMatKhau
            // 
            resources.ApplyResources(this.btnDoiMatKhau, "btnDoiMatKhau");
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmTrangChuGV
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.grpChucNangKhac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.txtGiaoVien);
            this.Controls.Add(this.lblHoTenGV);
            this.Name = "frmTrangChuGV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpChucNangKhac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.TextBox txtGiaoVien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblDSDeThi;
        private System.Windows.Forms.DataGridView dgvDeThi;
        private System.Windows.Forms.Button btnThemDeThi;
        private System.Windows.Forms.Button btnSuaDeThi;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnXoaDeThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.GroupBox grpChucNangKhac;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}