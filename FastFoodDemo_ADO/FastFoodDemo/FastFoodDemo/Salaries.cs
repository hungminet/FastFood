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
    public partial class Salaries : UserControl
    {
        BLLuong bll = new BLLuong();
        BLPhanCong blPC = new BLPhanCong();
        DataSet ds;
        List<CheckedListBox> checkedLists_ABS = new List<CheckedListBox>();
        BLNhanVien blNV = new BLNhanVien();
        List<int> dsnv = new List<int>();
        public Salaries()
        {
            InitializeComponent();
            checkedLists_ABS.Add(cklb_shifts1);
            checkedLists_ABS.Add(cklb_shifts2);
            checkedLists_ABS.Add(cklb_shifts3);
            checkedLists_ABS.Add(cklb_shifts4);
        }
        List<Luong> dsluong { get; set; }
        string err;
        private List<int> GetMaNV()
        {
            blNV = new BLNhanVien();
            ds = blNV.LoadData();

            dsnv = new List<int>();
            ds = blNV.LoadData();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                dsnv.Add(int.Parse(x[0].ToString()));
            }
            return dsnv;
        }
        private void TinhLuong(int date)
        {
            //timenow = int.Parse(dtp_print.Value.ToString("yyyyMM"));
            bll = new BLLuong();
            bool a = true;
            dsluong = new List<Luong>();
            ds = bll.Calculate_salaries();
            blPC.Update(4, out string stri);//trả về hệ số sau khi tính
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                Luong salar = new Luong()
                {
                    MaNV = int.Parse(x[0].ToString()),
                    NgayTraLuong = date,
                    TienLuong = int.Parse(x[1].ToString())
                };
                //dsluong.Add(salar);
                a = bll.Insert(salar, out err);
            }
            if (!a)
                MessageBox.Show("Đã Tính Lương tháng này");
        }
        private void LoadData(int date)
        {
            bll = new BLLuong();
            ds = bll.LoadData(date);

            dsluong = new List<Luong>();

            ds = bll.LoadData(date);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                Luong salar = new Luong()
                {
                    MaNV = int.Parse(x[0].ToString()),
                    NgayTraLuong = int.Parse(dtp_cal.Value.ToString("yyyyMM")),
                    TienLuong = int.Parse(x[2].ToString())
                };
                //salar.NgayTraLuong.ToString("yyyyMM");
                // dsnv.Clear();
                dsluong.Add(salar);
                // dsnv.Add(salar.MaNV);
            }

            dgvLuong.Rows.Clear();
            // cbb_empIDs.Items.Clear();
            for (int i = 0; i < dsluong.Count; i++)
            {
                dgvLuong.Rows.Add(dsluong[i].MaNV, dsluong[i].NgayTraLuong, dsluong[i].TienLuong);
                //   cbb_empIDs.Items.Add(dsluong[i].MaNV);
            }
            dtp_cal.Format = DateTimePickerFormat.Custom;
            dtp_print.Format = DateTimePickerFormat.Custom;
            dtp_cal.CustomFormat = "MM/yyyy";
            dtp_print.CustomFormat = "MM/yyyy";
            dgvLuong.AutoResizeColumns();
        }

        private void Salaries_Load(object sender, EventArgs e)
        {
            rdb_showsalary.Checked = true;
            pn_showSalary.Visible = true;
            dsnv = GetMaNV();
            foreach (var item in dsnv)
            {
                cbb_empIDs.Items.Add(item);
            }
            this.LoadData(int.Parse(DateTime.Now.ToString("yyyyMM")));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int a = int.Parse(dtp_print.Value.ToString("yyyyMM"));
            dgvLuong.Rows.Clear();
            bll = new BLLuong();
            ds = bll.LoadData(a);
            this.LoadData(a);

            //MessageBox.Show(a);
        }
        private void LoadShifts(int id)
        {
            for (int countt = 0; countt < checkedLists_ABS.Count(); countt++)
            {
                checkedLists_ABS[countt].Items.Clear();
            }
            bll = new BLLuong();
            ds = bll.GetShifts(id);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                for (int countt = 0; countt < checkedLists_ABS.Count(); countt++)
                {
                    checkedLists_ABS[countt].Items.Add(x[0]);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_all_salar_Click(object sender, EventArgs e)
        {
            blPC = new BLPhanCong();
            int heso = 4;
            List<int> ListOfOff = new List<int>();
            int manv = int.Parse(cbb_empIDs.Text.Trim());
            List<PhanCong> pcs = new List<PhanCong>();
            for (int i = 0; i < checkedLists_ABS.Count(); i++)
            {
                foreach (int item in checkedLists_ABS[i].CheckedItems)
                {
                    //ListOfOff.Contains(item);
                    ListOfOff.Add(item);
                }
            }
            // ListOfOff = checkedLists_ABS[i].CheckedItems.OfType<int>().ToList();

            while (ListOfOff.Count != 0)
            {
                int maCa1 = ListOfOff[0];
                int count = 0;
                for (int i = 0; i < ListOfOff.Count(); i++)
                {
                    if (ListOfOff[i] == maCa1)
                    {
                        count++;

                    }

                }
                while (ListOfOff.Contains(maCa1))
                {
                    ListOfOff.Remove(maCa1);
                }

                PhanCong pc = new PhanCong();
                pc.MaNV = manv;
                pc.MaCa = maCa1;
                pc.HeSo = 4 - count;
                if (blPC.Update(pc, out string a))
                {
                    string str = string.Format("MaNV: {0}      MaCa: {1}    HeSo: {2}", pc.MaNV, pc.MaCa, pc.HeSo);
                    MessageBox.Show(str);
                }
                else
                    MessageBox.Show(a);

            }
        }

        private void cbb_empIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_empIDs.SelectedItem != null)
                LoadShifts(int.Parse(cbb_empIDs.SelectedItem.ToString()));
            else
            {
                for (int i = 0; i < checkedLists_ABS.Count(); i++)
                {
                    checkedLists_ABS[i].Items.Clear();
                }
            }
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chắn chắn tính lương? (Chỉ có thể tính được 1 lần)", "warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); ;
            if (result == DialogResult.Yes)
            {
                int date = int.Parse(dtp_cal.Value.ToString("yyyyMM"));
                this.TinhLuong(date);
                cbb_empIDs.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Không tính lương");
            }

        }

        private void cbb_weeks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cklb_shifts1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_showsalary.Checked == true)
            {
                pannel_abs.Visible = false;
                pn_showSalary.Visible = true;
            }
            else
            {
                pannel_abs.Visible = true;
                pn_showSalary.Visible = false;
            }
        }
    }
}
