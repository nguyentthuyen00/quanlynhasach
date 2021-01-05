using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NSMoonLight.DAO
{
    class functionconnect
    {
        public static SqlConnection conn = null;
        //khai bao doi tuong ket noi
        public static void Connect()
        {
            conn = new SqlConnection(DTO.connectionstring.connstring);
            conn.Open();//Mo ket noi
            //kiem tra ket noi
            if (conn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối dữ liệu thành công!");
            else MessageBox.Show("Không thể kết nối với dữ liệu !");
        }

        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close(); //Dong ket noi
                conn.Dispose(); //Giai phong tai nguyen
                conn = null;
            }
        }
    }
}
