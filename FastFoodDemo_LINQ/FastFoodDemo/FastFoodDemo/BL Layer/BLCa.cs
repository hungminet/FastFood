//using FastFoodDemo.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    class BLCa
    {
        // DBMain main;
        //DataSet ds = new DataSet();

        public BLCa()
        {
            //main = new DBMain();
        }
        public List<CA> LoadShift()
        {
            QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
            return quanLy.CAs.ToList();
        }
        public bool EditShift(CA ca, int luong)
        {
            try
            {
                QuanLyBanHangDataContext quanLy = new QuanLyBanHangDataContext();
                var que = (from caaa in quanLy.CAs
                           where caaa.MaCa == ca.MaCa
                           select caaa).SingleOrDefault();
                if (que != null)
                {
                    que.LuongCa = luong;
                    quanLy.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
