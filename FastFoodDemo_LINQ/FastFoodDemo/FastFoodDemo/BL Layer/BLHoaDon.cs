
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FastFoodDemo.BL_Layer
{
    public class BLHoaDon
    {
        public List<HOADON> dsHoaDon()
        {
            QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
            List<HOADON> dsSP = context.HOADONs.ToList();
            return dsSP;
        }


        public bool Insert(HOADON hd, out string message)
        {
            message = "Thanh toán thành công";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                context.HOADONs.InsertOnSubmit(hd);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }

        public bool Delete(HOADON hd, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                HOADON hoadon = context.HOADONs.FirstOrDefault(x => x.MaHD == hd.MaHD);
                if (hoadon != null)
                {
                    hoadon.Ngay = hd.Ngay;
                    hoadon.Thang = hd.Thang;
                    hoadon.Nam = hd.Nam;
                    hoadon.TongGiaSP = hd.TongGiaSP;
                    hoadon.TongTien = hd.TongTien;
                    hoadon.TT_HD = hd.TT_HD;
                    context.SubmitChanges();
                    return true;
                }
                message = "Khong co gia tri";
                return false;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }

        public bool Update(HOADON hd, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                HOADON hoadon = context.HOADONs.FirstOrDefault(x => x.MaHD == hd.MaHD);
                if (hoadon != null)
                {
                    hoadon.Ngay = hd.Ngay;
                    hoadon.Thang = hd.Thang;
                    hoadon.Nam = hd.Nam;
                    hoadon.TongGiaSP = hd.TongGiaSP;
                    hoadon.TongTien = hd.TongTien;
                    hoadon.TT_HD = hd.TT_HD;
                    context.SubmitChanges();
                    return true;
                }
                message = "Khong co gia tri";
                return false;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }


    }
}
