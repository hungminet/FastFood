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
            BLNhanVien blnv = new BLNhanVien();
            List<NHANVIEN> dsnv = new List<NHANVIEN>();
            dsnv = blnv.dsNhanVien();
            foreach (var item in dsnv)
            {
                if(item.TT_LamViec==true)
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
            List<int> shift = bll.GetShifts(id);
            foreach (int item in shift)
            {
                cbb_shift.Items.Add(item);
            }
        }
        private void LoadToShift()
        {
            BLCa blca = new BLCa();
            cbb_to_shift.Items.Clear();
            List<CA> dsca = new List<CA>();
            dsca = blca.LoadShift();
            foreach (var item in dsca)
            {
                cbb_to_shift.Items.Add(item.MaCa.ToString());
            }
        }
        private void s(object sender, PaintEventArgs e)
        {

        }

        private void rdb_ADD_SHIFT_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_ADD_SHIFT.Checked)
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
            if(this.add)
            {
                BLPhanCong blpc = new BLPhanCong();
                BLNhanVien blnv = new BLNhanVien();
                BLCa blca = new BLCa();
                CA caa = new CA();
                List<CA> dsca = new List<CA>();
                List<NHANVIEN> dsnv = new List<NHANVIEN>();
                dsnv = blnv.dsNhanVien();
                dsca = blca.LoadShift();
                NHANVIEN nv = new NHANVIEN();
                nv = dsnv.Find(x => (x.MaNV == int.Parse(cbb_emp_ID.SelectedItem.ToString())));
                caa = dsca.Find(x => (x.MaCa == int.Parse(cbb_to_shift.SelectedItem.ToString())));
                if(blpc.AddPC(nv,caa))
                {
                    MessageBox.Show("SUCCESS!");
                }    
                else
                {
                    MessageBox.Show("FAIL");
                }    
            }
            else
            {
                BLPhanCong blpc = new BLPhanCong();
                BLNhanVien blnv = new BLNhanVien();
                BLCa blca = new BLCa();
                CA TOcaa = new CA();
                CA Frcaa = new CA();
                List<CA> dsca = new List<CA>();
                List<NHANVIEN> dsnv = new List<NHANVIEN>();
                dsnv = blnv.dsNhanVien();
                dsca = blca.LoadShift();
                NHANVIEN nv = new NHANVIEN();
                nv = dsnv.Find(x => (x.MaNV == int.Parse(cbb_emp_ID.SelectedItem.ToString())));
                TOcaa = dsca.Find(x => (x.MaCa == int.Parse(cbb_to_shift.SelectedItem.ToString())));
                Frcaa = dsca.Find(x => (x.MaCa == int.Parse(cbb_shift.SelectedItem.ToString())));
                if (blpc.EditPC(nv, Frcaa, TOcaa))
                {
                    MessageBox.Show("SUCCESS!");
                }
                else
                {
                    MessageBox.Show("FAIL");
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
