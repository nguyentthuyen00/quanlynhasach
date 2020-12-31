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
    public partial class UC_TraCuu : UserControl
    {
        public UC_TraCuu()
        {
            InitializeComponent();
            UC_SearchSach b = new UC_SearchSach();
            AddControlsToPanel3(b);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddControlsToPanel3(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl4.Controls.Clear();
            panelControl4.Controls.Add(c);
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            UC_SearchSach b = new UC_SearchSach();
            AddControlsToPanel3(b);
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            UC_SearchTL a = new UC_SearchTL();
            AddControlsToPanel3(a);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            UC_SearchKM KM = new UC_SearchKM();
            AddControlsToPanel3(KM);
        }

        private void btnQD_Click(object sender, EventArgs e)
        {
            UC_SearchQD QD = new UC_SearchQD();
            AddControlsToPanel3(QD);
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
