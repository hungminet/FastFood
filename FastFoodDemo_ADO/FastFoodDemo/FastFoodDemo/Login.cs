using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.DTO;
using FastFoodDemo.BL_Layer;
namespace FastFoodDemo
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        BLNhanVien blNV;
        DataSet ds;
        private int Ma;
        private string MK;
        public int MaNV 
        {
            get { return Ma; }
        }
        
        public string MatKhau 
        {
            get { return MK; }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            blNV = new BLNhanVien();
            ds = blNV.LoadData();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool kq = int.TryParse(txtMaNV.Text, out Num);
            if (kq == false)
                errorProvider1.SetError(txtMaNV, "Nhập Username không chính xác");
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                if (txtMaNV.Text == row[0].ToString() && txtMatKhau.Text == row[6].ToString()&&int.Parse(row[7].ToString())>0&&bool.Parse(row[5].ToString()))
                {
                    Ma= int.Parse(txtMaNV.Text);
                    MK= txtMatKhau.Text;
                    txtMaNV.Text = "Username";
                    txtMatKhau.PasswordChar = (char)0;
                    txtMatKhau.Text = "Password";
                    Manager manager = new Manager(this);
                    manager.ShowDialog();
                    LoadData();
                }
            }
        }

        private void txtMaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Username")
                txtMaNV.Text = "";
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                txtMaNV.Text = "Username";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.Text = "";
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhau.Text = "Password";
            }
        }
    }
}
