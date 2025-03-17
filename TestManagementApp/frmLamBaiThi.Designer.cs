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
            this.dgvDapAn = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauTraLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_CauHoi = new System.Windows.Forms.GroupBox();
            this.radbtnD = new System.Windows.Forms.RadioButton();
            this.radbtnB = new System.Windows.Forms.RadioButton();
            this.radbtnC = new System.Windows.Forms.RadioButton();
            this.radbtnA = new System.Windows.Forms.RadioButton();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lbl_TenBaiThi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).BeginInit();
            this.grpbox_CauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDapAn
            // 
            this.dgvDapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDapAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CauTraLoi,
            this.DapAn,
            this.TrangThai});
            this.dgvDapAn.Location = new System.Drawing.Point(285, 571);
            this.dgvDapAn.Name = "dgvDapAn";
            this.dgvDapAn.RowHeadersWidth = 51;
            this.dgvDapAn.RowTemplate.Height = 24;
            this.dgvDapAn.Size = new System.Drawing.Size(554, 175);
            this.dgvDapAn.TabIndex = 14;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // CauTraLoi
            // 
            this.CauTraLoi.HeaderText = "Câu trả lời";
            this.CauTraLoi.MinimumWidth = 6;
            this.CauTraLoi.Name = "CauTraLoi";
            this.CauTraLoi.ReadOnly = true;
            this.CauTraLoi.Width = 125;
            // 
            // DapAn
            // 
            this.DapAn.HeaderText = "Đáp Án";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.ReadOnly = true;
            this.DapAn.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 125;
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblKetQua.Location = new System.Drawing.Point(898, 571);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(318, 85);
            this.lblKetQua.TabIndex = 16;
            this.lblKetQua.Text = "Điểm của bài thi : ? điểm\r\nSố câu đúng của bài thi : ?/n câu";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNopBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNopBai.Location = new System.Drawing.Point(898, 699);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(318, 47);
            this.btnNopBai.TabIndex = 15;
            this.btnNopBai.Text = "Nộp Bài và Kết Thúc";
            this.btnNopBai.UseVisualStyleBackColor = false;
            // 
            // btnCauSau
            // 
            this.btnCauSau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauSau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCauSau.Location = new System.Drawing.Point(1240, 571);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(151, 47);
            this.btnCauSau.TabIndex = 13;
            this.btnCauSau.Text = "Câu Sau";
            this.btnCauSau.UseVisualStyleBackColor = false;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauTruoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCauTruoc.Location = new System.Drawing.Point(54, 571);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(151, 47);
            this.btnCauTruoc.TabIndex = 12;
            this.btnCauTruoc.Text = "Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(1240, 699);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 47);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1219, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbox_CauHoi
            // 
            this.grpbox_CauHoi.BackColor = System.Drawing.SystemColors.Menu;
            this.grpbox_CauHoi.Controls.Add(this.radbtnD);
            this.grpbox_CauHoi.Controls.Add(this.radbtnB);
            this.grpbox_CauHoi.Controls.Add(this.radbtnC);
            this.grpbox_CauHoi.Controls.Add(this.radbtnA);
            this.grpbox_CauHoi.Controls.Add(this.lblCauHoi);
            this.grpbox_CauHoi.Location = new System.Drawing.Point(6, 115);
            this.grpbox_CauHoi.Name = "grpbox_CauHoi";
            this.grpbox_CauHoi.Size = new System.Drawing.Size(1430, 456);
            this.grpbox_CauHoi.TabIndex = 9;
            this.grpbox_CauHoi.TabStop = false;
            // 
            // radbtnD
            // 
            this.radbtnD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD.Location = new System.Drawing.Point(835, 329);
            this.radbtnD.Name = "radbtnD";
            this.radbtnD.Size = new System.Drawing.Size(550, 85);
            this.radbtnD.TabIndex = 5;
            this.radbtnD.TabStop = true;
            this.radbtnD.Text = "Đáp án D";
            this.radbtnD.UseVisualStyleBackColor = false;
            // 
            // radbtnB
            // 
            this.radbtnB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnB.Location = new System.Drawing.Point(835, 201);
            this.radbtnB.Name = "radbtnB";
            this.radbtnB.Size = new System.Drawing.Size(550, 85);
            this.radbtnB.TabIndex = 4;
            this.radbtnB.TabStop = true;
            this.radbtnB.Text = "Đáp án B";
            this.radbtnB.UseVisualStyleBackColor = false;
            // 
            // radbtnC
            // 
            this.radbtnC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnC.Location = new System.Drawing.Point(48, 329);
            this.radbtnC.Name = "radbtnC";
            this.radbtnC.Size = new System.Drawing.Size(550, 85);
            this.radbtnC.TabIndex = 3;
            this.radbtnC.TabStop = true;
            this.radbtnC.Text = "Đáp án C";
            this.radbtnC.UseVisualStyleBackColor = false;
            // 
            // radbtnA
            // 
            this.radbtnA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnA.Location = new System.Drawing.Point(48, 201);
            this.radbtnA.Name = "radbtnA";
            this.radbtnA.Size = new System.Drawing.Size(550, 85);
            this.radbtnA.TabIndex = 2;
            this.radbtnA.TabStop = true;
            this.radbtnA.Text = "Đáp án A";
            this.radbtnA.UseVisualStyleBackColor = false;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.SystemColors.Window;
            this.lblCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(45, 33);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(1340, 145);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Nội dung câu hỏi";
            // 
            // lbl_TenBaiThi
            // 
            this.lbl_TenBaiThi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_TenBaiThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TenBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBaiThi.Location = new System.Drawing.Point(0, 0);
            this.lbl_TenBaiThi.Name = "lbl_TenBaiThi";
            this.lbl_TenBaiThi.Size = new System.Drawing.Size(1436, 52);
            this.lbl_TenBaiThi.TabIndex = 8;
            this.lbl_TenBaiThi.Text = "Tên Bài Thi";
            this.lbl_TenBaiThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLamBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 758);
            this.Controls.Add(this.dgvDapAn);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbox_CauHoi);
            this.Controls.Add(this.lbl_TenBaiThi);
            this.Name = "frmLamBaiThi";
            this.Text = "Bài Thi";
            this.Load += new System.EventHandler(this.frmLamBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).EndInit();
            this.grpbox_CauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauTraLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
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
    }
}