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
    public partial class Revenue : UserControl
    {
        DataSet ds_rev;
        DataSet ds_sal;
        BLDoanhThu dlDT;
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            Calculate_Rev();
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }
        private void Calculate_Rev()
        {
            dlDT = new BLDoanhThu();
            DataSet max = dlDT.MaxDate();
            int month_max = int.Parse(max.Tables[0].Rows[0][0].ToString());
            int year_max = int.Parse(max.Tables[0].Rows[0][1].ToString());
            int date_max = year_max * 100 + month_max;

            int date = int.Parse(DateTime.Now.ToString("yyyyMM"));

            if(date_max< date+1)//qua tháng mới thì mới có thể tính doanh thu tháng cũ
            {
                int month = date % 100;
                int year = date / 100;
                DoanhThu dth = new DoanhThu();
                dlDT = new BLDoanhThu();
                ds_rev = new DataSet();
                ds_sal = new DataSet();
                ds_rev = dlDT.Caculate_Revenue(year, month); //tính doanh thu dựa trên bill theo tháng
                ds_sal = dlDT.Calculate_SumOf_Salaries(date);//tính tiền lương nhân viên theo tháng
                int rev = int.Parse(ds_rev.Tables[0].Rows[0][0].ToString());
                int primecost = int.Parse(ds_rev.Tables[0].Rows[0][1].ToString());
                int sal = int.Parse(ds_sal.Tables[0].Rows[0][0].ToString());
                dth.ThangBH = month;
                dth.NamBH = year;
                dth.TongGiaSP_TH = primecost;
                dth.TongLuong_NV = sal;
                dth.DoanhThu_TH = rev;
                dlDT.Insert(dth,out string a);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int val = int.Parse(dateTimePicker1.Value.ToString("yyyyMM"));
            int month = val % 100;
            int year = val / 100;

            GetRevenueByDateTableAdapter.Fill(QLBHDataSet.GetRevenueByDate, month, year);
            reportViewer1.RefreshReport();
        }
    }
}
