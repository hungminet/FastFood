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
    class BLNhanVien
    {
        DBMain dbNV;
        public int Max { get; set; }
        DataSet ds = new DataSet();
        public List<NhanVien> dsNV = new List<NhanVien>();
        public BLNhanVien()
        {
            dbNV = new DBMain();
        }
        public DataSet LoadData()
        {
            string str = "Select * from NhanVien where TT_LamViec=1";
            ds.Tables.Add(dbNV.LoadData(str));
            return ds;
        }

        public bool Insert(NhanVien nv, out string message)
        {
            bool result = false;
            string sql = string.Format("insert into NhanVien(MaNV,HoTen,GT,CMND,SDT,TT_LamViec,MatKhau,QuanLi) " +
                "values({0},N'{1}','{2}',{3},{4},1,'{5}',{6})",nv.MaNV,nv.HoTen,nv.GT,nv.CMND,nv.SDT,nv.MatKhau,nv.QuanLi);
            result = dbNV.ExecuteNonQuery(sql, out message);
            return result;
        }

        public bool Delete(NhanVien nv, out string message)
        {
            bool result;
            string sql = string.Format("update NhanVien set TT_LamViec=0 where MaNV={0}",nv.MaNV);
            result = dbNV.ExecuteNonQuery(sql, out message);
            return result;
        }

        public bool Update(NhanVien nv, out string message)
        {
            bool result = false;
            string sql = string.Format("update NhanVien set HoTen=N'{1}',GT='{2}',CMND={3},SDT={4},TT_LamViec=1,MatKhau='{5}',QuanLi={6} " +
                "where MaNV={0}",nv.MaNV, nv.HoTen, nv.GT, nv.CMND, nv.SDT, nv.MatKhau,nv.QuanLi);
            result = dbNV.ExecuteNonQuery(sql, out message);
            return result;
        }

        public bool Reader(out string message)
        {
            bool result = false;
            string str = "Select MaNV from NhanVien group by MaNV having MaNV=max(MaNV)";
            int max;
            result = dbNV.ExecuteReader(str, out max, out message);
            Max = max;
            return result;
        }

    }
}
