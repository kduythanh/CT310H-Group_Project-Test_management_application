namespace TestManagementApp
{
    partial class frmLamBaiThi
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
            this.dgvDapAn = new System.Windows.Forms.DataGridView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_CauHoi = new System.Windows.Forms.GroupBox();
            this.picNoiDung = new System.Windows.Forms.PictureBox();
            this.radbtnD = new System.Windows.Forms.RadioButton();
            this.radbtnB = new System.Windows.Forms.RadioButton();
            this.radbtnC = new System.Windows.Forms.RadioButton();
            this.radbtnA = new System.Windows.Forms.RadioButton();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lbl_TenBaiThi = new System.Windows.Forms.Label();
            this.lblSoCauHoi = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauTraLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).BeginInit();
            this.grpbox_CauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDapAn
            // 
            this.dgvDapAn.AllowUserToAddRows = false;
            this.dgvDapAn.AllowUserToDeleteRows = false;
            this.dgvDapAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDapAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDapAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDapAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CauTraLoi,
            this.DapAn,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDapAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDapAn.Location = new System.Drawing.Point(214, 464);
            this.dgvDapAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDapAn.MultiSelect = false;
            this.dgvDapAn.Name = "dgvDapAn";
            this.dgvDapAn.ReadOnly = true;
            this.dgvDapAn.RowHeadersWidth = 51;
            this.dgvDapAn.RowTemplate.Height = 24;
            this.dgvDapAn.Size = new System.Drawing.Size(416, 142);
            this.dgvDapAn.TabIndex = 14;
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblKetQua.Location = new System.Drawing.Point(643, 464);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(275, 84);
            this.lblKetQua.TabIndex = 16;
            this.lblKetQua.Text = "Điểm của bài thi : ? điểm\r\nSố câu đúng của bài thi : ?/n câu";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.Yellow;
            this.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNopBai.Location = new System.Drawing.Point(782, 568);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(261, 38);
            this.btnNopBai.TabIndex = 15;
            this.btnNopBai.Text = "Nộp bài và Kết thúc";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.BackColor = System.Drawing.Color.Blue;
            this.btnCauSau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauSau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauSau.ForeColor = System.Drawing.Color.White;
            this.btnCauSau.Location = new System.Drawing.Point(930, 464);
            this.btnCauSau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(110, 40);
            this.btnCauSau.TabIndex = 13;
            this.btnCauSau.Text = "Câu sau";
            this.btnCauSau.UseVisualStyleBackColor = false;
            this.btnCauSau.Click += new System.EventHandler(this.BtnCauSau_Click);
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.Color.Blue;
            this.btnCauTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauTruoc.ForeColor = System.Drawing.Color.White;
            this.btnCauTruoc.Location = new System.Drawing.Point(40, 464);
            this.btnCauTruoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(110, 40);
            this.btnCauTruoc.TabIndex = 12;
            this.btnCauTruoc.Text = "Câu trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            this.btnCauTruoc.Click += new System.EventHandler(this.BtnCauTruoc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(40, 568);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 38);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(920, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbox_CauHoi
            // 
            this.grpbox_CauHoi.BackColor = System.Drawing.SystemColors.Menu;
            this.grpbox_CauHoi.Controls.Add(this.picNoiDung);
            this.grpbox_CauHoi.Controls.Add(this.radbtnD);
            this.grpbox_CauHoi.Controls.Add(this.radbtnB);
            this.grpbox_CauHoi.Controls.Add(this.radbtnC);
            this.grpbox_CauHoi.Controls.Add(this.radbtnA);
            this.grpbox_CauHoi.Controls.Add(this.lblCauHoi);
            this.grpbox_CauHoi.Location = new System.Drawing.Point(4, 93);
            this.grpbox_CauHoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_CauHoi.Name = "grpbox_CauHoi";
            this.grpbox_CauHoi.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_CauHoi.Size = new System.Drawing.Size(1072, 357);
            this.grpbox_CauHoi.TabIndex = 9;
            this.grpbox_CauHoi.TabStop = false;
            // 
            // picNoiDung
            // 
            this.picNoiDung.Location = new System.Drawing.Point(164, 34);
            this.picNoiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNoiDung.Name = "picNoiDung";
            this.picNoiDung.Size = new System.Drawing.Size(559, 103);
            this.picNoiDung.TabIndex = 6;
            this.picNoiDung.TabStop = false;
            // 
            // radbtnD
            // 
            this.radbtnD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD.Location = new System.Drawing.Point(626, 267);
            this.radbtnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radbtnD.Name = "radbtnD";
            this.radbtnD.Size = new System.Drawing.Size(412, 69);
            this.radbtnD.TabIndex = 5;
            this.radbtnD.Text = "Đáp án D";
            this.radbtnD.UseVisualStyleBackColor = false;
            // 
            // radbtnB
            // 
            this.radbtnB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnB.Location = new System.Drawing.Point(626, 163);
            this.radbtnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radbtnB.Name = "radbtnB";
            this.radbtnB.Size = new System.Drawing.Size(412, 69);
            this.radbtnB.TabIndex = 4;
            this.radbtnB.Text = "Đáp án B";
            this.radbtnB.UseVisualStyleBackColor = false;
            // 
            // radbtnC
            // 
            this.radbtnC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnC.Location = new System.Drawing.Point(36, 267);
            this.radbtnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radbtnC.Name = "radbtnC";
            this.radbtnC.Size = new System.Drawing.Size(412, 69);
            this.radbtnC.TabIndex = 3;
            this.radbtnC.Text = "Đáp án C";
            this.radbtnC.UseVisualStyleBackColor = false;
            // 
            // radbtnA
            // 
            this.radbtnA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnA.Location = new System.Drawing.Point(36, 163);
            this.radbtnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radbtnA.Name = "radbtnA";
            this.radbtnA.Size = new System.Drawing.Size(412, 69);
            this.radbtnA.TabIndex = 2;
            this.radbtnA.Text = "Đáp án A";
            this.radbtnA.UseVisualStyleBackColor = false;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.SystemColors.Window;
            this.lblCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(34, 27);
            this.lblCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(1006, 118);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Nội dung câu hỏi";
            // 
            // lbl_TenBaiThi
            // 
            this.lbl_TenBaiThi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_TenBaiThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TenBaiThi.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBaiThi.Location = new System.Drawing.Point(0, 0);
            this.lbl_TenBaiThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenBaiThi.Name = "lbl_TenBaiThi";
            this.lbl_TenBaiThi.Size = new System.Drawing.Size(1077, 42);
            this.lbl_TenBaiThi.TabIndex = 8;
            this.lbl_TenBaiThi.Text = "Tên Bài thi";
            this.lbl_TenBaiThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoCauHoi
            // 
            this.lblSoCauHoi.AutoSize = true;
            this.lblSoCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauHoi.Location = new System.Drawing.Point(36, 67);
            this.lblSoCauHoi.Name = "lblSoCauHoi";
            this.lblSoCauHoi.Size = new System.Drawing.Size(183, 21);
            this.lblSoCauHoi.TabIndex = 17;
            this.lblSoCauHoi.Text = "Đề thi gồm có xxx câu.";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 56;
            // 
            // CauTraLoi
            // 
            this.CauTraLoi.HeaderText = "Câu trả lời";
            this.CauTraLoi.MinimumWidth = 6;
            this.CauTraLoi.Name = "CauTraLoi";
            this.CauTraLoi.ReadOnly = true;
            this.CauTraLoi.Width = 97;
            // 
            // DapAn
            // 
            this.DapAn.HeaderText = "Đáp án";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.ReadOnly = true;
            this.DapAn.Width = 77;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Kết quả";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 80;
            // 
            // frmLamBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 616);
            this.ControlBox = false;
            this.Controls.Add(this.lblSoCauHoi);
            this.Controls.Add(this.dgvDapAn);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbox_CauHoi);
            this.Controls.Add(this.lbl_TenBaiThi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLamBaiThi";
            this.Text = "Làm bài thi";
            this.Load += new System.EventHandler(this.frmLamBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).EndInit();
            this.grpbox_CauHoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDapAn;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox_CauHoi;
        private System.Windows.Forms.RadioButton radbtnD;
        private System.Windows.Forms.RadioButton radbtnB;
        private System.Windows.Forms.RadioButton radbtnC;
        private System.Windows.Forms.RadioButton radbtnA;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lbl_TenBaiThi;
        private System.Windows.Forms.Label lblSoCauHoi;
        private System.Windows.Forms.PictureBox picNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauTraLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}