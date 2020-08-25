using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFoodDemo.DB_Layer;
using FastFoodDemo.DTO;
namespace FastFoodDemo.BL_Layer
{
    public class BLSanPham
    {
        DBSanPham dbSP;
        DataSet ds = new DataSet();
        public List<SanPham> dsSP = new List<SanPham>();
        public BLSanPham()
        {
            dbSP = new DBSanPham();
        }
        public DataSet LoadData()
        {
            string str = "Select * from SanPham where TT_Ban=1";
            ds.Tables.Add(dbSP.LoadData(str));
            return ds;
        }

        public bool Insert(SanPham sp, out string message)
        {
            bool result = false;
            string sql = "insert into SanPham(MaSP,HinhSP,TenSP,TT_Ban,GiaSP,GiaBan) " +
                "values(@ma,@hinh,@ten,@tt,@giasp,@giaban)";
            result = dbSP.ExecuteNonQuery(sql,sp, out message);
            return result;
        }

        public bool Delete(SanPham sp, out string message)
        {
            bool result;
            string sql = "update SanPham set TT_Ban=@tt where MaSP=@ma";
            result = dbSP.ExecuteNonQuery(sql,sp, out message);
            return result;
        }

        public bool Update(SanPham sp, out string message)
        {
            bool result = false;
            string sql = "update SanPham set HinhSP=@hinh,TenSP=@ten,TT_Ban=@tt,GiaSP=@giasp,GiaBan=@giaban " +
                "where MaSP=@ma";
            result = dbSP.ExecuteNonQuery(sql,sp, out message);
            return result;
        }

        public bool Reader(out string message)
        {
            bool result = false;
            dsSP = new List<SanPham>();
            string str = "Select * from SanPham where TT_Ban=1";
            result = dbSP.ExecuteReader(str, out message);
            dsSP = dbSP.dsSP;
            return result;
        }
    }
}
