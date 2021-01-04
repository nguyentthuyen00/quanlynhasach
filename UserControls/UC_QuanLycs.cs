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
    public partial class UC_QuanLycs : UserControl
    {
        public UC_QuanLycs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ThemSach s = new ThemSach())
            {
                s.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ThemSach s = new ThemSach())
            {
                s.ShowDialog();
            }
        }
    }
}
