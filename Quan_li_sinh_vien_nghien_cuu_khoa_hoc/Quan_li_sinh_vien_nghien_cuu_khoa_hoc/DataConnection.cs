using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    class DataConnection
    {
        public static string con = "Data Source=TINH-PC;Initial Catalog=quan_li_sinh_vien_NCKH;Integrated Security=True";
        public static DataSet Danhsach(string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection=new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(data);
                connection.Close();
            }
                return data;
        }
        public static Boolean ThucThi(string query)
        {
            Boolean check = true;
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
            connection.Close();
        }
        public static bool kiemtra(string query)
        {
            SqlConnection connection = new SqlConnection(con); //chuỗi kết nối
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool str = Convert.ToBoolean(dt.Rows[0][0]); //ở đây giá trị trả về chỉ là 1 bool           
            return str;
        }
        public static bool kiemtradangnhap(string taikhoan,string matkhau)
        {
            bool check = false;
            string query = "select *from dbo.TaiKhoan where tentaikhoan=@ten and matkhau=@matkhau";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ten",taikhoan);
            command.Parameters.AddWithValue("@matkhau",matkhau);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read()==true)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
            connection.Close();
        }
    }
}
