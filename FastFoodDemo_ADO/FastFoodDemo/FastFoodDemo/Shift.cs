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
    public partial class Shift : UserControl
    {
        bool add;
        public Shift()
        {
            InitializeComponent();
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            this.LoadEmployeeID();
            this.LoadShift();
            this.LoadToShift();
            pn_toshift.Enabled = true;
            pn_em_shift.Enabled = false;
            this.add = true;
        }

        private void LoadEmployeeID()
        {
            cbb_emp_ID.Items.Clear();
            BLNhanVien blNV = new BLNhanVien();
            List<NhanVien> dsNV = new List<NhanVien>();

            DataSet ds = new DataSet();
            //blNV = new BLNhanVien();
            ds = blNV.LoadData();

            //dsNV = new List<NhanVien>();
            ds = blNV.LoadData();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                NhanVien nv = new NhanVien()
                {
                    MaNV = int.Parse(x[0].ToString()),
                    HoTen = x[1].ToString(),
                    GT = bool.Parse(x[2].ToString()),
                    CMND = int.Parse(x[3].ToString()),
                    SDT = int.Parse(x[4].ToString()),
                    TT_LamViec = bool.Parse(x[5].ToString()),
                    MatKhau = x[6].ToString(),
                    QuanLi = int.Parse(x[7].ToString())
                };
                dsNV.Add(nv);
            }


            //dsnv = blnv.dsNhanVien();
            foreach (var item in dsNV)
            {
                if (item.TT_LamViec == true)
                    cbb_emp_ID.Items.Add(item.MaNV.ToString());
            }
            cbb_emp_ID.SelectedIndex = 0;
            rdb_ADD_SHIFT.Checked = true;
            //pn_toshift.Enabled = true;

        }

        private void LoadShift()
        {
            //BLPhanCong blpc = new BLPhanCong();
            cbb_shift.Items.Clear();
            int id = int.Parse(cbb_emp_ID.SelectedItem.ToString());
            BLLuong bll = new BLLuong();
            //DataSet ds = bll.GetShifts(id);

            bll = new BLLuong();
            DataSet ds = bll.GetShifts(id);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                cbb_shift.Items.Add(x[0]);
            }
        }
        private void LoadToShift()
        {
            BLCa blca = new BLCa();
            cbb_to_shift.Items.Clear();
            //List<Ca> dsca = new List<Ca>();
            DataSet dsca = blca.LoadShift();

            //foreach (var item in dsca)
            //{
            //    cbb_to_shift.Items.Add(item.MaCa.ToString());
            //}

            for (int i = 0; i < dsca.Tables[0].Rows.Count; i++)
            {
                DataRow row = dsca.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                cbb_to_shift.Items.Add(x[0]);
            }
        }
        private void s(object sender, PaintEventArgs e)
        {

        }

        private void rdb_ADD_SHIFT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ADD_SHIFT.Checked)
            {
                this.add = true;

                pn_em_shift.Enabled = false;
            }
            else
            {
                this.add = false;
                pn_em_shift.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.add)
            {
                BLPhanCong blpc = new BLPhanCong();
                BLNhanVien blnv = new BLNhanVien();
                BLCa blca = new BLCa();
                NhanVien nv = new NhanVien();
                int manv =  int.Parse(cbb_emp_ID.SelectedItem.ToString());
                int maca = int.Parse(cbb_to_shift.SelectedItem.ToString());
                if (blpc.AddPC(manv, maca, out string err))
                {
                    MessageBox.Show("SUCCESS!");
                }
                else
                {
                    MessageBox.Show("FAIL ",err);
                }
            }
            else
            {
                BLPhanCong blpc = new BLPhanCong();
                BLNhanVien blnv = new BLNhanVien();

                int TOcaa;
                int Frcaa;
                int nv;


                
                nv = int.Parse(cbb_emp_ID.SelectedItem.ToString());
                TOcaa = int.Parse(cbb_to_shift.SelectedItem.ToString());
                Frcaa = int.Parse(cbb_shift.SelectedItem.ToString());
                if (blpc.Update(nv, Frcaa, TOcaa, out string err))
                {
                    MessageBox.Show("SUCCESS!");
                }
                else
                {
                    MessageBox.Show(err);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbb_emp_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadShift();
            this.LoadToShift();
        }
    }
}
