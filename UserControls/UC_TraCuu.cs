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
    public partial class UC_TraCuu : UserControl
    {
        public UC_TraCuu()
        {
            InitializeComponent();
        }

        private void tabQD_Click(object sender, EventArgs e)
        {

        }
        private void loadBook()
        {
            string query = "SELECT S.MaSach, S.TenSach, S.TacGia, NCC.TenNCC, NXB.TenNXB, TL.TenTL, S.GiaNhap, S.GiaBan, S.DonViTinh FROM SACH S, NHAXUATBAN NXB, NHACUNGCAP NCC, THELOAI TL WHERE S.MaTheLoai = TL.MaTL AND S.MaNhaCungCap = NCC.MaNCC AND S.MaNhaXB = NXB.MaNXB; ";
            SqlCommand cdm = new SqlCommand(query, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvTraCuuSach.AutoGenerateColumns = false;
            dtgvTraCuuSach.DataSource = dt;
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TIMKIEMSACH";
            string dk = "";
            if (tbNhapSachTraCuu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbNhapSachTraCuu.Text.Trim() != "")
            {
                dk += " MaSach LIKE '%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (tbNhapSachTraCuu.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenSach LIKE N'%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (tbNhapSachTraCuu.Text.Trim() != "" && dk != "")
            {
                dk += " OR TacGia LIKE N'%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (tbNhapSachTraCuu.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenNCC LIKE N'%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (tbNhapSachTraCuu.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenNXB LIKE N'%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (tbNhapSachTraCuu.Text.Trim() != "" && dk != "")
            {
                dk += " OR TenTL LIKE N'%" + tbNhapSachTraCuu.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            SqlCommand cdm = new SqlCommand(sql, DAO.functionconnect.conn);
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvTraCuuSach.AutoGenerateColumns = false;
            dtgvTraCuuSach.DataSource = dt;
            if (dtgvTraCuuSach.Rows.Count <= 1)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
