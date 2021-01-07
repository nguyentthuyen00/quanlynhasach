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
using System.Data.SqlClient;

namespace NSMoonLight.UserControls
{
    public partial class UC_QuanLycs : UserControl
    {
        public UC_QuanLycs()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            loadBook();
            loadCategory();
            loadSupplier();

            AddCateBinding();
            AddSupplierBinding();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flpListBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadBook()
        {
            string query = "SELECT S.MaSach, S.TenSach, S.TacGia, NCC.TenNCC, NXB.TenNXB, TL.TenTL, S.GiaNhap, S.GiaBan, S.DonViTinh FROM SACH S, NHAXUATBAN NXB, NHACUNGCAP NCC, THELOAI TL WHERE S.MaTheLoai = TL.MaTL AND S.MaNhaCungCap = NCC.MaNCC AND S.MaNhaXB = NXB.MaNXB";
            SqlCommand cdm = new SqlCommand(query, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvSach.AutoGenerateColumns = false;
            dtgvSach.DataSource = dt;
        }
        private void loadCategory()
        {
            SqlCommand cdm = new SqlCommand("select * from THELOAI", DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvCategory.AutoGenerateColumns = false;
            dtgvCategory.DataSource = dt;  
        }
        private void loadSupplier()
        {   
            SqlCommand cdm = new SqlCommand("select * from NHACUNGCAP", DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvSupplier.AutoGenerateColumns = false;
            dtgvSupplier.DataSource = dt;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM THELOAI";
            string dk = "";
            if (tbTKTL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadCategory();
                return;
            }
            if (tbTKTL.Text.Trim() != "")
            {
                dk += " MaTL LIKE '%" + tbTKTL.Text + "%'";
            }
            if (tbTKTL.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenTL LIKE N'%" + tbTKTL.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            SqlCommand cdm = new SqlCommand(sql, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvCategory.AutoGenerateColumns = false;
            dtgvCategory.DataSource = dt;
            
            if (dtgvCategory.Rows.Count <= 1)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCategory();
                return;
            }

        }

        public void AddCateBinding()
        {
            tbMaTheLoai.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "MaTL"));
            tbTenTheLoai.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "TenTL"));
        }

        public void AddSupplierBinding()
        {
            tbMaNCC.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "MaNCC"));
            tbTenNCC.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "TenNCC"));
        }

        private void tbTKNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SACH";
            string dk = "";
            if (tbTKSach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadBook();
                return;
            }
            if (tbTKSach.Text.Trim() != "")
            {
                dk += " MaSach LIKE '%" + tbTKSach.Text + "%'";
            }
            if (tbTKSach.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenSach LIKE N'%" + tbTKSach.Text + "%'";
            }
            if (tbTKSach.Text.Trim() != "" && dk != "")
            {
                dk += " OR TacGia LIKE N'%" + tbTKSach.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            SqlCommand cdm = new SqlCommand(sql, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvSach.AutoGenerateColumns = false;
            dtgvSach.DataSource = dt;

            if (dtgvSach.Rows.Count <= 1)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadBook();
                return;
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
        }

        private void btnTKNCC_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            string dk = "";
            if (tbTKNCC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadSupplier();
                return;
            }
            if (tbTKNCC.Text.Trim() != "")
            {
                dk += " MaNCC LIKE '%" + tbTKNCC.Text + "%'";
            }
            if (tbTKNCC.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenNCC LIKE N'%" + tbTKNCC.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            SqlCommand cdm = new SqlCommand(sql, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvSupplier.AutoGenerateColumns = false;
            dtgvSupplier.DataSource = dt;

            if (dtgvSupplier.Rows.Count <= 1)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSupplier();
                return;
            }
        }
    }
}
