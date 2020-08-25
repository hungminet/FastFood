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
    public partial class DashBoard : UserControl
    {
        BLPhanCong blpc;
        DataSet dspc;
        int min;
        int max;
        public DashBoard()
        {
            InitializeComponent();
        }
        private int DateConverttoShiftID(DateTime date)
        {
            //monday = 1
            //sunday=0;
            DayOfWeek a = date.DayOfWeek;
            switch(a)
            {
                case DayOfWeek.Monday:
                    return 2;
                case DayOfWeek.Tuesday:
                    return 3;
                case DayOfWeek.Wednesday:
                    return 4;
                case DayOfWeek.Thursday:
                    return 5;
                case DayOfWeek.Friday:
                    return 6;
                case DayOfWeek.Saturday:
                    return 7;
                default:
                    return 8;

            }
        }
        private void LoadData()
        {
            List<NHANVIEN> dsNV = new List<NHANVIEN>();
            blpc = new BLPhanCong();

            int k = DateConverttoShiftID(dateTimePicker1.Value);
            dspc = blpc.GetDayShift(k * 100 + 1, k * 100 + 3);

            for (int i = 0; i < dspc.Tables[0].Rows.Count; i++)
            {
                DataRow row = dspc.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                NHANVIEN nv = new NHANVIEN()
                {
                    MaNV = int.Parse(x[1].ToString()),
                    HoTen = x[2].ToString(),
                    GT = true,
                    CMND = int.Parse(x[0].ToString()),
                    SDT = 0,
                    TT_LamViec = true,
                    MatKhau = "",
                    QuanLi = 1
                };
                dsNV.Add(nv);
            }

            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < dsNV.Count; i++)
            {
                if(dsNV[i].CMND % 100==1)
                    dgvNhanVien.Rows.Add("Morning", dsNV[i].MaNV, dsNV[i].HoTen);
                else if (dsNV[i].CMND % 100 == 2)
                    dgvNhanVien.Rows.Add("Afternoon", dsNV[i].MaNV, dsNV[i].HoTen);
                else if (dsNV[i].CMND % 100 == 3)
                    dgvNhanVien.Rows.Add("Night", dsNV[i].MaNV, dsNV[i].HoTen);
            }
            dspc.Clear();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
