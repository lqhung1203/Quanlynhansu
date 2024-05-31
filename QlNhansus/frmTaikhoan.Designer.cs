namespace QlNhansus
{
    partial class frmTaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaikhoan));
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgNSChuacoTK = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgNScoTK = new System.Windows.Forms.DataGridView();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNSChuacoTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNScoTK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(164, 163);
            this.txtmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(244, 35);
            this.txtmk.TabIndex = 30;
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(164, 92);
            this.txttk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(244, 35);
            this.txttk.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tài khoản";
            // 
            // dtgNSChuacoTK
            // 
            this.dtgNSChuacoTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNSChuacoTK.Location = new System.Drawing.Point(481, 61);
            this.dtgNSChuacoTK.Name = "dtgNSChuacoTK";
            this.dtgNSChuacoTK.RowHeadersWidth = 62;
            this.dtgNSChuacoTK.RowTemplate.Height = 28;
            this.dtgNSChuacoTK.Size = new System.Drawing.Size(430, 208);
            this.dtgNSChuacoTK.TabIndex = 32;
            this.dtgNSChuacoTK.Click += new System.EventHandler(this.dtgNSChuacoTK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Location = new System.Drawing.Point(15, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 91);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỨC NĂNG";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(801, 40);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(113, 38);
            this.btnNhaplai.TabIndex = 16;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(11, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 41);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.Image")));
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhat.Location = new System.Drawing.Point(202, 37);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(163, 41);
            this.btnCapnhat.TabIndex = 13;
            this.btnCapnhat.Text = "Cập nhật ";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(402, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 37);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(616, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 38);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgNScoTK
            // 
            this.dtgNScoTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNScoTK.Location = new System.Drawing.Point(25, 433);
            this.dtgNScoTK.Name = "dtgNScoTK";
            this.dtgNScoTK.RowHeadersWidth = 62;
            this.dtgNScoTK.RowTemplate.Height = 28;
            this.dtgNScoTK.Size = new System.Drawing.Size(883, 188);
            this.dtgNScoTK.TabIndex = 34;
            this.dtgNScoTK.Click += new System.EventHandler(this.dtgNScoTK_Click);
            // 
            // txtmaNV
            // 
            this.txtmaNV.Enabled = false;
            this.txtmaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaNV.Location = new System.Drawing.Point(164, 29);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(244, 35);
            this.txtmaNV.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "DANH SÁCH NHÂN SỰ CHƯA CÓ TÀI KHOẢN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(313, 241);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(68, 24);
            this.rdoUser.TabIndex = 39;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "User\r\n";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(190, 241);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(79, 24);
            this.rdoAdmin.TabIndex = 40;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(561, 631);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(30, 20);
            this.lbError.TabIndex = 41;
            this.lbError.Text = "lab";
            // 
            // frmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 655);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.rdoUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgNScoTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgNSChuacoTK);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "frmTaikhoan";
            this.Text = "frmTaikhoan";
            this.Load += new System.EventHandler(this.frmTaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNSChuacoTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNScoTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgNSChuacoTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgNScoTK;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnNhaplai;
    }
}