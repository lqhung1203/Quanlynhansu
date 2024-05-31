namespace QLNhanSu
{
    partial class frmChamcong
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
            this.btnXoachamcong = new System.Windows.Forms.Button();
            this.dtNgaychamcong = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgChamcong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txTennv = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapnhatchamcong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHẤM CÔNG";
            // 
            // btnXoachamcong
            // 
            this.btnXoachamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoachamcong.Location = new System.Drawing.Point(353, 524);
            this.btnXoachamcong.Name = "btnXoachamcong";
            this.btnXoachamcong.Size = new System.Drawing.Size(192, 27);
            this.btnXoachamcong.TabIndex = 15;
            this.btnXoachamcong.Text = "XÓA CHẤM CÔNG";
            this.btnXoachamcong.UseVisualStyleBackColor = true;
            // 
            // dtNgaychamcong
            // 
            this.dtNgaychamcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaychamcong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaychamcong.Location = new System.Drawing.Point(71, 524);
            this.dtNgaychamcong.Name = "dtNgaychamcong";
            this.dtNgaychamcong.Size = new System.Drawing.Size(256, 28);
            this.dtNgaychamcong.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tình trạng: ";
            // 
            // dtgChamcong
            // 
            this.dtgChamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChamcong.BackgroundColor = System.Drawing.Color.White;
            this.dtgChamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamcong.Location = new System.Drawing.Point(21, 172);
            this.dtgChamcong.Name = "dtgChamcong";
            this.dtgChamcong.RowHeadersWidth = 62;
            this.dtgChamcong.RowTemplate.Height = 28;
            this.dtgChamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChamcong.Size = new System.Drawing.Size(1007, 346);
            this.dtgChamcong.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Họ tên: ";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Location = new System.Drawing.Point(163, 125);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(140, 28);
            this.txtManv.TabIndex = 28;
            // 
            // txTennv
            // 
            this.txTennv.Enabled = false;
            this.txTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTennv.Location = new System.Drawing.Point(392, 126);
            this.txTennv.Name = "txTennv";
            this.txTennv.Size = new System.Drawing.Size(246, 28);
            this.txTennv.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(767, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // btnCapnhatchamcong
            // 
            this.btnCapnhatchamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhatchamcong.Location = new System.Drawing.Point(799, 529);
            this.btnCapnhatchamcong.Name = "btnCapnhatchamcong";
            this.btnCapnhatchamcong.Size = new System.Drawing.Size(160, 28);
            this.btnCapnhatchamcong.TabIndex = 15;
            this.btnCapnhatchamcong.Text = "CẬP NHẬT";
            this.btnCapnhatchamcong.UseVisualStyleBackColor = true;
            // 
            // frmChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 564);
            this.Controls.Add(this.btnCapnhatchamcong);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnXoachamcong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.txTennv);
            this.Controls.Add(this.dtgChamcong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNgaychamcong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmChamcong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChamcong";
            this.Load += new System.EventHandler(this.frmChamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoachamcong;
        private System.Windows.Forms.DateTimePicker dtNgaychamcong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgChamcong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txTennv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapnhatchamcong;
    }
}