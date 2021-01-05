using NSMoonLight.UserControls;
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
    public partial class DashBoard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        
        public DashBoard()
        {
            InitializeComponent();
            timerTime.Start();
            label3.Text = DTO.infoTaiKhoan.TenHienThi;
            if (DTO.infoTaiKhoan.Quyen == "0")
                label5.Text = "Admin";
            else if (DTO.infoTaiKhoan.Quyen == "2")
            {
                label5.Text = "Quản Lý";
                btnAdmin.Enabled = false;
                btnAdmin.BackColor = Color.SlateGray;
            }
            else
            {
                label5.Text = "Nhân viên bán hàng";
                btnAdmin.Enabled = false;
                btnAdmin.BackColor = Color.SlateGray;
                btnBaoCaoTK.Enabled = false;
                btnBaoCaoTK.BackColor = Color.SlateGray;
                btnQuanLy.Enabled = false;
                btnQuanLy.BackColor = Color.SlateGray;
            }
            LayinfoNhanVien(DTO.infoTaiKhoan.MaNV);
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_HeThong uht = new UC_HeThong();
            AddControlsToPanel(uht);
        }
        private void LayinfoNhanVien(string MaNhanVien)
        {
            SqlCommand cdm = new SqlCommand("select * from NHANVIEN where MaNV='" + MaNhanVien + "'", DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string gt;
                    DTO.infoNhanVien.HoTenNV = dr["HoTenNV"].ToString();
                    DTO.infoNhanVien.Diachi = dr["Diachi"].ToString();
                    DTO.infoNhanVien.SDT = dr["SDT"].ToString();
                    gt = dr["GioiTinh"].ToString();
                    DTO.infoNhanVien.NgaySinh = dr["NgaySinh"].ToString();
                    DTO.infoNhanVien.Email = dr["Email"].ToString();
                    if (gt == "0")
                        DTO.infoNhanVien.GioiTinh = "Nam";
                    else if (gt == "1")
                        DTO.infoNhanVien.GioiTinh = "Nữ";
                    else
                        DTO.infoNhanVien.GioiTinh = "Khác";
                }
            }
            else
                MessageBox.Show("không tìm thấy  dữ liệu");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAdmin);
            UC_Admin admin = new UC_Admin();
            AddControlsToPanel(admin);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }    
            } 
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 52)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }    
            }    
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        } 

        private void label6_Click(object sender, EventArgs e)
        {
            labelTime.Text = " Date: " + DateTime.Now.ToString();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHeThong);
            UC_HeThong uht = new UC_HeThong();
            AddControlsToPanel(uht);

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = " Date: " + DateTime.Now.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoaDon);
            UC_HoaDon hd = new UC_HoaDon();
            AddControlsToPanel(hd);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnQuanLy);
            UC_QuanLycs ql = new UC_QuanLycs();
            AddControlsToPanel(ql);
        }

        private void btnBaoCaoTK_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBaoCaoTK);
            UC_BaoCaoTK bc = new UC_BaoCaoTK();
            AddControlsToPanel(bc);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTraCuu);
            UC_TraCuu tc = new UC_TraCuu();
            AddControlsToPanel(tc);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHelp);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            label6_Click(sender, e);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
