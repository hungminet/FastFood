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
    public class BLChiTiet_HD
    {
        DBMain main;
        DataSet ds = new DataSet();
        public int Max { get; set; }
        public BLChiTiet_HD()
        {
            main = new DBMain();
        }
        public DataSet LoadData(HoaDon hd)
        {
            string str = string.Format("SELECT ct.MaHD,ct.MaSP,sp.TenSP,ct.SoLuong FROM HOADON hd, CHITIET_HD ct, " +
                "SANPHAM sp WHERE hd.MaHD = ct.MaHD AND ct.MaSP = sp.MaSP AND hd.MaHD = {0}",hd.MaHD);
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }

        public bool Insert(ChiTiet_HD ct, out string message)
        {
            bool result = false;
            string str = String.Format("insert into ChiTiet_HD values({0},{1},{2})",ct.MaHD,ct.MaSP,ct.SoLuong);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }

        public bool Delete(ChiTiet_HD ct, out string message)
        {
            bool result;
            string str = String.Format("delete from ChiTiet_HD where MaHD = {0} and MaSP={1}", ct.MaHD,ct.MaSP);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }

        public bool Update(ChiTiet_HD ct, out string message)
        {
            bool result = false;
            string str = String.Format("update ChiTiet_HD set SoLuong={2} where MaHD={0} and MaSP={1}", 
                ct.MaHD,ct.MaSP,ct.SoLuong);
            result = main.ExecuteNonQuery(str, out message);
            return result;
        }
    }
}
