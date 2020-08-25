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
    public partial class PicItem : UserControl
    {
        public PicItem()
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

        public string GiaBan
        {
            get { return lblGiaBan.Text; }
            set { lblGiaBan.Text = value; }
        }

        public int Count { get; set; }

        private void picSP_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblGiaBan_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
