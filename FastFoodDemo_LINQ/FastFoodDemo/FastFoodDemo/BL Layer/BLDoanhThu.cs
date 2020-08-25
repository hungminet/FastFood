
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    internal class OrderViewHD : HOADON { }
    class BLDoanhThu
    {
        //DBMain dbDT;
        DataSet ds = new DataSet();
        //public List<Luong> dsLuong = new List<Luong>();
        public BLDoanhThu()
        {
           // dbDT = new DBMain();
            ds = new DataSet();
        }
        //public DataSet LoadData(int nam,int thang)
        //{
        //    ds = new DataSet();
        //    string str = string.Format("Select * from DOANHTHU_THANG where ThangBH = {0} and NamBH = {1}", thang,nam);
            
        //    ds.Tables.Add(dbDT.LoadData(str));
        //    return ds;
        //}
        public List<int> MaxDate()
        {
            List<int> list = new List<int>();
            QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
            var que = (from dth in quanLy.DOANHTHU_THANGs
                      select dth).OrderByDescending(i=>i.NamBH).FirstOrDefault();
            

          //  DOANHTHU_THANG dt_maxnam = que.Aggregate((val1, val2) => val1.NamBH > val2.NamBH ? val1 : val2);
            var que1 = (from dth in quanLy.DOANHTHU_THANGs
                       where dth.NamBH == que.NamBH
                       select dth).OrderByDescending(i=>i.ThangBH).FirstOrDefault();

           // DOANHTHU_THANG dt_max = que.Aggregate((val1, val2) => val1.ThangBH > val2.ThangBH ? val1 : val2);

            list.Add(que1.ThangBH);
            list.Add(que1.NamBH);
            //ds = new DataSet();
            //DataTable tablee = new DataTable();
            //tablee.Rows.Add("Max Month");
            //tablee.Rows.Add("Max Year");
            //tablee.Rows.Add(dt_max.ThangBH, dt_max.NamBH);
            //ds.Tables.Add(tablee);
            return list;
        }
        public DataSet Caculate_Revenue(int nam, int thang)
        {
            //ds = new DataSet();
            //string str = string.Format("select sum(TongTien) as Revenue, sum(TongGiaSP) as PrimeCost " +
            //    "from HOADON" +
            //    " group by Thang, Nam " +
            //    "having Thang = {0} and nam = {1}", thang, nam);

            //ds.Tables.Add(dbDT.LoadData(str));
            //return ds;
            ds = new DataSet();
            QuanLyBanHangDataContext quanly = new QuanLyBanHangDataContext();
            var que = (from hd in quanly.HOADONs
                       where hd.Thang == thang
                       where hd.Nam == nam
                       select hd);

            var que2 = (from hd_by_my in que
                       group hd_by_my by new
                       {
                           hd_by_my.Thang,
                           hd_by_my.Nam
                       } into somenew
                       select new
                       {
                           TongTien = somenew.Sum(x => x.TongTien),
                           TongGiaSP = somenew.Sum(y => y.TongGiaSP)
                       }).SingleOrDefault();
            DataTable tb = new DataTable();
            tb.Columns.Add("Tong Tien");
            tb.Columns.Add("Von");
            tb.Rows.Add(que2.TongTien, que2.TongGiaSP);
            ds.Tables.Add(tb);
            return ds;
        }
        public DataSet Calculate_SumOf_Salaries(int date)
        {
            ds = new DataSet();
            //string str = string.Format("Select sum(Luong) as Salary " +
            //    "from LUONG " +
            //    "group by NgayTL " +
            //    "having NgayTL = {0}", date);

            //ds.Tables.Add(dbDT.LoadData(str));
            QuanLyBanHangDataContext quanly = new QuanLyBanHangDataContext();
            var que = (from luong in quanly.LUONGs
                       where luong.NgayTL == date

                       select luong);

            var que2 = (from lg_by_my in que
                        group lg_by_my by new
                        {
                            lg_by_my.NgayTL
                        } into somenew
                        select new
                        {
                            TongLuong = somenew.Sum(y => y.Luong1)
                        }).SingleOrDefault();
            DataTable tb = new DataTable();
            tb.Columns.Add("Tong Tien Luong");
            tb.Rows.Add(que2.TongLuong);
            ds.Tables.Add(tb);
            return ds;
        }
        public bool Insert(DOANHTHU_THANG dthu, out string message)
        {
            try
            {
                QuanLyBanHangDataContext quanly = new QuanLyBanHangDataContext();
                DOANHTHU_THANG dtt = new DOANHTHU_THANG();
                dtt.NamBH = dthu.NamBH;
                dtt.ThangBH = dthu.ThangBH;
                dtt.TongGiaSP_TH = dthu.TongGiaSP_TH;
                dtt.TongLuong_NV = dthu.TongLuong_NV;
                dtt.DoanhThu_TH = dthu.DoanhThu_TH;
                quanly.DOANHTHU_THANGs.InsertOnSubmit(dtt);
                quanly.SubmitChanges();
                message = "SUCCESS";
                return true;
            }
            catch
            {
                message = "FAIL";
                return false;
            }

        }
        //public bool Update(DoanhThu dthu, out string message)
        //{
        //    bool result = false;
        //    string sql = string.Format("update DOANHTHU_THANG set DoanhThu_TH={0}, TongGiaSP_TH={1},TongLuong_NV={2}" +
        //        "where ThangBH = {3} and NamBH = {4} ", dthu.DoanhThu_TH, dthu.TongGiaSP_TH, dthu.TongLuong_NV, dthu.ThangBH, dthu.NamBH);
        //    result = dbDT.ExecuteNonQuery(sql, out message);
        //    return result;
        //}
    }
}
