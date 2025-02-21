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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChonMonHoc = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnSuaDeThi = new System.Windows.Forms.Button();
            this.btnThemDeThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giáo viên",
            "Học sinh"});
            this.comboBox1.Location = new System.Drawing.Point(205, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 29);
            this.comboBox1.TabIndex = 20;
            // 
            // lblChonMonHoc
            // 
            this.lblChonMonHoc.AutoSize = true;
            this.lblChonMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChonMonHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChonMonHoc.Location = new System.Drawing.Point(36, 77);
            this.lblChonMonHoc.Name = "lblChonMonHoc";
            this.lblChonMonHoc.Size = new System.Drawing.Size(163, 21);
            this.lblChonMonHoc.TabIndex = 19;
            this.lblChonMonHoc.Text = "Chọn loại tài khoản:";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoTenGV.Location = new System.Drawing.Point(35, 21);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(519, 30);
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
            this.btnDangXuat.Location = new System.Drawing.Point(619, 21);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 29);
            this.btnDangXuat.TabIndex = 22;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách tài khoản:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 243);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Enabled = false;
            this.btnSuaCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaCauHoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSuaCauHoi.Location = new System.Drawing.Point(581, 361);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(185, 29);
            this.btnSuaCauHoi.TabIndex = 27;
            this.btnSuaCauHoi.Text = "Xóa tài khoản";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnSuaDeThi
            // 
            this.btnSuaDeThi.Enabled = false;
            this.btnSuaDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaDeThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSuaDeThi.Location = new System.Drawing.Point(581, 271);
            this.btnSuaDeThi.Name = "btnSuaDeThi";
            this.btnSuaDeThi.Size = new System.Drawing.Size(185, 29);
            this.btnSuaDeThi.TabIndex = 26;
            this.btnSuaDeThi.Text = "Cập nhật thông tin";
            this.btnSuaDeThi.UseVisualStyleBackColor = true;
            // 
            // btnThemDeThi
            // 
            this.btnThemDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemDeThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemDeThi.Location = new System.Drawing.Point(581, 181);
            this.btnThemDeThi.Name = "btnThemDeThi";
            this.btnThemDeThi.Size = new System.Drawing.Size(185, 29);
            this.btnThemDeThi.TabIndex = 25;
            this.btnThemDeThi.Text = "Thêm tài khoản mới";
            this.btnThemDeThi.UseVisualStyleBackColor = true;
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuaCauHoi);
            this.Controls.Add(this.btnSuaDeThi);
            this.Controls.Add(this.btnThemDeThi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblHoTenGV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChonMonHoc);
            this.Name = "frmTrangChuAdmin";
            this.Text = "Trang chủ Quản trị viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChonMonHoc;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnSuaDeThi;
        private System.Windows.Forms.Button btnThemDeThi;
    }
}