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
using System.IO;

namespace FastFoodDemo
{
    public partial class DetailProduct : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public DetailProduct(bool them)
        {
            InitializeComponent();
            Them = them;
        }
        public DetailProduct(SANPHAM s)
        {
            InitializeComponent();
            sp = s;
        }

        SANPHAM sp = new SANPHAM();
        bool Them = false;
        BLSanPham blSP = new BLSanPham();
        List<SANPHAM> dsSP = new List<SANPHAM>();

        public Image ConvertImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b, 0, b.Length);
            ms.Write(b, 0, b.Length);
            return Image.FromStream(ms, true);
        }

        public byte[] ImageByte(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
        private void DetailProduct_Load(object sender, EventArgs e)
        {
            dsSP = blSP.dsSanPham();
            if (Them == true)
                lblName.Text = "ADD";
            else
            {
                lblName.Text = "EDIT";
                txtTenSP.Text = sp.TenSP;
                txtGiaBan.Text = sp.GiaBan.ToString();
                txtGiaSP.Text = sp.GiaSP.ToString();
                picSP.BackgroundImage = ConvertImage((byte[])sp.HinhSP.ToArray());
                pnKind.Visible = false;
            }
        }
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

        private void picSP_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picSP.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool k = int.TryParse(txtGiaBan.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtGiaBan, "Giá Bán không hợp lệ");
                return;
            }
            k = int.TryParse(txtGiaSP.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtGiaSP, "Giá SP không hợp lệ");
                return;
            }
            if (Them == true)
            {
                if (cbKind.SelectedIndex >= 0)
                {
                    int value = 0;
                    if (cbKind.SelectedItem.ToString() == "Burger")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 100 && sp.MaSP < 200
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Chicken")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 200 && sp.MaSP < 300
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Chicken Set")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 300 && sp.MaSP < 400
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Combo")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 400 && sp.MaSP < 500
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Value")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 500 && sp.MaSP < 600
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Set")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 600 && sp.MaSP < 700
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Dessert")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 700 && sp.MaSP < 800
                                 select sp.MaSP).ToList().Max();
                    }
                    else
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 800
                                 select sp.MaSP).ToList().Max();
                    }
                    SANPHAM SP = new SANPHAM()
                    {
                        MaSP = value + 1,
                        HinhSP = new System.Data.Linq.Binary(ImageByte(picSP.BackgroundImage)),
                        TenSP = txtTenSP.Text,
                        TT_Ban = true,
                        GiaSP = int.Parse(txtGiaSP.Text),
                        GiaBan = int.Parse(txtGiaBan.Text)
                    };

                    string message;
                    bool result = blSP.Insert(SP, out message);
                    if (result == false)
                        MessageBox.Show(message);
                    this.Close();
                }
            }
            else
            {
                SANPHAM SP = new SANPHAM()
                {
                    MaSP = sp.MaSP,
                    HinhSP = new System.Data.Linq.Binary(ImageByte(picSP.BackgroundImage)),
                    TenSP = txtTenSP.Text,
                    TT_Ban = true,
                    GiaSP = int.Parse(txtGiaSP.Text),
                    GiaBan = int.Parse(txtGiaBan.Text)
                };
                string message;
                bool result = blSP.Update(SP, out message);
                if (result == false)
                    MessageBox.Show(message);

                this.Close();
            }

        }


    }
}
