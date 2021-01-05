using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NSMoonLight
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            DAO.functionconnect.Connect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAO.functionconnect.Disconnect(); // Dong ket noi
            Application.Exit(); //Thoat
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtusername.Text;
            string MatKhau = txtpassword.Text;
            if (LayinfoTaiKhoan(TenDangNhap, MatKhau) != "")
            {
                DTO.infoTaiKhoan.MatKhau = txtpassword.Text;
               DashBoard d = new DashBoard();
                this.Hide();
                d.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
           
        }
        private string LayinfoTaiKhoan(string userName, string passWord)
        {
            SqlCommand cdm = new SqlCommand("select * from TAIKHOAN where TaiKhoan='" + userName + "' and MatKhau='" + passWord + "'", DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DTO.infoTaiKhoan.MATK = dr["IDTaiKhoan"].ToString();
                    DTO.infoTaiKhoan.TenHienThi = dr["TenHienThi"].ToString();
                    DTO.infoTaiKhoan.Quyen = dr["LoaiTaiKhoan"].ToString();
                    DTO.infoTaiKhoan.MaNV = dr["ThongTinTaiKhoan"].ToString();
                }
            }
            else
                MessageBox.Show("Lỗi khi truy vấn dữ liệu");
            return DTO.infoTaiKhoan.MATK;
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }
    }
}
