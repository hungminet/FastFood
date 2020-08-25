
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.BL_Layer
{
    internal class OrderView : LUONG { }
    class BLLuong
    {
        // DBMain dbLuong;
        DataSet ds = new DataSet();
        //public List<Luong> dsLuong = new List<Luong>();
        public BLLuong()
        {
            // dbLuong = new DBMain();
        }
        public DataSet LoadData(int date)
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var que = (from a in qlBH.LUONGs
                       where a.NgayTL == date
                       select a);
            DataTable tablee = new DataTable();
            tablee.Columns.Add("");
            tablee.Columns.Add("");
            tablee.Columns.Add("");
            foreach (LUONG item in que)
            {
                tablee.Rows.Add(item.MaNV, item.NgayTL, item.Luong1);
            }
            ds.Tables.Add(tablee);

            return ds;
        }

        public List<int> GetShifts(int id)
        {
            //DataSet ds = new DataSet();
            List<int> shift = new List<int>();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var query = from cca in qlBH.CAs
                        join ppc in qlBH.PHANCONGs on cca.MaCa equals ppc.MaCa
                        where ppc.MaNV == id

                        select ppc.MaCa;
            foreach (var item in query)
            {
                shift.Add(item);
            }
            return shift;
        }
        //public DataSet GetShifts(int id)
        //{
        //    string str = string.Format("select ca.MaCa " +
        //        "from CA ca inner join PHANCONG pc on ca.MaCa = pc.MaCa" +
        //        " where pc.MaNV={0}",id);
        //    ds.Tables.Add(dbLuong.LoadData(str));
        //    return ds;
        //}

        public void Calculate_salaries(int date)
        {
            QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
            List<LUONG> dsLuong = new List<LUONG>();
            LUONG luong = new LUONG();


            try
            {
                var phancong = (from pc in quanLy.PHANCONGs
                                join ca in quanLy.CAs on pc.MaCa equals ca.MaCa
                                select new OrderView
                                {
                                    MaNV = pc.MaNV,
                                    NgayTL = date,
                                    Luong1 = pc.HeSo * ca.LuongCa
                                }
                )
                .GroupBy(pc => pc.MaNV).AsEnumerable().Select(g => new OrderView
                {
                    MaNV = g.Key,
                    NgayTL = date,
                    Luong1 = g.Sum(x => x.Luong1)
                });
                List<LUONG> dsl = phancong.Cast<LUONG>().ToList();

                foreach (LUONG item in dsl)
                {

                    LUONG luongg = new LUONG();
                    luongg.MaNV = item.MaNV;
                    luongg.NgayTL = item.NgayTL;
                    luongg.Luong1 = item.Luong1;
                    quanLy.LUONGs.InsertOnSubmit(luongg);
                    quanLy.SubmitChanges();




                }
                MessageBox.Show("SUCCESS");
            }

            catch
            {
                MessageBox.Show("Đã tính lương tháng này");
            }
            foreach (var item in quanLy.PHANCONGs)
            {
                item.HeSo = 4;
            }
        }

    }
}
