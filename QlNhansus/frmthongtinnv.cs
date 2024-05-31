using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLNhanSu
{
    public partial class frmthongtinnv : Form
    {
        public frmthongtinnv()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        private void frmthongtinnv_Load(object sender, EventArgs e)
        {
            dtgNhansu.DataSource = layDSNhansu();
            RessetIF();
            LoadDSPhongban();
            LoadChucvu();
            LoadBHYT();
            LoadHesoluong();
        }
        private void RessetIF()
        {
            txtManv.Text = "";
            txTennv.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            rdoNam.Checked = true;
            txtDienthoai.Text = "";
        }
        private void LoadChucvu()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM ChucVu";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboChucvu.DisplayMember = "TenChucVu";
                cboChucvu.ValueMember = "ChucVu_ID";

                cboChucvu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetViTri(string Name,ComboBox Cb)
        {
            //MessageBox.Show(Name);
            for (int i = 0; i < Cb.Items.Count; i++)
            {
                string itemText = Cb.GetItemText(Cb.Items[i]);
                
                if (itemText.Equals(Name))
                {
                    Cb.SelectedIndex = i;
                    //MessageBox.Show(Cb.SelectedValue.ToString() + i);
                    break;
                }
            }
        }
        private void LoadDSPhongban()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM PhongBan";
                cmd.CommandType = CommandType.Text;
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPhongban.DisplayMember = "TenPhongBan";
                cboPhongban.ValueMember = "PhongBan_ID";

                cboPhongban.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadBHYT()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM BHYT";
                cmd.CommandType = CommandType.Text;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboBHYT.DisplayMember = "TenBHYT";
                cboBHYT.ValueMember = "BHYT_ID";

                cboBHYT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadHesoluong()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM HeSoLuong";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboHesoluong.DisplayMember = "TenHeSo";
                cboHesoluong.ValueMember = "HeSo_ID";

                cboHesoluong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private DataTable layDSNhansu()
        {
            try
            {
                //Mo ket noi
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "LayDSNhansu";//Ten cua store
                cmd.CommandType = CommandType.StoredProcedure;


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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNhanSu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@NhanVien_ID", txtManv.Text);
                cmd.Parameters.AddWithValue("@TenNhanVien", txTennv.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaysinh.Value);

                // Xác định giới tính
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtDienthoai.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@TenPhongBan", cboPhongban.Text);
                cmd.Parameters.AddWithValue("@TenChucVu", cboChucvu.Text);
                cmd.Parameters.AddWithValue("@TenBHYT", cboBHYT.Text);
                cmd.Parameters.AddWithValue("@TenHeSo", cboHesoluong.Text);

                // Thực thi stored procedure
                if (cmd.ExecuteNonQuery() > 0)
                {
                    RessetIF();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Nhân viên đã tồn tại hoặc có lỗi xảy ra trong quá trình thêm.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Load dữ liệu lên datagridview
            dt.Clear();
            dtgNhansu.DataSource = layDSNhansu();
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNhansu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgNhansu.SelectedRows[0];
                string maNhanVien = selectedRow.Cells[0].Value.ToString();

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_XoaNhanSu", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@NhanVien_ID", maNhanVien);
                            if (cmd.ExecuteNonQuery()>0)
                            {
                                RessetIF();
                                MessageBox.Show("Xóa thành công");
                            }
                        }

                        // Cập nhật lại DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        // Đảm bảo kết nối được đóng chỉ khi nó đã được mở thành công
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                    dt.Clear();
                    dtgNhansu.DataSource = layDSNhansu();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void dtgNhansu_Click(object sender, EventArgs e)
        {
            int dong = dtgNhansu.CurrentCell.RowIndex;
            txtManv.Text = dtgNhansu.Rows[dong].Cells[0].Value.ToString();
            txTennv.Text = dtgNhansu.Rows[dong].Cells[1].Value.ToString();
            dtNgaysinh.Text = dtgNhansu.Rows[dong].Cells[2].Value.ToString();
            if (dtgNhansu.Rows[dong].Cells[3].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
            txtDiachi.Text = dtgNhansu.Rows[dong].Cells[4].Value.ToString();
            txtDienthoai.Text = dtgNhansu.Rows[dong].Cells[5].Value.ToString();
            txtEmail.Text = dtgNhansu.Rows[dong].Cells[6].Value.ToString();
            //cboPhongban.Text = dtgNhansu.Rows[dong].Cells[7].Value.ToString();
            GetViTri(dtgNhansu.Rows[dong].Cells[7].Value.ToString(), cboPhongban);
            GetViTri(dtgNhansu.Rows[dong].Cells[8].Value.ToString(), cboChucvu);
            GetViTri(dtgNhansu.Rows[dong].Cells[9].Value.ToString(), cboBHYT);
            GetViTri(dtgNhansu.Rows[dong].Cells[10].Value.ToString(), cboHesoluong);

        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaNhanSu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@NhanVien_ID", txtManv.Text);
                cmd.Parameters.AddWithValue("@TenNhanVien", txTennv.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaysinh.Value);

                // Xác định giới tính
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtDienthoai.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                GetViTri(cboPhongban.SelectedValue.ToString(),cboPhongban);
                cmd.Parameters.AddWithValue("@PhongBan_ID", cboPhongban.SelectedValue.ToString());
                GetViTri(cboChucvu.SelectedValue.ToString(), cboChucvu);
                cmd.Parameters.AddWithValue("@ChucVu_ID", cboChucvu.SelectedValue.ToString());
                GetViTri(cboBHYT.SelectedValue.ToString(), cboBHYT);
                cmd.Parameters.AddWithValue("@BHYT_ID", cboBHYT.SelectedValue.ToString());
                GetViTri(cboHesoluong.SelectedValue.ToString(), cboHesoluong);
                cmd.Parameters.AddWithValue("@HeSo_ID", cboHesoluong.SelectedValue.ToString());

                // Thực thi stored procedure
                if (cmd.ExecuteNonQuery() > 0)
                {
                    RessetIF();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình Sửa!!.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dt.Clear();
            dtgNhansu.DataSource = layDSNhansu();
        }
    }
}
