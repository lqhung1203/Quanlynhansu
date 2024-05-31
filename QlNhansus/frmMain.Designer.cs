namespace QLNhanSu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongtinnhansu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBhyt = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquanli = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhongban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChamcong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBangluong = new System.Windows.Forms.ToolStripMenuItem();
            this.inBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địaChỉLiênHệNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.bậcLươngCủaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mnTrangchu,
            this.mnquanli,
            this.mnThongke,
            this.mnTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDMK,
            this.mnDangxuat});
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnDMK
            // 
            this.mnDMK.Name = "mnDMK";
            this.mnDMK.Size = new System.Drawing.Size(221, 34);
            this.mnDMK.Text = "Đổi mật khẩu";
            // 
            // mnDangxuat
            // 
            this.mnDangxuat.Name = "mnDangxuat";
            this.mnDangxuat.Size = new System.Drawing.Size(221, 34);
            this.mnDangxuat.Text = "Đăng xuất";
            this.mnDangxuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mnTrangchu
            // 
            this.mnTrangchu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongtinnhansu,
            this.mnBhyt,
            this.tìmKiếmToolStripMenuItem1});
            this.mnTrangchu.Image = ((System.Drawing.Image)(resources.GetObject("mnTrangchu.Image")));
            this.mnTrangchu.Name = "mnTrangchu";
            this.mnTrangchu.Size = new System.Drawing.Size(133, 29);
            this.mnTrangchu.Text = "Danh mục";
            // 
            // mnThongtinnhansu
            // 
            this.mnThongtinnhansu.Image = ((System.Drawing.Image)(resources.GetObject("mnThongtinnhansu.Image")));
            this.mnThongtinnhansu.Name = "mnThongtinnhansu";
            this.mnThongtinnhansu.Size = new System.Drawing.Size(186, 34);
            this.mnThongtinnhansu.Text = "Nhân sự";
            this.mnThongtinnhansu.Click += new System.EventHandler(this.mnThongtinnhansu_Click);
            // 
            // mnBhyt
            // 
            this.mnBhyt.Image = ((System.Drawing.Image)(resources.GetObject("mnBhyt.Image")));
            this.mnBhyt.Name = "mnBhyt";
            this.mnBhyt.Size = new System.Drawing.Size(186, 34);
            this.mnBhyt.Text = "BHYT";
            this.mnBhyt.Click += new System.EventHandler(this.mnBhyt_Click);
            // 
            // tìmKiếmToolStripMenuItem1
            // 
            this.tìmKiếmToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem1.Image")));
            this.tìmKiếmToolStripMenuItem1.Name = "tìmKiếmToolStripMenuItem1";
            this.tìmKiếmToolStripMenuItem1.Size = new System.Drawing.Size(186, 34);
            this.tìmKiếmToolStripMenuItem1.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem1.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem1_Click);
            // 
            // mnquanli
            // 
            this.mnquanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPhongban,
            this.mnChamcong,
            this.mnThemTK});
            this.mnquanli.Image = ((System.Drawing.Image)(resources.GetObject("mnquanli.Image")));
            this.mnquanli.Name = "mnquanli";
            this.mnquanli.Size = new System.Drawing.Size(108, 29);
            this.mnquanli.Text = "Quản lí";
            // 
            // mnPhongban
            // 
            this.mnPhongban.Image = ((System.Drawing.Image)(resources.GetObject("mnPhongban.Image")));
            this.mnPhongban.Name = "mnPhongban";
            this.mnPhongban.Size = new System.Drawing.Size(238, 34);
            this.mnPhongban.Text = "Phòng ban";
            this.mnPhongban.Click += new System.EventHandler(this.mnPhongban_Click);
            // 
            // mnChamcong
            // 
            this.mnChamcong.Image = ((System.Drawing.Image)(resources.GetObject("mnChamcong.Image")));
            this.mnChamcong.Name = "mnChamcong";
            this.mnChamcong.Size = new System.Drawing.Size(238, 34);
            this.mnChamcong.Text = "Chấm công";
            this.mnChamcong.Click += new System.EventHandler(this.mnChamcong_Click);
            // 
            // mnThemTK
            // 
            this.mnThemTK.Name = "mnThemTK";
            this.mnThemTK.Size = new System.Drawing.Size(238, 34);
            this.mnThemTK.Text = "Thêm Tài Khoản";
            this.mnThemTK.Click += new System.EventHandler(this.mnThemTK_Click);
            // 
            // mnThongke
            // 
            this.mnThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBangluong,
            this.inBáoCáoToolStripMenuItem});
            this.mnThongke.Image = ((System.Drawing.Image)(resources.GetObject("mnThongke.Image")));
            this.mnThongke.Name = "mnThongke";
            this.mnThongke.Size = new System.Drawing.Size(126, 29);
            this.mnThongke.Text = "Thống kê";
            // 
            // mnBangluong
            // 
            this.mnBangluong.Image = ((System.Drawing.Image)(resources.GetObject("mnBangluong.Image")));
            this.mnBangluong.Name = "mnBangluong";
            this.mnBangluong.Size = new System.Drawing.Size(270, 34);
            this.mnBangluong.Text = "Bảng lương";
            this.mnBangluong.Click += new System.EventHandler(this.mnBangluong_Click);
            // 
            // inBáoCáoToolStripMenuItem
            // 
            this.inBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.địaChỉLiênHệNhânViênToolStripMenuItem,
            this.bậcLươngCủaNhânViênToolStripMenuItem});
            this.inBáoCáoToolStripMenuItem.Name = "inBáoCáoToolStripMenuItem";
            this.inBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inBáoCáoToolStripMenuItem.Text = "In-Báo Cáo";
            // 
            // địaChỉLiênHệNhânViênToolStripMenuItem
            // 
            this.địaChỉLiênHệNhânViênToolStripMenuItem.Name = "địaChỉLiênHệNhânViênToolStripMenuItem";
            this.địaChỉLiênHệNhânViênToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.địaChỉLiênHệNhânViênToolStripMenuItem.Text = "Địa chỉ liên hệ nhân viên";
            this.địaChỉLiênHệNhânViênToolStripMenuItem.Click += new System.EventHandler(this.địaChỉLiênHệNhânViênToolStripMenuItem_Click);
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.Image = ((System.Drawing.Image)(resources.GetObject("mnTrogiup.Image")));
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(117, 29);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // bậcLươngCủaNhânViênToolStripMenuItem
            // 
            this.bậcLươngCủaNhânViênToolStripMenuItem.Name = "bậcLươngCủaNhânViênToolStripMenuItem";
            this.bậcLươngCủaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.bậcLươngCủaNhânViênToolStripMenuItem.Text = "Bậc lương của nhân viên";
            this.bậcLươngCủaNhânViênToolStripMenuItem.Click += new System.EventHandler(this.bậcLươngCủaNhânViênToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 636);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangchu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangchu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnThongke;
        private System.Windows.Forms.ToolStripMenuItem mnquanli;
        private System.Windows.Forms.ToolStripMenuItem mnPhongban;
        private System.Windows.Forms.ToolStripMenuItem mnTrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnThongtinnhansu;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.ToolStripMenuItem mnChamcong;
        private System.Windows.Forms.ToolStripMenuItem mnBangluong;
        private System.Windows.Forms.ToolStripMenuItem mnBhyt;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDMK;
        private System.Windows.Forms.ToolStripMenuItem mnDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnThemTK;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địaChỉLiênHệNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bậcLươngCủaNhânViênToolStripMenuItem;
    }
}