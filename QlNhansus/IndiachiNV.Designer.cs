namespace QlNhansus
{
    partial class IndiachiNV
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
            this.crvdiachi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdiachi
            // 
            this.crvdiachi.ActiveViewIndex = -1;
            this.crvdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdiachi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvdiachi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdiachi.Location = new System.Drawing.Point(0, 0);
            this.crvdiachi.Name = "crvdiachi";
            this.crvdiachi.Size = new System.Drawing.Size(924, 680);
            this.crvdiachi.TabIndex = 0;
            this.crvdiachi.Load += new System.EventHandler(this.crvdiachi_Load);
            // 
            // IndiachiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 680);
            this.Controls.Add(this.crvdiachi);
            this.Name = "IndiachiNV";
            this.Text = "IndiachiNV";
            this.Load += new System.EventHandler(this.IndiachiNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvdiachi;
    }
}