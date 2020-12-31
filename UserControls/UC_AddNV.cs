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
    public partial class UC_AddNV : UserControl
    {
        public UC_AddNV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddNV NV = new AddNV())
            {
                NV.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AddNV NV = new AddNV())
            {
                NV.ShowDialog();
            }
        }
    }
}
