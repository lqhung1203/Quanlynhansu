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
    public partial class frmTaikhoan : Form
    {
        public frmTaikhoan()
        {
           InitializeComponent();
            string Thongbao = "";
            rdoAdmin.Checked = true;
            HienThiThongBao(Thongbao);
            dtgNScoTK.DataSource = HienThiNhanSuCoTaiKhoan();
           dtgNSChuacoTK.DataSource = HienThiNhanSuChuaCoTaiKhoan();
        }
        String conn = "Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True";
        private DataTable HienThiNhanSuChuaCoTaiKhoan()
        {
            string query = @"
                       SELECT 
                    ThongTinNhanSu.NhanVien_ID AS 'Mã Nhân Viên',
                    ThongTinNhanSu.TenNhanVien AS'Tên Nhân Viên'
		            FROM ThongTinNhanSu
		            WHERE NhanVien_ID NOT IN (SELECT NhanVien_ID FROM TaiKhoan)";

            // Tạo đối tượng SqlConnection và SqlDataAdapter
            using (SqlConnection connection = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để lưu dữ liệu từ SQL
                DataTable da = new DataTable();

                // Mở kết nối và đổ dữ liệu vào DataTable
                connection.Open();
                adapter.Fill(da);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dtgNSChuacoTK.DataSource = da;
                return da;
            }
            
        }
        private DataTable HienThiNhanSuCoTaiKhoan()
        {
            string query = @"
            SELECT 
                ThongTinNhanSu.NhanVien_ID,
                ThongTinNhanSu.TenNhanVien,
                TaiKhoan.TenDangNhap,
                TaiKhoan.MatKhau,
                TaiKhoan.LoaiTaiKhoan
            FROM 
                ThongTinNhanSu
            JOIN 
                TaiKhoan ON ThongTinNhanSu.NhanVien_ID = TaiKhoan.NhanVien_ID";

            // Tạo đối tượng SqlConnection và SqlDataAdapter
            using (SqlConnection connection = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để lưu dữ liệu từ SQL
                DataTable dataTable = new DataTable();

                // Mở kết nối và đổ dữ liệu vào DataTable
                connection.Open();
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dtgNScoTK.DataSource = dataTable;
                return dataTable;
            }
        }
        private void dtgNSChuacoTK_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
            rdoAdmin.Focus();
            int dong = dtgNSChuacoTK.CurrentCell.RowIndex;
            txtmaNV.Text = dtgNSChuacoTK.Rows[dong].Cells[0].Value.ToString();
        }

        private void dtgNScoTK_Click(object sender, EventArgs e)
        {
            int dong = dtgNScoTK.CurrentCell.RowIndex;
            txtmaNV.Text = dtgNScoTK.Rows[dong].Cells[0].Value.ToString();
            txttk.Text = dtgNScoTK.Rows[dong].Cells[2].Value.ToString();
            txtmk.Text = dtgNScoTK.Rows[dong].Cells[3].Value.ToString();
            if (dtgNScoTK.Rows[dong].Cells[4].Value.ToString() =="Admin")
            {
                rdoAdmin.Checked = true;
                rdoUser.Checked = false;
            }
            else
            {
                rdoAdmin.Checked = false;
                rdoUser.Checked = true;
            }    
        
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "" || txtmk.Text=="")
            {
                HienThiThongBao("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                try
                {
                    string nhanVienID = txtmaNV.Text;
                    string tenDangNhap = txttk.Text;
                    string matKhau = txtmk.Text;
                    string loaiTaiKhoan;
                    if (rdoAdmin.Checked == true)
                    {
                        loaiTaiKhoan = rdoAdmin.Text;
                    }
                    else
                    {
                        loaiTaiKhoan = rdoUser.Text;
                    }
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("sp_ThemTaiKhoan", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@NhanVien_ID", nhanVienID);
                            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                            command.Parameters.AddWithValue("@MatKhau", matKhau);
                            command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

                            if (command.ExecuteNonQuery() > 0)
                            {
                                RessetDB();
                                HienThiThongBao("Thêm tài khoản thành công");
                            }
                            else
                            {
                                HienThiThongBao("Thêm tài khoản thất bại!!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                dtgNScoTK.DataSource = HienThiNhanSuCoTaiKhoan();
                dtgNSChuacoTK.DataSource = HienThiNhanSuChuaCoTaiKhoan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtmaNV.Text;
            
            if (txtmaNV.Text == "")
            {
                HienThiThongBao("Vui lòng chọn thông tin tài khoản cần Xóa!");
            }
            else
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa Tài Khoản này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("sp_XoaTaiKhoan", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@NhanVien_ID", maNhanVien);

                                if (command.ExecuteNonQuery() > 0)
                                {
                                    RessetDB();
                                    HienThiThongBao("Xóa tài khoản thành công");
                                }
                                else
                                {
                                    HienThiThongBao("Vui lòng chọn Mã Nhân Viên cần xóa \n Chỉ xóa được nhân viên nào có tài khoản!!");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    dtgNScoTK.DataSource = HienThiNhanSuCoTaiKhoan();
                    dtgNSChuacoTK.DataSource = HienThiNhanSuChuaCoTaiKhoan();
                }
            }    
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string nhanVienID = txtmaNV.Text;
            string tenDangNhap = txttk.Text;
            string matKhau = txtmk.Text;
            string loaiTaiKhoan;
            if (rdoAdmin.Checked == true)
            {
                loaiTaiKhoan = rdoAdmin.Text;
            }
            else
            {
                loaiTaiKhoan = rdoUser.Text;
            }
            if (txttk.Text=="" || txtmk.Text=="")
            {
                HienThiThongBao("Vui lòng nhập đầy đủ thông tin cần Cập nhật!!!");
            }else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("sp_SuaTaiKhoan", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@NhanVien_ID", nhanVienID);
                            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                            command.Parameters.AddWithValue("@MatKhau", matKhau);
                            command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

                            if (command.ExecuteNonQuery() > 0)
                            {
                                RessetDB();
                                HienThiThongBao("Sửa tài khoản thành công");
                            }
                            else
                            {
                                HienThiThongBao("Cập nhật thất bại!!");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                dtgNScoTK.DataSource = HienThiNhanSuCoTaiKhoan();
            }    
        }
        public void RessetDB()
        {
            txtmaNV.Text = "";
            txttk.Text = "";
            txtmk.Text = "";
            rdoAdmin.Focus();
        }
        private void HienThiThongBao(string thongBao)
        {
            if (string.IsNullOrWhiteSpace(thongBao))
            {
                // Nếu rỗng, ẩn Label
                lbError.Visible = false;
            }
            else
            {
                lbError.Text = thongBao;
                lbError.Visible = true;

            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtmaNV.Text = "";
            txttk.Text = "";
            txtmk.Text = "";
            rdoAdmin.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
