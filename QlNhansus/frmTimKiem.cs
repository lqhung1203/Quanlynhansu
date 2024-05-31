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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
     public static   SqlConnection conn = new SqlConnection("Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dtgKetqua.DataSource= LayDSNhanSu();
            rdMa.Checked = true;
        }
        private DataTable LayDSNhanSu()
        {
            try
            {
                //Mo ket noi
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "LayDSNhansu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Tim = txtTimKiem.Text;
            string query = "";
            if (Tim == "")
            {
                dtgKetqua.DataSource = LayDSNhanSu();
                
            }
            else
            {
                try
                {
                    if (rdMa.Checked)
                    {
                        query = "SELECT ThongTinNhanSu.NhanVien_ID AS 'Mã Nhân Viên'," +
                     " ThongTinNhanSu.TenNhanVien AS 'Tên Nhân Viên'," +
                     " ThongTinNhanSu.NgaySinh AS 'Ngày Sinh'," +
                     " ThongTinNhanSu.GioiTinh AS 'Giới Tính'," +
                     " ThongTinNhanSu.DiaChi AS 'Địa Chỉ'," +
                     " ThongTinNhanSu.SoDienThoai AS 'Số Điện Thoại'," +
                     " ThongTinNhanSu.Email AS 'Email'," +
                     " PB.TenPhongBan AS 'Phòng Ban'," +
                     " CV.TenChucVu AS 'Chức Vụ'," +
                     " B.TenBHYT AS 'BHYT'," +
                     " HS.TenHeSo AS 'Hệ Số Lương'" +
                     " FROM ThongTinNhanSu" +
                     " LEFT JOIN PhongBan AS PB ON ThongTinNhanSu.PhongBan_ID = PB.PhongBan_ID" +
                     " LEFT JOIN ChucVu AS CV ON ThongTinNhanSu.ChucVu_ID = CV.ChucVu_ID" +
                     " LEFT JOIN BHYT AS B ON ThongTinNhanSu.BHYT_ID = B.BHYT_ID" +
                     " LEFT JOIN HeSoLuong AS HS ON ThongTinNhanSu.HeSo_ID = HS.HeSo_ID" +
                     " WHERE NhanVien_ID = @Tim";
                    }
                    else if (rdoTen.Checked)
                    {
                        query = "SELECT ThongTinNhanSu.NhanVien_ID AS 'Mã Nhân Viên'," +
                    " ThongTinNhanSu.TenNhanVien AS 'Tên Nhân Viên'," +
                    " ThongTinNhanSu.NgaySinh AS 'Ngày Sinh'," +
                    " ThongTinNhanSu.GioiTinh AS 'Giới Tính'," +
                    " ThongTinNhanSu.DiaChi AS 'Địa Chỉ'," +
                    " ThongTinNhanSu.SoDienThoai AS 'Số Điện Thoại'," +
                    " ThongTinNhanSu.Email AS 'Email'," +
                    " PB.TenPhongBan AS 'Phòng Ban'," +
                    " CV.TenChucVu AS 'Chức Vụ'," +
                    " B.TenBHYT AS 'BHYT'," +
                    " HS.TenHeSo AS 'Hệ Số Lương'" +
                    " FROM ThongTinNhanSu" +
                    " LEFT JOIN PhongBan AS PB ON ThongTinNhanSu.PhongBan_ID = PB.PhongBan_ID" +
                    " LEFT JOIN ChucVu AS CV ON ThongTinNhanSu.ChucVu_ID = CV.ChucVu_ID" +
                    " LEFT JOIN BHYT AS B ON ThongTinNhanSu.BHYT_ID = B.BHYT_ID" +
                    " LEFT JOIN HeSoLuong AS HS ON ThongTinNhanSu.HeSo_ID = HS.HeSo_ID" +
                    " WHERE TenNhanVien LIKE '%' + @Tim + '%'";
                    }
      
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Tim", Tim);

                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgKetqua.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi " + ex.Message);
                }
            }    

        }
    }
}
