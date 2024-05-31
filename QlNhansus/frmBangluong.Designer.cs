namespace QLNhanSu
{
    partial class frmBangluong
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtBangluong = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXembangluong = new System.Windows.Forms.Button();
            this.dtgLuongnv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuongnv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "BẢNG LƯƠNG NHÂN VIÊN";
            // 
            // dtBangluong
            // 
            this.dtBangluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBangluong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBangluong.Location = new System.Drawing.Point(275, 132);
            this.dtBangluong.Name = "dtBangluong";
            this.dtBangluong.Size = new System.Drawing.Size(256, 28);
            this.dtBangluong.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bảng lương theo tháng: ";
            // 
            // btnXembangluong
            // 
            this.btnXembangluong.Location = new System.Drawing.Point(744, 129);
            this.btnXembangluong.Name = "btnXembangluong";
            this.btnXembangluong.Size = new System.Drawing.Size(99, 36);
            this.btnXembangluong.TabIndex = 22;
            this.btnXembangluong.Text = "Xem\r\n";
            this.btnXembangluong.UseVisualStyleBackColor = true;
            // 
            // dtgLuongnv
            // 
            this.dtgLuongnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLuongnv.BackgroundColor = System.Drawing.Color.White;
            this.dtgLuongnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLuongnv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgLuongnv.Location = new System.Drawing.Point(0, 210);
            this.dtgLuongnv.Name = "dtgLuongnv";
            this.dtgLuongnv.RowHeadersWidth = 62;
            this.dtgLuongnv.RowTemplate.Height = 28;
            this.dtgLuongnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLuongnv.Size = new System.Drawing.Size(1020, 397);
            this.dtgLuongnv.TabIndex = 23;
            // 
            // frmBangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 607);
            this.Controls.Add(this.dtgLuongnv);
            this.Controls.Add(this.btnXembangluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtBangluong);
            this.Controls.Add(this.label1);
            this.Name = "frmBangluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucvu";
            this.Load += new System.EventHandler(this.frmBangluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuongnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBangluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXembangluong;
        private System.Windows.Forms.DataGridView dtgLuongnv;
    }
}