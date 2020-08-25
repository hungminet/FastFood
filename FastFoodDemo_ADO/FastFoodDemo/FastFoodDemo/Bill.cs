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
using FastFoodDemo.DTO;
namespace FastFoodDemo
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
        }


        BLHoaDon blHD;
        DataSet ds = new DataSet();
        List<HoaDon> dsHD = new List<HoaDon>();

        BLChiTiet_HD blCT = new BLChiTiet_HD();
        DataSet dsLay = new DataSet();
        HoaDon hd = new HoaDon();
        List<ChiTiet_HD> dsCT = new List<ChiTiet_HD>();

        private void LoadCT(HoaDon hd)
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
                    MaHD = int.Parse(row[0].ToString()),
                    MaSP = int.Parse(row[1].ToString()),
                    TenSP = row[2].ToString(),
                    SoLuong = int.Parse(row[3].ToString())
                };
                dsCT.Add(ct);
            }
            dgvSanPham.Rows.Clear();
            lblMa.Visible = true;
            labelMa.Visible = true;
            lblMa.Text = hd.MaHD.ToString();
            for (int i = 0; i < dsCT.Count; i++)
            {
                dgvSanPham.Rows.Add(dsCT[i].MaHD, dsCT[i].MaSP, dsCT[i].TenSP, dsCT[i].SoLuong);
            }
        }

        private void LoadData()
        {
            blHD = new BLHoaDon();
            dsHD = new List<HoaDon>();
            ds = blHD.LoadData();
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                HoaDon hd = new HoaDon()
                {
                    MaHD = int.Parse(x[0].ToString()),
                    TongTien = int.Parse(x[1].ToString()),
                    TongGiaSP = int.Parse(x[2].ToString()),
                    Ngay = int.Parse(x[3].ToString()),
                    Thang = int.Parse(x[4].ToString()),
                    Nam = int.Parse(x[5].ToString()),
                    TT_HD = bool.Parse(x[6].ToString())
                };
                dsHD.Add(hd);
            }

            dgvHoaDon.Rows.Clear();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].TT_HD == true)
                    dgvHoaDon.Rows.Add(dsHD[i].MaHD, dsHD[i].TongTien,dsHD[i].TongGiaSP,dsHD[i].Ngay,dsHD[i].Thang,dsHD[i].Nam,dsHD[i].TT_HD);
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
            if(rowselect>=0&&rowselect<dgvHoaDon.Rows.Count-2)
            {
                for(int i=0; i<dsHD.Count;i++)
                {
                    if(dsHD[i].MaHD.ToString()==dgvHoaDon.Rows[rowselect].Cells[0].Value.ToString())
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
            for(int i=0; i<dsHD.Count; i++)
            {
                if(dsHD[i].Ngay==dtpFind.Value.Day&&dsHD[i].Thang==dtpFind.Value.Month&&dsHD[i].Nam==dtpFind.Value.Year&& dsHD[i].TT_HD == true)
                    dgvHoaDon.Rows.Add(dsHD[i].MaHD, dsHD[i].TongTien, dsHD[i].TongGiaSP, dsHD[i].Ngay, dsHD[i].Thang, dsHD[i].Nam, dsHD[i].TT_HD);
            }
        }

        private void lblBill_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
