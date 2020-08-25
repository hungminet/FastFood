using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.DTO
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public Image HinhSP { get; set; }
        public string TenSP { get; set; }
        public bool TT_Ban { get; set; }
        public int GiaSP { get; set; }
        public int GiaBan { get; set; }
    }
}
