using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using FastFoodDemo.DTO;
namespace FastFoodDemo.DB_Layer
{
    public class DBSanPham
    {
        string strCon = "Data Source = (local)" +
                   ";Initial Catalog = QLBH;" +
                   "Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        SqlCommand command = null;
        public List<SanPham> dsSP = new List<SanPham>();
        public DBSanPham()
        {
            conn = new SqlConnection(strCon);
            command = new SqlCommand();
            command.Connection = conn;
        }

        public DataTable LoadData(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(strSQL, conn);
            adapter.Fill(dt);
            return dt;
        }

        public byte[] ImageByte(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        public bool ExecuteNonQuery(string commandText,SanPham sp, out string message)
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = commandText;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = sp.MaSP;
                command.Parameters.Add("@hinh", SqlDbType.Image).Value = ImageByte(sp.HinhSP);
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sp.TenSP;
                command.Parameters.Add("@tt", SqlDbType.Bit).Value = sp.TT_Ban;
                command.Parameters.Add("@giasp", SqlDbType.Int).Value = sp.GiaSP;
                command.Parameters.Add("@giaban", SqlDbType.Int).Value = sp.GiaBan;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    message = "Thực hiện thành công";
                    result = true;
                }
                else
                    message = "Thực hiện thất bại";
                conn.Close();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
            }
            return result;
        }

        
        public Image ConvertImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b, 0, b.Length);
            ms.Write(b, 0, b.Length);
            return Image.FromStream(ms, true);
        }


        //Phải gọi hàm này tm,-->nếu không list sẽ k có nội dung
        public bool ExecuteReader(string commandText, out string message) 
        {
            message = null;
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = commandText;
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    SanPham sp = new SanPham();
                    sp.MaSP = reader.GetInt32(0);
                    sp.HinhSP = Image.FromStream(reader.GetStream(1));
                    sp.TenSP = reader.GetString(2);
                    sp.TT_Ban = reader.GetBoolean(3);
                    sp.GiaSP = reader.GetInt32(4);
                    sp.GiaBan = reader.GetInt32(5);
                    dsSP.Add(sp);
                }
                result = true;
                message = dsSP.Count.ToString();
                reader.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
            }
            return result;
        }
    }
}
