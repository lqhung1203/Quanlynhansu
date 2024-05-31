using CrystalDecisions.CrystalReports.Engine;
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

namespace QlNhansus
{
    public partial class IndiachiNV : Form
    {
        public IndiachiNV()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        private void IndiachiNV_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("select NhanVien_ID,TenNhanVien,GioiTinh,DiaChi from ThongTinNhanSu", conn);
                cmd.CommandType = CommandType.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private void crvdiachi_Load(object sender, EventArgs e)
        {

        }
    }
}
