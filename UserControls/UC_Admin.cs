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
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
            UC_AdKM KM = new UC_AdKM();
            AddControlsToPanelAdmin(KM);
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddControlsToPanelAdmin(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(c);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            UC_AdKM KM = new UC_AdKM();
            AddControlsToPanelAdmin(KM);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            UC_AddNV NV = new UC_AddNV();
            AddControlsToPanelAdmin(NV);
        }

        private void btnQD_Click(object sender, EventArgs e)
        {
            UC_AdQD qd = new UC_AdQD();
            AddControlsToPanelAdmin(qd);
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            UC_AdCongNo no = new UC_AdCongNo();
            AddControlsToPanelAdmin(no);
        }
    }
}
