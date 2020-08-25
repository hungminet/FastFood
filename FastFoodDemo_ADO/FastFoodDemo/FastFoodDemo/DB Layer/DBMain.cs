using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.DB_Layer
{
    public class DBMain
    {
        string strCon = "Data Source = (local)" +
                   ";Initial Catalog = QLBH;" +
                   "Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        SqlCommand command = null;

        public DBMain()
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

        public bool ExecuteNonQuery(string commandText, out string message)
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = commandText;
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

        public bool ExecuteReader(string commandText,out int max, out string message)
        {
            message = null;
            bool result = false;
            max = 0;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = commandText;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    max = reader.GetInt32(0);
                }
                result = true;
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
