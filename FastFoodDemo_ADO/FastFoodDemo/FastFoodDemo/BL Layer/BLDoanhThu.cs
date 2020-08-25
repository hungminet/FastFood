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
    class BLDoanhThu
    {
        DBMain dbDT;
        DataSet ds = new DataSet();
        //public List<Luong> dsLuong = new List<Luong>();
        public BLDoanhThu()
        {
            dbDT = new DBMain();
            ds = new DataSet();
        }
        public DataSet LoadData(int nam,int thang)
        {
            ds = new DataSet();
            string str = string.Format("Select * from DOANHTHU_THANG where ThangBH = {0} and NamBH = {1}", thang,nam);
            
            ds.Tables.Add(dbDT.LoadData(str));
            return ds;
        }
        public DataSet MaxDate()
        {
            ds = new DataSet();
            string str = string.Format("select max(ThangBH),max(dt.NamBH) from DOANHTHU_THANG dt where dt.NamBH = (  select max(NamBH) from DOANHTHU_THANG) ");

            ds.Tables.Add(dbDT.LoadData(str));
            return ds;
        }
        public DataSet Caculate_Revenue(int nam, int thang)
        {
            ds = new DataSet();
            string str = string.Format("select sum(TongTien) as Revenue, sum(TongGiaSP) as PrimeCost " +
                "from HOADON" +
                " group by Thang, Nam " +
                "having Thang = {0} and nam = {1}", thang, nam);
       
            ds.Tables.Add(dbDT.LoadData(str));
            return ds;
        }
        public DataSet Calculate_SumOf_Salaries(int date)
        {
            ds = new DataSet();
            string str = string.Format("Select sum(Luong) as Salary " +
                "from LUONG " +
                "group by NgayTL " +
                "having NgayTL = {0}", date);
            
            ds.Tables.Add(dbDT.LoadData(str));
            return ds;
        }
        public bool Insert(DoanhThu dthu, out string message)
        {
            bool result = false;
            string sql = string.Format("insert into DOANHTHU_THANG " +
                "values({0},{1},{2},{3},{4})", dthu.ThangBH, dthu.NamBH, dthu.DoanhThu_TH,dthu.TongGiaSP_TH,dthu.TongLuong_NV);
            result = dbDT.ExecuteNonQuery(sql, out message);
            return result;
        }
        public bool Update(DoanhThu dthu, out string message)
        {
            bool result = false;
            string sql = string.Format("update DOANHTHU_THANG set DoanhThu_TH={0}, TongGiaSP_TH={1},TongLuong_NV={2}" +
                "where ThangBH = {3} and NamBH = {4} ", dthu.DoanhThu_TH, dthu.TongGiaSP_TH, dthu.TongLuong_NV, dthu.ThangBH, dthu.NamBH);
            result = dbDT.ExecuteNonQuery(sql, out message);
            return result;
        }
    }
}
