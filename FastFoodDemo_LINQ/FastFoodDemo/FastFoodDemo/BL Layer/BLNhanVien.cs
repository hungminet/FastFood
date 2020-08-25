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
        public List<NHANVIEN> dsNhanVien()
        {
            QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
            List<NHANVIEN> dsNV = context.NHANVIENs.ToList();
            return dsNV;
        }

        public bool Insert(NHANVIEN nv, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                context.NHANVIENs.InsertOnSubmit(nv);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {

                message = e.Message;
            }
            return false;
        }

        public bool Delete(NHANVIEN nv, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                NHANVIEN nhanvien = context.NHANVIENs.FirstOrDefault(x => x.MaNV == nv.MaNV);
                if (nhanvien != null)
                {
                    nhanvien.HoTen = nv.HoTen;
                    nhanvien.CMND = nv.CMND;
                    nhanvien.GT = nv.GT;
                    nhanvien.MatKhau = nv.MatKhau;
                    nhanvien.SDT = nv.SDT;
                    nhanvien.QuanLi = nv.QuanLi;
                    nhanvien.TT_LamViec = nv.TT_LamViec;
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

        public bool Update(NHANVIEN nv, out string message)
        {
            message = "";
            try
            {
                QuanLyBanHangDataContext context = new QuanLyBanHangDataContext();
                NHANVIEN nhanvien = context.NHANVIENs.FirstOrDefault(x => x.MaNV == nv.MaNV);
                if (nhanvien != null)
                {
                    nhanvien.HoTen = nv.HoTen;
                    nhanvien.CMND = nv.CMND;
                    nhanvien.GT = nv.GT;
                    nhanvien.MatKhau = nv.MatKhau;
                    nhanvien.SDT = nv.SDT;
                    nhanvien.QuanLi = nv.QuanLi;
                    nhanvien.TT_LamViec = nv.TT_LamViec;
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
