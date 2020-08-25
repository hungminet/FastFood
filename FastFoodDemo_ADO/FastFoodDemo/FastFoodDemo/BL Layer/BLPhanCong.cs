using FastFoodDemo.DB_Layer;
using FastFoodDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    class BLPhanCong
    {
        DBMain main;
        DataSet ds = new DataSet();
        public BLPhanCong()
        {
            main = new DBMain();
        }
        public DataSet LoadData()
        {
            string str = string.Format("SELECT * FROM PHANCONG order by MaNV");
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }

        public DataSet GetDayShift(int day1, int day2)
        {
            string str = string.Format("select pc.MaCa, nv.MaNV, nv.HoTen " +
                "from PHANCONG pc, NHANVIEN nv " +
                "where pc.MaNV = nv.MaNV and pc.MaCa between {0} and {1} order by pc.MaCa",day1,day2);
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }

        public bool Update(PhanCong pc, out string message)
        {
            bool result = false;
            string sql = string.Format("update PHANCONG set HeSo={0}" +
                "where MaCa = {1} and MaNV ={2}",pc.HeSo,pc.MaCa,pc.MaNV);
            result = main.ExecuteNonQuery(sql, out message);
            return result;
        }
        public bool Update(int pc, out string message)
        {
            bool result = false;
            string sql = string.Format("UPDATE PHANCONG SET HeSo = {0}",pc);
            result = main.ExecuteNonQuery(sql, out message);
            return result;
        }

        public bool Update(int nv, int cafr, int cato, out string message)
        {
            bool result = false;
            string sql = string.Format("UPDATE PHANCONG SET MaCa = {0} where MaNV = {1} and MaCa = {2}", cato, nv, cafr);
            result = main.ExecuteNonQuery(sql, out message);
            return result;
        }

        public bool AddPC(int nv, int maca, out string message)
        {
            bool result = true;
            string sql = string.Format("Insert into PHANCONG values({0},{1},{2})", maca, nv, 4);
            result = main.ExecuteNonQuery(sql, out message);
            return result;
        }
    }
}
