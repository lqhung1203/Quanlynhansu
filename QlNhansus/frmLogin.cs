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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            string Thongbao ="";
            HienThiThongBao(Thongbao);
            AnMatKhau();       
        }
        public static string LoaiTaiKhoan = "-1";
        public static string conn = "Data Source=HUNG123\\SQLEXPRESS;Initial Catalog=QLNhansuu;Integrated Security=True";
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTakhoan.Text;
            string matKhau = txtMatkhau.Text;

            SqlConnection connect = new SqlConnection(conn);
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }


            string taikhoan = txtTakhoan.Text.Trim();
            string matkhau = txtMatkhau.Text.Trim();
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "' AND MatKhau='" + matkhau + "' ";
            SqlCommand cmd= new SqlCommand(query,connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                LoaiTaiKhoan = ds.Tables[0].Rows[0]["LoaiTaiKhoan"].ToString();
                frmMain tc = new frmMain(LoaiTaiKhoan);
                tc.Show();
                this.Hide();
            }
            else
            {
                // Sai tên đăng nhập hoặc mật khẩu
                HienThiThongBao("Tên đăng nhập hoặc mật khẩu không đúng.");
            }

        }
        //private string KiemTraQuyenHan(string tenDangNhap, string matKhau)
        //{
        //    string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

        //    // Tạo đối tượng SqlConnection và SqlCommand
        //    using (SqlConnection connection = new SqlConnection(conn))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        // Thêm tham số cho câu lệnh
        //        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
        //        command.Parameters.AddWithValue("@MatKhau", matKhau);

        //        // Mở kết nối và thực hiện câu lệnh
        //        connection.Open();

        //        // Kiểm tra quyền hạn
        //        object result = command.ExecuteScalar();
        //        if (result != null)
        //        {
        //            string loaiTaiKhoan = result.ToString();    
        //            if (loaiTaiKhoan == "Admin")
        //            {
        //                // Người dùng có quyền Admin
        //                MessageBox.Show("Chào mừng Admin!");
        //            }
        //            else
        //            {
        //                // Người dùng có quyền User
        //                MessageBox.Show("Chào mừng User!");    
        //            }
        //            return loaiTaiKhoan;
        //        }
        //        else
        //        {
        //            // Sai tên đăng nhập hoặc mật khẩu
        //            HienThiThongBao("Tên đăng nhập hoặc mật khẩu không đúng.");
        //            return null;
        //        }
        //    }
        //}
        private void frmLogin_Load(object sender, EventArgs e)
        {

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
        private void cboAnHien_CheckedChanged(object sender, EventArgs e)
        {
            bool hienMatKhau = cboAnHien.Checked;

            // Hiển thị hoặc ẩn mật khẩu tùy thuộc vào trạng thái của CheckBox
            if (hienMatKhau)
            {
                HienMatKhau();
            }
            else
            {
                AnMatKhau();
            }
        }
        private void AnMatKhau()
        {
            
            txtMatkhau.PasswordChar = '*';
        }

        private void HienMatKhau()
        {     
            txtMatkhau.PasswordChar = '\0';
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
