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
    public partial class UC_Kho : UserControl
    {
        public UC_Kho()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (NhapSach s = new NhapSach())
            {
                s.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NhapKho k = new NhapKho())
            {
                k.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (XuatKho x = new XuatKho())
            {
                x.ShowDialog();
            }
        }

        private void UC_Kho_Load(object sender, EventArgs e)
        {

        }
    }
}
