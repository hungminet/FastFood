using FastFoodDemo.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFoodDemo.DTO;

namespace FastFoodDemo.BL_Layer
{
    public class BLHoaDon
    {
        DBMain main;
        DataSet ds = new DataSet();
        public int Max { get; set; }
        public BLHoaDon()
        {
            main = new DBMain();
        }
        public DataSet LoadData()
        {
            string str = "Select * from HoaDon where TT_HD=1";
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }
        public DataSet LoadData(int thang, int nam)
        {
            string str = string.Format("Select MaHD,TongTien,TongGiaSP from HoaDon where TT_HD=1 and Thang = {0} and Nam = {1}",thang,nam);
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }

        public bool Insert(HoaDon hd, out string message)
        {
            bool result = false;
            string str = String.Format("insert into HoaDon values({0},{1},{2},{3},{4},{5},{6})",hd.MaHD,hd.TongTien,
                hd.TongGiaSP,hd.Ngay,hd.Thang,hd.Nam,1);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }

        public bool Delete(HoaDon hd, out string message)
        {
            bool result;
            string str = String.Format("update HoaDon set TT_HD=0 where MaHD={0}",hd.MaHD);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }

        public bool Update(HoaDon hd, out string message)
        {
            bool result = false;
            string str = String.Format("update HoaDon set TongTien={1},TongGiaSP={2}," +
                "Ngay={3},Thang={4},Nam={5},TT_HD=1 where MaHD='{0}'", hd.MaHD,hd.TongTien,
                hd.TongGiaSP,hd.Ngay,hd.Thang,hd.Nam);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }

        public bool Reader(out string message)
        {
            bool result = false;
            string str = "Select MaHD from HoaDon group by MaHD having MaHD=max(MaHD)";
            int max;
            result = main.ExecuteReader(str,out max, out message);
            Max = max;
            return result;
        }
    }
}
