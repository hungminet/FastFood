
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    class BLPhanCong
    {
        //DBMain main;
        DataSet ds = new DataSet();
        public BLPhanCong()
        {
            // main = new DBMain();
        }
        public bool EditPC(NHANVIEN nv, CA ca1, CA ca2)
        {
            try
            {
                QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
                PHANCONG pc1 = new PHANCONG();
                pc1.MaNV = nv.MaNV;
                pc1.MaCa = ca1.MaCa;
                pc1.HeSo = 4;
                quanLy.PHANCONGs.DeleteOnSubmit(pc1);
                quanLy.SubmitChanges();
                PHANCONG pc2 = new PHANCONG();
                pc2.MaNV = nv.MaNV;
                pc2.MaCa = ca2.MaCa;
                pc2.HeSo = 4;
                quanLy.PHANCONGs.InsertOnSubmit(pc2);
                quanLy.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditPC(NHANVIEN nv1, NHANVIEN nv2, CA ca)
        {
            try
            {
                QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
                PHANCONG pc1 = new PHANCONG();
                pc1.MaNV = nv1.MaNV;
                pc1.MaCa = ca.MaCa;
                pc1.HeSo = 4;
                quanLy.PHANCONGs.DeleteOnSubmit(pc1);
                quanLy.SubmitChanges();
                PHANCONG pc2 = new PHANCONG();
                pc2.MaNV = nv2.MaNV;
                pc2.MaCa = ca.MaCa;
                pc2.HeSo = 4;
                quanLy.PHANCONGs.InsertOnSubmit(pc2);
                quanLy.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddPC(NHANVIEN nv, CA ca)
        {
            try
            {
                QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
                PHANCONG pc = new PHANCONG();
                pc.MaNV = nv.MaNV;
                pc.MaCa = ca.MaCa;
                pc.HeSo = 4;
                quanLy.PHANCONGs.InsertOnSubmit(pc);
                quanLy.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet GetDayShift(int day1, int day2)
        {
            QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
            // quanLy.
            var que = from pc in quanLy.PHANCONGs
                      join nv in quanLy.NHANVIENs
                      on pc.MaNV equals nv.MaNV
                      where pc.MaCa >= day1
                      where pc.MaCa <= day2
                      select new { pc.MaCa, nv.MaNV, nv.HoTen };

            DataTable tablee = new DataTable();
            tablee.Columns.Add("");
            tablee.Columns.Add("");
            tablee.Columns.Add("");
            foreach (var item in que)
            {
                tablee.Rows.Add(item.MaCa, item.MaNV, item.HoTen);
            }
            ds.Tables.Add(tablee);

            return ds;
            //string str = string.Format("select pc.MaCa, nv.MaNV, nv.HoTen " +
            //    "from PHANCONG pc, NHANVIEN nv " +
            //    "where pc.MaNV = nv.MaNV and pc.MaCa between {0} and {1} order by pc.MaCa",day1,day2);
            //ds.Tables.Add(main.LoadData(str));
            //return ds;
        }

        public bool Update(PHANCONG pc, out string message)
        {
            QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
            var que = (from pcc in quanLy.PHANCONGs
                       where pcc.MaCa == pc.MaCa
                       where pcc.MaNV == pc.MaNV
                       select pcc).SingleOrDefault();

            if (que != null)
            {
                que.HeSo = pc.HeSo;
                quanLy.SubmitChanges();
                message = "Success";
                return true;
            }
            else
            {
                message = "Fail";
                return false;
            }

        }

    }
}
