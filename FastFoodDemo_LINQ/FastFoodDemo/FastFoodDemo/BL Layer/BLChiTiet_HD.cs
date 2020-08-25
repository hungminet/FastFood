
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
        public List<CHITIET_HD> dsChiTiet_HD()
        {
            QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
            List<CHITIET_HD> dsSP = context.CHITIET_HDs.ToList();
            return dsSP;
        }

        public bool Insert(CHITIET_HD ct, out string message)
        {
            message = "Thanh toán thành công";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                context.CHITIET_HDs.InsertOnSubmit(ct);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }

        public bool Delete(CHITIET_HD ct, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                CHITIET_HD chitiet = context.CHITIET_HDs.FirstOrDefault(x => x.MaHD == ct.MaHD && x.MaSP == ct.MaSP);
                if (chitiet != null)
                {
                    context.CHITIET_HDs.DeleteOnSubmit(chitiet);
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

        public bool Update(CHITIET_HD ct, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                CHITIET_HD chitiet = context.CHITIET_HDs.FirstOrDefault(x => x.MaHD == ct.MaHD && x.MaSP == ct.MaSP);
                if (chitiet != null)
                {
                    chitiet.SoLuong = ct.SoLuong;
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
