using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FastFoodDemo
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        Image[] iHome = new Image[3];
        Image[] iButton = new Image[3];
        private void Home_Load(object sender, EventArgs e)
        {
            iButton[0] = global::FastFoodDemo.Properties.Resources.circle1;
            iButton[1] = global::FastFoodDemo.Properties.Resources.circle2;

            iHome[0] = global::FastFoodDemo.Properties.Resources.home1;
            iHome[1] = global::FastFoodDemo.Properties.Resources.home2;
            iHome[2] = global::FastFoodDemo.Properties.Resources.home3;

            timer1.Enabled = true;
        }

        int dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dem %= 3;
            HienThi(dem);
            dem++;

        }

        private void HienThi(int dem)
        {
            picHome.BackgroundImage = iHome[dem];
            btnPic1.BackgroundImage = iButton[1];
            btnPic2.BackgroundImage = iButton[1];
            btnPic3.BackgroundImage = iButton[1];
            if (dem == 0)
                btnPic1.BackgroundImage = iButton[0];
            else if (dem == 1)
                btnPic2.BackgroundImage = iButton[0];
            else
                btnPic3.BackgroundImage = iButton[0];
        }
        private void btnPic1_Click(object sender, EventArgs e)
        {
            dem = 0;
            HienThi(dem);
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            dem = 1;
            HienThi(dem);
        }

        private void btnPic3_Click(object sender, EventArgs e)
        {
            dem = 2;
            HienThi(dem);
        }
    }
}
