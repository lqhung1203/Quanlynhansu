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
    public partial class frmphongban : Form
    {

        public frmphongban()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True");
        SqlCommand cmdphongban;
        SqlDataAdapter da_Phongban;
        DataTable dtPhongban = new DataTable();
        private void frmphongban_Load(object sender, EventArgs e)
        {
            dtgPhongban.DataSource = layDSPhongban();
        }
        private DataTable layDSPhongban()
        {
            try
            {
                //Mo ket noi
                conn.Open();
                cmdphongban = new SqlCommand();
                cmdphongban.CommandText = "select * from PhongBan";
                cmdphongban.CommandType = CommandType.Text;
                cmdphongban.Connection = conn;

                da_Phongban = new SqlDataAdapter(cmdphongban);
                da_Phongban.Fill(dtPhongban);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi " + ex.Message);
                dtPhongban = null;
            }
            finally
            {
                conn.Close();
            }
            return dtPhongban;
        }
        private void RessetInfo()
        {
            txtMaPb.Text = "";
            txtTenphongban.Text = "";
            txtMaPb.Focus();
        }

        private void dtgPhongban_Click(object sender, EventArgs e)
        {
            //lay dong vua click
            int dong = dtgPhongban.CurrentCell.RowIndex;
            txtMaPb.Text = dtgPhongban.Rows[dong].Cells[0].Value.ToString();
            txtTenphongban.Text = dtgPhongban.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPb.Enabled = true;
            if (Kiemtrathongtin())
            {
                try
                {
                    //modb
                    conn.Open();
                    cmdphongban = new SqlCommand();
                    cmdphongban.CommandText = "sp_Themphongban";//Ten cua store
                    cmdphongban.CommandType = CommandType.StoredProcedure;
                    cmdphongban.Connection = conn;

                    //them cac tham so
                    SqlParameter ma = new SqlParameter("@Ma_PB", txtMaPb.Text);
                    SqlParameter ten = new SqlParameter("@Ten_PB", txtTenphongban.Text);

                    //them vao comnad
                    cmdphongban.Parameters.Add(ma);
                    cmdphongban.Parameters.Add(ten);
                    //thuc thi cau lenh
                    if (cmdphongban.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        RessetInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
                finally { conn.Close(); }
                //load du lieu len 
                dtPhongban.Clear();
                dtgPhongban.DataSource = layDSPhongban();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            txtMaPb.Enabled = false;
            if (txtTenphongban.Text == "")
            {
                MessageBox.Show("Tên phòng ban không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenphongban.Focus();
                return;
            }
            else
            {
                try
                {
                    //modb
                    conn.Open();
                    cmdphongban = new SqlCommand();
                    cmdphongban.CommandText = "sp_Suaphongban";//Ten cua store
                    cmdphongban.CommandType = CommandType.StoredProcedure;
                    cmdphongban.Connection = conn;
                    //them cac tham so
                    SqlParameter ma = new SqlParameter("@Ma_PB", txtMaPb.Text);
                    SqlParameter ten = new SqlParameter("@Ten_PB", txtTenphongban.Text);

                    //them vao comnad
                    cmdphongban.Parameters.Add(ma);
                    cmdphongban.Parameters.Add(ten);
                    //thuc thi cau lenh
                    if (cmdphongban.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        RessetInfo();
                        txtTenphongban.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban cần sửa!!");
                }
                finally { conn.Close(); }
            }
            //load du lieu len 
            dtPhongban.Clear();
            dtgPhongban.DataSource = layDSPhongban();
        }
        private bool Kiemtrathongtin()
        {
            if (txtMaPb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban", "Thông báo");
                txtMaPb.Focus();
                return false;
            }
            if (txtTenphongban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban", "Thông báo");
                txtTenphongban.Focus();
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaPb.Enabled = true;
            if (dtgPhongban.Rows.Count == 0)
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
                    cmdphongban = new SqlCommand();
                    cmdphongban.CommandText = "sp_Xoaphongban";//Ten cua store
                    cmdphongban.CommandType = CommandType.StoredProcedure;
                    cmdphongban.Connection = conn;

                    //them cac tham so
                    SqlParameter ma = new SqlParameter("@Ma_PB", txtMaPb.Text);

                    //them vao comnad
                    cmdphongban.Parameters.Add(ma);
                    //thuc thi cau lenh
                    if (cmdphongban.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        RessetInfo();
                        txtMaPb.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn mã phòng ban cần xóa!!");
                        RessetInfo();
                        txtMaPb.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                finally { conn.Close(); }
                //load du lieu len 
                dtPhongban.Clear();
                dtgPhongban.DataSource = layDSPhongban();
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaPb.Text = "";
            txtTenphongban.Text = "";
            txtMaPb.Enabled = true;
            txtMaPb.Focus();
        }

        private void dtgPhongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
