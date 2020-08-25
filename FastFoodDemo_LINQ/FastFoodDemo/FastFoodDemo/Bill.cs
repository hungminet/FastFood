using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.BL_Layer;

namespace FastFoodDemo
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
        }


        BLHoaDon blHD;
        List<HOADON> dsHD = new List<HOADON>();
        BLSanPham blSP = new BLSanPham();
        BLChiTiet_HD blCT = new BLChiTiet_HD();
        List<CHITIET_HD> dsCT = new List<CHITIET_HD>();
        List<SANPHAM> dsSP = new List<SANPHAM>();

        private void LoadCT(HOADON hd)
        {
            blCT = new BLChiTiet_HD();
            dsCT = blCT.dsChiTiet_HD();
            dsSP = blSP.dsSanPham();
            dgvSanPham.Rows.Clear();
            lblMa.Visible = true;
            labelMa.Visible = true;
            lblMa.Text = hd.MaHD.ToString();
            for (int i = 0; i < dsCT.Count; i++)
            {
                string TenSP = dsSP.Find(x => x.MaSP == dsCT[i].MaSP).TenSP;
               
                dgvSanPham.Rows.Add(dsCT[i].MaHD, dsCT[i].MaSP, TenSP, dsCT[i].SoLuong);

            }
        }

        private void LoadData()
        {
            blHD = new BLHoaDon();
            dsHD = blHD.dsHoaDon();

            dgvHoaDon.Rows.Clear();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].TT_HD == true)
                    dgvHoaDon.Rows.Add(dsHD[i].MaHD, dsHD[i].TongTien, dsHD[i].TongGiaSP, dsHD[i].Ngay, dsHD[i].Thang, dsHD[i].Nam, dsHD[i].TT_HD);
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dsHD.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsHD.Count; i++)
                {
                    if (dsHD[i].MaHD == (int)(dgvHoaDon.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string message;
                    dsHD[vt].TT_HD = false;
                    bool result = blHD.Delete(dsHD[vt], out message);
                    if (result == false)
                        MessageBox.Show(message);
                    LoadData();
                }
            }
        }

        int rowselect = 0;
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
            if (rowselect >= 0 && rowselect < dgvHoaDon.Rows.Count - 1)
            {
                for (int i = 0; i < dsHD.Count; i++)
                {
                    if (dsHD[i].MaHD.ToString() == dgvHoaDon.Rows[rowselect].Cells[0].Value.ToString())
                    {
                        dgvSanPham.Visible = true;
                        LoadCT(dsHD[i]);
                    }
                }
            }
        }

        private void dtpFind_ValueChanged(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].Ngay == dtpFind.Value.Day && dsHD[i].Thang == dtpFind.Value.Month && dsHD[i].Nam == dtpFind.Value.Year&& dsHD[i].TT_HD == true)
                    dgvHoaDon.Rows.Add(dsHD[i].MaHD, dsHD[i].TongTien, dsHD[i].TongGiaSP, dsHD[i].Ngay, dsHD[i].Thang, dsHD[i].Nam, dsHD[i].TT_HD);
            }
        }

        private void lblBill_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
