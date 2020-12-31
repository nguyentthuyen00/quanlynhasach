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
    public partial class UC_AdKM : UserControl
    {
        public UC_AdKM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddKM KM = new AddKM())
            {
                KM.ShowDialog();
            }
        }

        private void UC_AdKM_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AddKM KM = new AddKM())
            {
                KM.ShowDialog();
            }
        }
    }
}
