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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        BLNhanVien blNV;
        private int Ma;
        private string MK;
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
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
            dsNV = blNV.dsNhanVien();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool kq = int.TryParse(txtMaNV.Text, out Num);
            if (kq == false)
                errorProvider1.SetError(txtMaNV, "Nhập Username không chính xác");
            for (int i = 0; i < dsNV.Count; i++)
            {
                if (txtMaNV.Text == dsNV[i].MaNV.ToString() && txtMatKhau.Text == dsNV[i].MatKhau.ToString() && dsNV[i].QuanLi > 0 && dsNV[i].TT_LamViec == true)
                {
                    Ma = int.Parse(txtMaNV.Text);
                    MK = txtMatKhau.Text;
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
