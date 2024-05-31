using QlNhansus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class frmMain : Form
    {

        public frmMain(string LoaitaiKhoan)
        {
            InitializeComponent();
            if (LoaitaiKhoan == "Admin")
            {
                
            }
            else
            {
                mnDMK.Enabled = true;
                mnThongtinnhansu.Enabled = false;
                mnThemTK.Enabled = false;
                mnBangluong.Enabled = true;
                mnPhongban.Enabled = false;
                mnBhyt.Enabled = false;
                mnBangluong.Enabled = true;
            }    
        }

        private void frmTrangchu_Load(object sender, EventArgs e)
        {
        }

        private void mnPhongban_Click(object sender, EventArgs e)
        {

            frmphongban pb = new frmphongban();
            pb.MdiParent = this;
            pb.Show();
        }

        private void mnChamcong_Click(object sender, EventArgs e)
        {
            frmChamcong cc = new frmChamcong();
            cc.Show();
        }

        private void mnBangluong_Click(object sender, EventArgs e)
        {
            frmBangluong bl = new frmBangluong();
            bl.Show();
        }

        private void mnThongtinnhansu_Click(object sender, EventArgs e)
        {
            frmthongtinnv ttns = new frmthongtinnv();
            ttns.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                frmLogin lg = new frmLogin();
                lg.Show();
                this.Hide();
            }
        }
        private void mnBhyt_Click(object sender, EventArgs e)
        {
            frmBaohiem bh = new frmBaohiem();
            bh.Show();
        }

        private void mnThemTK_Click(object sender, EventArgs e)
        {
            frmTaikhoan tk = new frmTaikhoan();
            tk.Show();
        }

        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.Show();
        }

        private void địaChỉLiênHệNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndiachiNV fr = new IndiachiNV();
            fr.MdiParent = this;
            fr.Show();
        }

        private void bậcLươngCủaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBacluongNV b = new InBacluongNV();   
            b.MdiParent = this;
            b.Show();
        }
    }
}
