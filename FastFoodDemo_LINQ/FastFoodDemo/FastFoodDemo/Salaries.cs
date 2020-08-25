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
        List<LUONG> dsluong { get; set; }
        string err;
        private List<int> GetMaNV()
        {
            blNV = new BLNhanVien();

            List<NHANVIEN> dsnv = new List<NHANVIEN>();
            dsnv = blNV.dsNhanVien();
            List<int> dsms = new List<int>();
            foreach (var item in dsnv)
            {
                dsms.Add(item.MaNV);
            }
            return dsms;
        }
        private void TinhLuong(int date)
        {
            bll = new BLLuong();
            dsluong = new List<LUONG>();
            bll.Calculate_salaries(date);

        }
        private void LoadData(int date)
        {
            bll = new BLLuong();
            ds = bll.LoadData(date);

            dsluong = new List<LUONG>();

            ds = bll.LoadData(date);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                LUONG salar = new LUONG();
                salar.MaNV = int.Parse(x[0].ToString());
                salar.NgayTL = int.Parse(dtp_cal.Value.ToString("yyyyMM"));
                salar.Luong1 = int.Parse(x[2].ToString());
                dsluong.Add(salar);

            }

            dgvLuong.Rows.Clear();
            for (int i = 0; i < dsluong.Count; i++)
            {
                dgvLuong.Rows.Add(dsluong[i].MaNV, dsluong[i].NgayTL, dsluong[i].Luong1);
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
            List<int> shift = bll.GetShifts(id);
            for (int i = 0; i < shift.Count; i++)
            {
                for (int countt = 0; countt < checkedLists_ABS.Count(); countt++)
                {
                    checkedLists_ABS[countt].Items.Add(shift[i]);
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

            List<int> ListOfOff = new List<int>();
            int manv = int.Parse(cbb_empIDs.Text.Trim());

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

                PHANCONG pc = new PHANCONG();
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
                MessageBox.Show("Chưa tính lương");
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
