using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSMoonLight.Forms;

namespace NSMoonLight.UserControls
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }
        private void tabCN_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddKM KM = new AddKM())
            {
                KM.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AddKM KM = new AddKM())
            {
                KM.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (AddNV NV = new AddNV())
            {
                NV.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (AddNV NV = new AddNV())
            {
                NV.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (AddCongNo CN = new AddCongNo())
            {
                CN.ShowDialog();
            }
        }
    }
}
