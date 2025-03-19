namespace TestManagementApp
{
    partial class frmXemLichSuLamBai
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
            this.dgvKetQuaLamBai = new System.Windows.Forms.DataGridView();
            this.lblHoTenHS = new System.Windows.Forms.Label();
            this.lblTenMaHS = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaLamBai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetQuaLamBai
            // 
            this.dgvKetQuaLamBai.AllowUserToAddRows = false;
            this.dgvKetQuaLamBai.AllowUserToDeleteRows = false;
            this.dgvKetQuaLamBai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaLamBai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQuaLamBai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaLamBai.Location = new System.Drawing.Point(28, 102);
            this.dgvKetQuaLamBai.Name = "dgvKetQuaLamBai";
            this.dgvKetQuaLamBai.ReadOnly = true;
            this.dgvKetQuaLamBai.RowHeadersWidth = 51;
            this.dgvKetQuaLamBai.RowTemplate.Height = 24;
            this.dgvKetQuaLamBai.Size = new System.Drawing.Size(701, 313);
            this.dgvKetQuaLamBai.TabIndex = 0;
            // 
            // lblHoTenHS
            // 
            this.lblHoTenHS.AutoSize = true;
            this.lblHoTenHS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenHS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoTenHS.Location = new System.Drawing.Point(32, 35);
            this.lblHoTenHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenHS.Name = "lblHoTenHS";
            this.lblHoTenHS.Size = new System.Drawing.Size(99, 28);
            this.lblHoTenHS.TabIndex = 10;
            this.lblHoTenHS.Text = "Học sinh:";
            // 
            // lblTenMaHS
            // 
            this.lblTenMaHS.AutoSize = true;
            this.lblTenMaHS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMaHS.Location = new System.Drawing.Point(150, 35);
            this.lblTenMaHS.Name = "lblTenMaHS";
            this.lblTenMaHS.Size = new System.Drawing.Size(65, 28);
            this.lblTenMaHS.TabIndex = 11;
            this.lblTenMaHS.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(620, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 36);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmXemLichSuLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 432);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTenMaHS);
            this.Controls.Add(this.lblHoTenHS);
            this.Controls.Add(this.dgvKetQuaLamBai);
            this.Name = "frmXemLichSuLamBai";
            this.Text = "Lịch Sử Làm Bài";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaLamBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKetQuaLamBai;
        private System.Windows.Forms.Label lblHoTenHS;
        private System.Windows.Forms.Label lblTenMaHS;
        private System.Windows.Forms.Button btnExit;
    }
}