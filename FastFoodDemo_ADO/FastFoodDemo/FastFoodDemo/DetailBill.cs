using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.DTO;
using FastFoodDemo.BL_Layer;
namespace FastFoodDemo
{
    public partial class DetailBill : Form
    {
        public DetailBill(HoaDon h)
        {
            InitializeComponent();
            hd = h;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        BLChiTiet_HD blCT = new BLChiTiet_HD();
        DataSet dsLay = new DataSet();
        HoaDon hd = new HoaDon();
        List<ChiTiet_HD> dsCT = new List<ChiTiet_HD>();
        private void DetailBill_Load(object sender, EventArgs e)
        {
            blCT = new BLChiTiet_HD();
            dsCT = new List<ChiTiet_HD>();
            dsLay = blCT.LoadData(hd);
            for (int i = 0; i < dsLay.Tables[0].Rows.Count; i++)
            {
                DataRow row = dsLay.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                ChiTiet_HD ct = new ChiTiet_HD()
                {
                    MaHD=int.Parse(row[0].ToString()),
                    MaSP=int.Parse(row[1].ToString()),
                    TenSP=row[2].ToString(),
                    SoLuong=int.Parse(row[3].ToString())
                };
                dsCT.Add(ct);
            }
            dgvSanPham.Rows.Clear();
            for (int i = 0; i < dsCT.Count; i++)
            {
                dgvSanPham.Rows.Add(dsCT[i].MaHD,dsCT[i].MaSP,dsCT[i].TenSP,dsCT[i].SoLuong);
            }
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
