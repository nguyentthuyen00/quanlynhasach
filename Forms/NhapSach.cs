using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMoonLight.Forms
{
    public partial class NhapSach : Form
    {
        public NhapSach()
        {
            InitializeComponent();
            timerns.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timerns_Tick(object sender, EventArgs e)
        {
            labelTime.Text =" Date: " + DateTime.Now.ToString();
        }
        private void labelTime_Click(object sender, EventArgs e)
        {
            labelTime.Text = " Date: " + DateTime.Now.ToString();
        }

        private void NhapSach_Load(object sender, EventArgs e)
        {
            labelTime_Click(sender, e);
        }
    }
}
