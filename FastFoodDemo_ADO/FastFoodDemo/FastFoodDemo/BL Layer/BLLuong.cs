using FastFoodDemo.DB_Layer;
using FastFoodDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    class BLLuong
    {
        DBMain dbLuong;
        DataSet ds = new DataSet();
        public List<Luong> dsLuong = new List<Luong>();
        public BLLuong()
        {
            dbLuong = new DBMain();
        }
        public DataSet LoadData(int date)
        {
            string str = string.Format("Select * from LUONG where NgayTL = {0}",date);
            ds.Tables.Add(dbLuong.LoadData(str));
            return ds;
        }
        public DataSet GetShifts(int id)
        {
            string str = string.Format("select ca.MaCa " +
                "from CA ca inner join PHANCONG pc on ca.MaCa = pc.MaCa" +
                " where pc.MaNV={0}",id);
            ds.Tables.Add(dbLuong.LoadData(str));
            return ds;
        }


        public DataSet GetEmplID()
        {
            string str = "Select MaNV from LUONG";
            ds.Tables.Add(dbLuong.LoadData(str));
            return ds;
        }
        public DataSet Calculate_salaries()
        {
            string str = "select temp.MaNV,sum(temp.TIENLUONG) as LUONG " +
                "from (select PHANCONG.MaNV, PHANCONG.HeSo*CA.LuongCa as TIENLUONG " +
                    "from CA,PHANCONG " +
                    "where CA.MaCa=PHANCONG.MaCa ) temp " +
                "group by temp.MaNV";
            ds.Tables.Add(dbLuong.LoadData(str));
            return ds;
        }
        public bool Insert(Luong salar, out string message)
        {
            bool result = false;
            string sql = string.Format("insert into LUONG " +
                "values({0},{1},{2})", salar.MaNV, salar.NgayTraLuong, salar.TienLuong);
            result = dbLuong.ExecuteNonQuery(sql, out message);
            return result;
        }
        public bool Update(Luong salar, out string message)
        {
            bool result = false;
            string sql = string.Format("update LUONG set Luong={2} "+
                "where MaNV={0} and NgayTL = '{1}'", salar.MaNV, salar.NgayTraLuong, salar.TienLuong);
            result = dbLuong.ExecuteNonQuery(sql, out message);
            return result;
        }



    }
}
