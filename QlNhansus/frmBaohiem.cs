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
    public partial class frmBaohiem : Form
    {
        public frmBaohiem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        private void frmBaohiem_Load(object sender, EventArgs e)
        {
            dtgBHYT.DataSource = LayDSBHYT();
        }
        private DataTable LayDSBHYT()
        {
            try
            {
                //Mo ket noi
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM BHYT";//Ten cua store
                cmd.CommandType = CommandType.Text;


                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi " + ex.Message);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void dtgBHYT_Click(object sender, EventArgs e)
        {
            int i = dtgBHYT.CurrentCell.RowIndex;
            txtMabh.Text = dtgBHYT.Rows[i].Cells[0].Value.ToString();
            txtTenbaohiem.Text = dtgBHYT.Rows[i].Cells[1].Value.ToString();
            txtMota.Text = dtgBHYT.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //modb
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_ThemBHYT";//Ten cua store
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //them cac tham so
                SqlParameter id = new SqlParameter("@BHYT_ID", txtMabh.Text);
                SqlParameter tenbh = new SqlParameter("@TenBHYT", txtTenbaohiem.Text);
                SqlParameter mota = new SqlParameter("@MoTa", txtMota.Text);


                //them vao comnad
                cmd.Parameters.Add(id);
                cmd.Parameters.Add(tenbh);
                cmd.Parameters.Add(mota);
                //thuc thi cau lenh
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    RessetDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã đã tồn tại" + ex);
            }
            finally { conn.Close(); }
            //load du lieu len 
            dt.Clear();
            dtgBHYT.DataSource = LayDSBHYT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgBHYT.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    //modb
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "sp_XoaBHYT";//Ten cua store
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    //them cac tham so
                    SqlParameter ma = new SqlParameter("@BHYT_ID", txtMabh.Text);


                    //them vao comnad
                    cmd.Parameters.Add(ma);
                    //thuc thi cau lenh
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        RessetDB();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Thất bại!! \n Bạn hãy đảm bảo rằng đã chuyển hết các nhân sự qua phòng ban khác");
                }
                finally { conn.Close(); }
            }
            //load du lieu len 
            dt.Clear();
            dtgBHYT.DataSource = LayDSBHYT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                //modb
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_SuaBHYT";//Ten cua store
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //them cac tham so
                SqlParameter idbhyt = new SqlParameter("@BHYT_ID", txtMabh.Text);
                SqlParameter mabhyt = new SqlParameter("@TenBHYT", txtTenbaohiem.Text);
                SqlParameter tenbhyt = new SqlParameter("@MoTa", txtMota.Text);



                //them vao comnad
                cmd.Parameters.Add(idbhyt);
                cmd.Parameters.Add(mabhyt);
                cmd.Parameters.Add(tenbhyt);
                //thuc thi cau lenh
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    RessetDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã đã tồn tại" + ex);
            }
            finally { conn.Close(); }
            //load du lieu len 
            dt.Clear();
            dtgBHYT.DataSource = LayDSBHYT();
        }
        private void RessetDB()
        {
            txtMabh.Text = "";
            txtTenbaohiem.Text = "";
            txtMota.Text = "";
        }
    }
}
