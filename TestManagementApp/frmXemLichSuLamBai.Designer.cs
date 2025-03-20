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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvKetQuaLamBai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQuaLamBai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKetQuaLamBai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQuaLamBai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQuaLamBai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQuaLamBai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKetQuaLamBai.Location = new System.Drawing.Point(21, 83);
            this.dgvKetQuaLamBai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKetQuaLamBai.MultiSelect = false;
            this.dgvKetQuaLamBai.Name = "dgvKetQuaLamBai";
            this.dgvKetQuaLamBai.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaLamBai.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKetQuaLamBai.RowHeadersVisible = false;
            this.dgvKetQuaLamBai.RowHeadersWidth = 51;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQuaLamBai.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKetQuaLamBai.RowTemplate.Height = 24;
            this.dgvKetQuaLamBai.ShowEditingIcon = false;
            this.dgvKetQuaLamBai.Size = new System.Drawing.Size(526, 254);
            this.dgvKetQuaLamBai.TabIndex = 0;
            // 
            // lblHoTenHS
            // 
            this.lblHoTenHS.AutoSize = true;
            this.lblHoTenHS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenHS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoTenHS.Location = new System.Drawing.Point(24, 28);
            this.lblHoTenHS.Name = "lblHoTenHS";
            this.lblHoTenHS.Size = new System.Drawing.Size(80, 21);
            this.lblHoTenHS.TabIndex = 10;
            this.lblHoTenHS.Text = "Học sinh:";
            // 
            // lblTenMaHS
            // 
            this.lblTenMaHS.AutoSize = true;
            this.lblTenMaHS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMaHS.Location = new System.Drawing.Point(112, 28);
            this.lblTenMaHS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenMaHS.Name = "lblTenMaHS";
            this.lblTenMaHS.Size = new System.Drawing.Size(52, 21);
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
            this.btnExit.Location = new System.Drawing.Point(465, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmXemLichSuLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTenMaHS);
            this.Controls.Add(this.lblHoTenHS);
            this.Controls.Add(this.dgvKetQuaLamBai);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmXemLichSuLamBai";
            this.Text = "Xem lịch sử làm bài";
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