using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMoonLight.UserControls
{
    public partial class UC_QuanLycs : UserControl
    {
        public UC_QuanLycs()
        {
            InitializeComponent();
            UC_Sach b = new UC_Sach();
            AddControlsToPanel2(b);
        }
        private void AddControlsToPanel2(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(c);
        }
        
        private void btnSach_Click(object sender, EventArgs e)
        {
            UC_Sach b = new UC_Sach();
            AddControlsToPanel2(b);
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            UC_TheLoai tl = new UC_TheLoai();
            AddControlsToPanel2(tl);
        }


        private void btnKho_Click(object sender, EventArgs e)
        {
            UC_Kho k = new UC_Kho();
            AddControlsToPanel2(k);
        }

       

        private void UC_QuanLycs_Load(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            UC_NCC n = new UC_NCC();
            AddControlsToPanel2(n);
        }
    }
}
