namespace TestManagementApp
{
    partial class frmTaoCauHoi
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
            this.lblDSCauHoi = new System.Windows.Forms.Label();
            this.lblDanhSachCauHoi = new System.Windows.Forms.Label();
            this.dgvDanhSachCauHoi = new System.Windows.Forms.DataGridView();
            this.colCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTenDeThi = new System.Windows.Forms.Label();
            this.cboTenDeThi = new System.Windows.Forms.ComboBox();
            this.lblDapAnA = new System.Windows.Forms.Label();
            this.lblDapAnB = new System.Windows.Forms.Label();
            this.lblDapAnC = new System.Windows.Forms.Label();
            this.lblDapAnD = new System.Windows.Forms.Label();
            this.txtDapAnA = new System.Windows.Forms.TextBox();
            this.txtDapAnB = new System.Windows.Forms.TextBox();
            this.txtDapAnC = new System.Windows.Forms.TextBox();
            this.txtDapAnD = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.grbNoiDungDe = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picNoiDung = new System.Windows.Forms.PictureBox();
            this.rdoImage = new System.Windows.Forms.RadioButton();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCauHoi)).BeginInit();
            this.grbNoiDungDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDSCauHoi
            // 
            this.lblDSCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDSCauHoi.AutoSize = true;
            this.lblDSCauHoi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSCauHoi.Location = new System.Drawing.Point(533, 9);
            this.lblDSCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSCauHoi.Name = "lblDSCauHoi";
            this.lblDSCauHoi.Size = new System.Drawing.Size(257, 26);
            this.lblDSCauHoi.TabIndex = 0;
            this.lblDSCauHoi.Text = "Tạo Danh Sách Câu Hỏi";
            this.lblDSCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDanhSachCauHoi
            // 
            this.lblDanhSachCauHoi.AutoSize = true;
            this.lblDanhSachCauHoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachCauHoi.Location = new System.Drawing.Point(14, 48);
            this.lblDanhSachCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhSachCauHoi.Name = "lblDanhSachCauHoi";
            this.lblDanhSachCauHoi.Size = new System.Drawing.Size(158, 19);
            this.lblDanhSachCauHoi.TabIndex = 1;
            this.lblDanhSachCauHoi.Text = "Danh Sách Câu Hỏi";
            // 
            // dgvDanhSachCauHoi
            // 
            this.dgvDanhSachCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCauHoi,
            this.colDapAnA,
            this.colDapAnB,
            this.colDapAnC,
            this.colDapAnD,
            this.colKQ});
            this.dgvDanhSachCauHoi.Location = new System.Drawing.Point(18, 82);
            this.dgvDanhSachCauHoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSachCauHoi.Name = "dgvDanhSachCauHoi";
            this.dgvDanhSachCauHoi.RowHeadersWidth = 51;
            this.dgvDanhSachCauHoi.RowTemplate.Height = 24;
            this.dgvDanhSachCauHoi.Size = new System.Drawing.Size(787, 583);
            this.dgvDanhSachCauHoi.TabIndex = 2;
            // 
            // colCauHoi
            // 
            this.colCauHoi.HeaderText = "Câu Hỏi";
            this.colCauHoi.MinimumWidth = 6;
            this.colCauHoi.Name = "colCauHoi";
            this.colCauHoi.Width = 125;
            // 
            // colDapAnA
            // 
            this.colDapAnA.HeaderText = "Đáp Án A";
            this.colDapAnA.MinimumWidth = 6;
            this.colDapAnA.Name = "colDapAnA";
            this.colDapAnA.Width = 125;
            // 
            // colDapAnB
            // 
            this.colDapAnB.HeaderText = "Đáp Án B";
            this.colDapAnB.MinimumWidth = 6;
            this.colDapAnB.Name = "colDapAnB";
            this.colDapAnB.Width = 125;
            // 
            // colDapAnC
            // 
            this.colDapAnC.HeaderText = "Đáp Án C";
            this.colDapAnC.MinimumWidth = 6;
            this.colDapAnC.Name = "colDapAnC";
            this.colDapAnC.Width = 125;
            // 
            // colDapAnD
            // 
            this.colDapAnD.HeaderText = "Đáp Án D";
            this.colDapAnD.MinimumWidth = 6;
            this.colDapAnD.Name = "colDapAnD";
            this.colDapAnD.Width = 125;
            // 
            // colKQ
            // 
            this.colKQ.HeaderText = "Kết Quả";
            this.colKQ.MinimumWidth = 6;
            this.colKQ.Name = "colKQ";
            this.colKQ.Width = 125;
            // 
            // lblTenDeThi
            // 
            this.lblTenDeThi.AutoSize = true;
            this.lblTenDeThi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeThi.Location = new System.Drawing.Point(845, 82);
            this.lblTenDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDeThi.Name = "lblTenDeThi";
            this.lblTenDeThi.Size = new System.Drawing.Size(76, 16);
            this.lblTenDeThi.TabIndex = 3;
            this.lblTenDeThi.Text = "Tên Đề Thi";
            // 
            // cboTenDeThi
            // 
            this.cboTenDeThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenDeThi.FormattingEnabled = true;
            this.cboTenDeThi.Location = new System.Drawing.Point(944, 77);
            this.cboTenDeThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenDeThi.Name = "cboTenDeThi";
            this.cboTenDeThi.Size = new System.Drawing.Size(248, 26);
            this.cboTenDeThi.TabIndex = 6;
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.AutoSize = true;
            this.lblDapAnA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnA.Location = new System.Drawing.Point(848, 323);
            this.lblDapAnA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(66, 16);
            this.lblDapAnA.TabIndex = 8;
            this.lblDapAnA.Text = "Đáp Án A";
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.AutoSize = true;
            this.lblDapAnB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnB.Location = new System.Drawing.Point(849, 395);
            this.lblDapAnB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(66, 16);
            this.lblDapAnB.TabIndex = 9;
            this.lblDapAnB.Text = "Đáp Án B";
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.AutoSize = true;
            this.lblDapAnC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnC.Location = new System.Drawing.Point(850, 472);
            this.lblDapAnC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(66, 16);
            this.lblDapAnC.TabIndex = 10;
            this.lblDapAnC.Text = "Đáp Án C";
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.AutoSize = true;
            this.lblDapAnD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnD.Location = new System.Drawing.Point(850, 555);
            this.lblDapAnD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(66, 16);
            this.lblDapAnD.TabIndex = 11;
            this.lblDapAnD.Text = "Đáp Án D";
            // 
            // txtDapAnA
            // 
            this.txtDapAnA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnA.Location = new System.Drawing.Point(848, 345);
            this.txtDapAnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDapAnA.Name = "txtDapAnA";
            this.txtDapAnA.Size = new System.Drawing.Size(346, 26);
            this.txtDapAnA.TabIndex = 12;
            // 
            // txtDapAnB
            // 
            this.txtDapAnB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnB.Location = new System.Drawing.Point(850, 417);
            this.txtDapAnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDapAnB.Name = "txtDapAnB";
            this.txtDapAnB.Size = new System.Drawing.Size(344, 26);
            this.txtDapAnB.TabIndex = 13;
            // 
            // txtDapAnC
            // 
            this.txtDapAnC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnC.Location = new System.Drawing.Point(848, 494);
            this.txtDapAnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDapAnC.Name = "txtDapAnC";
            this.txtDapAnC.Size = new System.Drawing.Size(346, 26);
            this.txtDapAnC.TabIndex = 14;
            // 
            // txtDapAnD
            // 
            this.txtDapAnD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnD.Location = new System.Drawing.Point(849, 577);
            this.txtDapAnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDapAnD.Name = "txtDapAnD";
            this.txtDapAnD.Size = new System.Drawing.Size(345, 26);
            this.txtDapAnD.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(1214, 343);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 47);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(1214, 423);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 47);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(1214, 503);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 47);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHoanThanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.Transparent;
            this.btnHoanThanh.Location = new System.Drawing.Point(1214, 591);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(82, 47);
            this.btnHoanThanh.TabIndex = 20;
            this.btnHoanThanh.Text = "Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(850, 642);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(58, 16);
            this.lblKQ.TabIndex = 21;
            this.lblKQ.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(929, 639);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(263, 26);
            this.txtKQ.TabIndex = 22;
            // 
            // grbNoiDungDe
            // 
            this.grbNoiDungDe.Controls.Add(this.btnChonAnh);
            this.grbNoiDungDe.Controls.Add(this.picNoiDung);
            this.grbNoiDungDe.Controls.Add(this.rdoImage);
            this.grbNoiDungDe.Controls.Add(this.rdoText);
            this.grbNoiDungDe.Controls.Add(this.rtbNoiDung);
            this.grbNoiDungDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNoiDungDe.Location = new System.Drawing.Point(848, 124);
            this.grbNoiDungDe.Name = "grbNoiDungDe";
            this.grbNoiDungDe.Size = new System.Drawing.Size(448, 160);
            this.grbNoiDungDe.TabIndex = 23;
            this.grbNoiDungDe.TabStop = false;
            this.grbNoiDungDe.Text = "Nội Dung Đề Thi";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Image = global::TestManagementApp.Properties.Resources.iconImage;
            this.btnChonAnh.Location = new System.Drawing.Point(397, 116);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(34, 28);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picNoiDung
            // 
            this.picNoiDung.Location = new System.Drawing.Point(25, 56);
            this.picNoiDung.Name = "picNoiDung";
            this.picNoiDung.Size = new System.Drawing.Size(366, 88);
            this.picNoiDung.TabIndex = 3;
            this.picNoiDung.TabStop = false;
            // 
            // rdoImage
            // 
            this.rdoImage.AutoSize = true;
            this.rdoImage.Location = new System.Drawing.Point(166, 30);
            this.rdoImage.Name = "rdoImage";
            this.rdoImage.Size = new System.Drawing.Size(87, 20);
            this.rdoImage.TabIndex = 1;
            this.rdoImage.TabStop = true;
            this.rdoImage.Text = "Nhập Ảnh";
            this.rdoImage.UseVisualStyleBackColor = true;
            this.rdoImage.CheckedChanged += new System.EventHandler(this.rdoImage_CheckedChanged);
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Location = new System.Drawing.Point(25, 30);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(116, 20);
            this.rdoText.TabIndex = 0;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Nhập Văn Bản";
            this.rdoText.UseVisualStyleBackColor = true;
            this.rdoText.CheckedChanged += new System.EventHandler(this.rdoText_CheckedChanged);
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(25, 56);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(366, 88);
            this.rtbNoiDung.TabIndex = 2;
            this.rtbNoiDung.Text = "";
            // 
            // frmTaoCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 687);
            this.Controls.Add(this.grbNoiDungDe);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDapAnD);
            this.Controls.Add(this.txtDapAnC);
            this.Controls.Add(this.txtDapAnB);
            this.Controls.Add(this.txtDapAnA);
            this.Controls.Add(this.lblDapAnD);
            this.Controls.Add(this.lblDapAnC);
            this.Controls.Add(this.lblDapAnB);
            this.Controls.Add(this.lblDapAnA);
            this.Controls.Add(this.cboTenDeThi);
            this.Controls.Add(this.lblTenDeThi);
            this.Controls.Add(this.dgvDanhSachCauHoi);
            this.Controls.Add(this.lblDanhSachCauHoi);
            this.Controls.Add(this.lblDSCauHoi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTaoCauHoi";
            this.Text = "frmTaoCauHoi";
            this.Load += new System.EventHandler(this.frmTaoCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCauHoi)).EndInit();
            this.grbNoiDungDe.ResumeLayout(false);
            this.grbNoiDungDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDSCauHoi;
        private System.Windows.Forms.Label lblDanhSachCauHoi;
        private System.Windows.Forms.DataGridView dgvDanhSachCauHoi;
        private System.Windows.Forms.Label lblTenDeThi;
        private System.Windows.Forms.ComboBox cboTenDeThi;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.Label lblDapAnD;
        private System.Windows.Forms.TextBox txtDapAnA;
        private System.Windows.Forms.TextBox txtDapAnB;
        private System.Windows.Forms.TextBox txtDapAnC;
        private System.Windows.Forms.TextBox txtDapAnD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox grbNoiDungDe;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.RadioButton rdoImage;
        private System.Windows.Forms.PictureBox picNoiDung;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKQ;
    }
}