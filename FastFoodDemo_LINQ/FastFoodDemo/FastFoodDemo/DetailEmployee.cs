using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FastFoodDemo.BL_Layer;
namespace FastFoodDemo
{
    public partial class DetailEmployee : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public DetailEmployee(bool mk, bool kind, NHANVIEN n)
        {
            InitializeComponent();
            nv = n;
            MatKhau = mk;
            Kind = kind;
            dsNV = blNV.dsNhanVien();
        }
        public DetailEmployee(bool them)
        {
            InitializeComponent();
            Them = them;
            dsNV = blNV.dsNhanVien();
        }

        bool Them = false;
        bool MatKhau = false;
        bool Kind = false;
        NHANVIEN nv = new NHANVIEN();
        BLNhanVien blNV = new BLNhanVien();
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DetailEmployee_Load(object sender, EventArgs e)
        {
            if (Them)
            {
                lblName.Text = "ADD";
            }
            else
            {
                lblName.Text = "EDIT";
                pnPass.Visible = MatKhau;
                pnKind.Visible = Kind;
                txtHoTen.Text = nv.HoTen;
                txtCMND.Text = nv.CMND.ToString();
                txtMK.Text = nv.MatKhau.ToString();
                txtSDT.Text = "0" + nv.SDT.ToString();
                cbGT.Checked = (Boolean)nv.GT;
                if ((Boolean)nv.GT)
                    picNV.BackgroundImage = Properties.Resources.nu;
                else
                    picNV.BackgroundImage = Properties.Resources.nam;
                if (nv.QuanLi == 1)
                    cbKind.SelectedIndex = 1;
                else if (nv.QuanLi == 2)
                    cbKind.SelectedIndex = 2;
                else
                    cbKind.SelectedIndex = 0;

            }
        }

        private int MaxNV()
        {
            dsNV = blNV.dsNhanVien();
            int max = (from nv in dsNV
                       select nv.MaNV).ToList().Max();
            return max;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool k = int.TryParse(txtCMND.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtCMND, "Giá trị CMND không hợp lệ");
                return;
            }
            k = int.TryParse(txtSDT.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtSDT, "Giá trị SDT không hợp lệ");
                return;
            }
            if (Them)
            {
                string message;
                NHANVIEN NV = new NHANVIEN()
                {
                    MaNV = MaxNV() + 1,
                    HoTen = txtHoTen.Text,
                    GT = cbGT.Checked,
                    CMND = int.Parse(txtCMND.Text.Trim()),
                    SDT = int.Parse(txtSDT.Text.Trim()),
                    TT_LamViec = true,
                    MatKhau = txtMK.Text,
                    QuanLi = cbKind.SelectedIndex
                };

                bool result = blNV.Insert(NV, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
            else
            {
                NHANVIEN NV = new NHANVIEN()
                {
                    MaNV = nv.MaNV,
                    HoTen = txtHoTen.Text,
                    GT = cbGT.Checked,
                    CMND = int.Parse(txtCMND.Text.Trim()),
                    SDT = int.Parse(txtSDT.Text.Trim()),
                    TT_LamViec = nv.TT_LamViec,
                    MatKhau = txtMK.Text,
                    QuanLi = cbKind.SelectedIndex
                };
                string message;
                bool result = blNV.Update(NV, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
        }

        private void cbGT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGT.Checked)
                picNV.BackgroundImage = Properties.Resources.nu;
            else
                picNV.BackgroundImage = Properties.Resources.nam;
        }

        private void cbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKind.SelectedIndex == 0)
                pnPass.Visible = false;
            else
                pnPass.Visible = true;
        }
    }
}
