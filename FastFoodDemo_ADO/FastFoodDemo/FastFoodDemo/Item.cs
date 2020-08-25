using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public Image PicSP
        {
            get { return picSP.BackgroundImage; }
            set { picSP.BackgroundImage = value; }
        }
        public string TenSP
        {
            get { return lblTenSP.Text; }
            set { lblTenSP.Text = value; }
        }
        public int SoLuong
        {
            get { return int.Parse(lblSoLuong.Text); }
            set { lblSoLuong.Text = value.ToString(); }
        }
        public string GiaBan 
        {
            get { return lblGiaBan.Text; }
            set { lblGiaBan.Text = value; }
        }

        private void lblGiaBan_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void picSP_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblSoLuong_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
