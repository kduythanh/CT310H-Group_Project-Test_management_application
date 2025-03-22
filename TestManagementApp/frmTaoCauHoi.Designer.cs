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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoCauHoi));
            this.lblDSCauHoi = new System.Windows.Forms.Label();
            this.lblDanhSachCauHoi = new System.Windows.Forms.Label();
            this.dgvDanhSachCauHoi = new System.Windows.Forms.DataGridView();
            this.colCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grbNoiDungDe = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picNoiDung = new System.Windows.Forms.PictureBox();
            this.rdoImage = new System.Windows.Forms.RadioButton();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.cboKQ = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
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
            this.lblDSCauHoi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSCauHoi.Location = new System.Drawing.Point(533, 9);
            this.lblDSCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSCauHoi.Name = "lblDSCauHoi";
            this.lblDSCauHoi.Size = new System.Drawing.Size(301, 30);
            this.lblDSCauHoi.TabIndex = 0;
            this.lblDSCauHoi.Text = "Cập nhật Danh sách Câu hỏi";
            this.lblDSCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDanhSachCauHoi
            // 
            this.lblDanhSachCauHoi.AutoSize = true;
            this.lblDanhSachCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachCauHoi.Location = new System.Drawing.Point(14, 48);
            this.lblDanhSachCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhSachCauHoi.Name = "lblDanhSachCauHoi";
            this.lblDanhSachCauHoi.Size = new System.Drawing.Size(151, 21);
            this.lblDanhSachCauHoi.TabIndex = 1;
            this.lblDanhSachCauHoi.Text = "Danh sách Câu hỏi";
            // 
            // dgvDanhSachCauHoi
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCauHoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCauHoi,
            this.colMaCauHoi,
            this.colDapAnA,
            this.colDapAnB,
            this.colDapAnC,
            this.colDapAnD,
            this.colKQ});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachCauHoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCauHoi.Location = new System.Drawing.Point(18, 82);
            this.dgvDanhSachCauHoi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachCauHoi.Name = "dgvDanhSachCauHoi";
            this.dgvDanhSachCauHoi.RowHeadersWidth = 51;
            this.dgvDanhSachCauHoi.RowTemplate.Height = 24;
            this.dgvDanhSachCauHoi.Size = new System.Drawing.Size(787, 583);
            this.dgvDanhSachCauHoi.TabIndex = 2;
            this.dgvDanhSachCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCauHoi_CellContentClick);
            this.dgvDanhSachCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCauHoi_CellContentClick);
            // 
            // colCauHoi
            // 
            this.colCauHoi.DataPropertyName = "NOI_DUNG";
            this.colCauHoi.HeaderText = "Câu hỏi";
            this.colCauHoi.MinimumWidth = 6;
            this.colCauHoi.Name = "colCauHoi";
            this.colCauHoi.Width = 125;
            // 
            // colMaCauHoi
            // 
            this.colMaCauHoi.DataPropertyName = "MA_CAU_HOI";
            this.colMaCauHoi.HeaderText = "Mã Câu hỏi";
            this.colMaCauHoi.MinimumWidth = 6;
            this.colMaCauHoi.Name = "colMaCauHoi";
            this.colMaCauHoi.ReadOnly = true;
            this.colMaCauHoi.Visible = false;
            this.colMaCauHoi.Width = 125;
            // 
            // colDapAnA
            // 
            this.colDapAnA.DataPropertyName = "PHUONG_AN_A";
            this.colDapAnA.HeaderText = "Đáp án A";
            this.colDapAnA.MinimumWidth = 6;
            this.colDapAnA.Name = "colDapAnA";
            this.colDapAnA.Width = 125;
            // 
            // colDapAnB
            // 
            this.colDapAnB.DataPropertyName = "PHUONG_AN_B";
            this.colDapAnB.HeaderText = "Đáp án B";
            this.colDapAnB.MinimumWidth = 6;
            this.colDapAnB.Name = "colDapAnB";
            this.colDapAnB.Width = 125;
            // 
            // colDapAnC
            // 
            this.colDapAnC.DataPropertyName = "PHUONG_AN_C";
            this.colDapAnC.HeaderText = "Đáp án C";
            this.colDapAnC.MinimumWidth = 6;
            this.colDapAnC.Name = "colDapAnC";
            this.colDapAnC.Width = 125;
            // 
            // colDapAnD
            // 
            this.colDapAnD.DataPropertyName = "PHUONG_AN_D";
            this.colDapAnD.HeaderText = "Đáp án D";
            this.colDapAnD.MinimumWidth = 6;
            this.colDapAnD.Name = "colDapAnD";
            this.colDapAnD.Width = 125;
            // 
            // colKQ
            // 
            this.colKQ.DataPropertyName = "DAP_AN";
            this.colKQ.HeaderText = "Đáp án đúng";
            this.colKQ.MinimumWidth = 6;
            this.colKQ.Name = "colKQ";
            this.colKQ.Width = 125;
            // 
            // lblTenDeThi
            // 
            this.lblTenDeThi.AutoSize = true;
            this.lblTenDeThi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeThi.Location = new System.Drawing.Point(845, 82);
            this.lblTenDeThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDeThi.Name = "lblTenDeThi";
            this.lblTenDeThi.Size = new System.Drawing.Size(75, 19);
            this.lblTenDeThi.TabIndex = 3;
            this.lblTenDeThi.Text = "Tên Đề thi";
            // 
            // cboTenDeThi
            // 
            this.cboTenDeThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenDeThi.FormattingEnabled = true;
            this.cboTenDeThi.Location = new System.Drawing.Point(944, 77);
            this.cboTenDeThi.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenDeThi.Name = "cboTenDeThi";
            this.cboTenDeThi.Size = new System.Drawing.Size(248, 29);
            this.cboTenDeThi.TabIndex = 6;
            this.cboTenDeThi.SelectedIndexChanged += new System.EventHandler(this.cboTenDeThi_SelectedIndexChanged);
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.AutoSize = true;
            this.lblDapAnA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnA.Location = new System.Drawing.Point(848, 323);
            this.lblDapAnA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(70, 19);
            this.lblDapAnA.TabIndex = 8;
            this.lblDapAnA.Text = "Đáp án A";
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.AutoSize = true;
            this.lblDapAnB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnB.Location = new System.Drawing.Point(849, 395);
            this.lblDapAnB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(69, 19);
            this.lblDapAnB.TabIndex = 9;
            this.lblDapAnB.Text = "Đáp án B";
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.AutoSize = true;
            this.lblDapAnC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnC.Location = new System.Drawing.Point(850, 472);
            this.lblDapAnC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(69, 19);
            this.lblDapAnC.TabIndex = 10;
            this.lblDapAnC.Text = "Đáp án C";
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.AutoSize = true;
            this.lblDapAnD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnD.Location = new System.Drawing.Point(850, 555);
            this.lblDapAnD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(70, 19);
            this.lblDapAnD.TabIndex = 11;
            this.lblDapAnD.Text = "Đáp án D";
            // 
            // txtDapAnA
            // 
            this.txtDapAnA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnA.Location = new System.Drawing.Point(848, 345);
            this.txtDapAnA.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAnA.Name = "txtDapAnA";
            this.txtDapAnA.Size = new System.Drawing.Size(346, 29);
            this.txtDapAnA.TabIndex = 12;
            // 
            // txtDapAnB
            // 
            this.txtDapAnB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnB.Location = new System.Drawing.Point(850, 417);
            this.txtDapAnB.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAnB.Name = "txtDapAnB";
            this.txtDapAnB.Size = new System.Drawing.Size(344, 29);
            this.txtDapAnB.TabIndex = 13;
            // 
            // txtDapAnC
            // 
            this.txtDapAnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnC.Location = new System.Drawing.Point(848, 494);
            this.txtDapAnC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAnC.Name = "txtDapAnC";
            this.txtDapAnC.Size = new System.Drawing.Size(346, 29);
            this.txtDapAnC.TabIndex = 14;
            // 
            // txtDapAnD
            // 
            this.txtDapAnD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnD.Location = new System.Drawing.Point(849, 577);
            this.txtDapAnD.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAnD.Name = "txtDapAnD";
            this.txtDapAnD.Size = new System.Drawing.Size(345, 29);
            this.txtDapAnD.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(1206, 323);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 47);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(1206, 404);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 47);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(1206, 483);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 47);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.Transparent;
            this.btnHoanThanh.Location = new System.Drawing.Point(1206, 571);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(122, 47);
            this.btnHoanThanh.TabIndex = 20;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(850, 642);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(94, 19);
            this.lblKQ.TabIndex = 21;
            this.lblKQ.Text = "Đáp án đúng";
            // 
            // grbNoiDungDe
            // 
            this.grbNoiDungDe.Controls.Add(this.btnChonAnh);
            this.grbNoiDungDe.Controls.Add(this.picNoiDung);
            this.grbNoiDungDe.Controls.Add(this.rdoImage);
            this.grbNoiDungDe.Controls.Add(this.rdoText);
            this.grbNoiDungDe.Controls.Add(this.rtbNoiDung);
            this.grbNoiDungDe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNoiDungDe.Location = new System.Drawing.Point(848, 124);
            this.grbNoiDungDe.Name = "grbNoiDungDe";
            this.grbNoiDungDe.Size = new System.Drawing.Size(448, 160);
            this.grbNoiDungDe.TabIndex = 23;
            this.grbNoiDungDe.TabStop = false;
            this.grbNoiDungDe.Text = "Nội dung Câu hỏi";
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
            this.picNoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNoiDung.TabIndex = 3;
            this.picNoiDung.TabStop = false;
            // 
            // rdoImage
            // 
            this.rdoImage.AutoSize = true;
            this.rdoImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoImage.Location = new System.Drawing.Point(166, 30);
            this.rdoImage.Name = "rdoImage";
            this.rdoImage.Size = new System.Drawing.Size(93, 23);
            this.rdoImage.TabIndex = 1;
            this.rdoImage.TabStop = true;
            this.rdoImage.Text = "Nhập Ảnh";
            this.rdoImage.UseVisualStyleBackColor = true;
            this.rdoImage.CheckedChanged += new System.EventHandler(this.rdoImage_CheckedChanged);
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoText.Location = new System.Drawing.Point(25, 30);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(120, 23);
            this.rdoText.TabIndex = 0;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Nhập Văn bản";
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
            // cboKQ
            // 
            this.cboKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKQ.FormattingEnabled = true;
            this.cboKQ.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboKQ.Location = new System.Drawing.Point(944, 635);
            this.cboKQ.Margin = new System.Windows.Forms.Padding(2);
            this.cboKQ.Name = "cboKQ";
            this.cboKQ.Size = new System.Drawing.Size(92, 29);
            this.cboKQ.TabIndex = 24;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(1206, 74);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(36, 36);
            this.btnClearAll.TabIndex = 25;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmTaoCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1336, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.cboKQ);
            this.Controls.Add(this.grbNoiDungDe);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTaoCauHoi";
            this.Text = "Cập nhật câu hỏi";
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
        private System.Windows.Forms.GroupBox grbNoiDungDe;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.RadioButton rdoImage;
        private System.Windows.Forms.PictureBox picNoiDung;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cboKQ;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKQ;
    }
}