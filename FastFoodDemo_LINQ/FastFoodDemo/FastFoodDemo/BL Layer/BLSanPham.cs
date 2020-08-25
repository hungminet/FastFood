using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FastFoodDemo.BL_Layer
{
    public class BLSanPham
    {
        public List<SANPHAM> dsSanPham()
        {
            QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
            List<SANPHAM> dsSP = context.SANPHAMs.ToList();
            return dsSP;
        }

        public bool Insert(SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                context.SANPHAMs.InsertOnSubmit(sp);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }

        public bool Delete(SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                SANPHAM sanpham = context.SANPHAMs.FirstOrDefault(x => x.MaSP == sp.MaSP);
                if (sanpham != null)
                {
                    sanpham.TenSP = sp.TenSP;
                    sanpham.HinhSP = sp.HinhSP;
                    sanpham.GiaSP = sp.GiaSP;
                    sanpham.GiaBan = sp.GiaBan;
                    sanpham.TT_Ban = sp.TT_Ban;
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

        public bool Update(SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                SANPHAM sanpham = context.SANPHAMs.FirstOrDefault(x => x.MaSP == sp.MaSP);
                if(sanpham!=null)
                {
                    sanpham.TenSP = sp.TenSP;
                    sanpham.HinhSP = sp.HinhSP;
                    sanpham.GiaSP = sp.GiaSP;
                    sanpham.GiaBan = sp.GiaBan;
                    sanpham.TT_Ban = sp.TT_Ban;
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
