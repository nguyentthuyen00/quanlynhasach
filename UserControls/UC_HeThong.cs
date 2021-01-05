﻿using System;
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
    public partial class UC_HeThong : UserControl
    {
        public UC_HeThong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_HeThong_Load(object sender, EventArgs e)
        {
            txtTen.Text = DTO.infoNhanVien.HoTenNV;
            txtNS.Text = DTO.infoNhanVien.NgaySinh;
            txtSDT.Text = DTO.infoNhanVien.SDT;
            txtEmail.Text = DTO.infoNhanVien.Email;
            txtGT.Text = DTO.infoNhanVien.GioiTinh;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(ChangePassword P = new ChangePassword())
            {
                P.ShowDialog();
            }    
        }

        private void txtLTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
