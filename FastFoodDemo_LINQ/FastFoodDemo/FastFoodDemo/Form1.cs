using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            home = new Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            pnShow.Controls.Clear();
            home = new Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);

        }
        Home home = new Home();
        Menu monan = new Menu();
        Login login = new Login();
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEatIn.Height;
            SidePanel.Top = btnEatIn.Top;
            pnShow.Controls.Clear();
            monan = new Menu();
            monan.Dock = DockStyle.Fill;
            monan.BringToFront();
            pnShow.Controls.Add(monan);
            pnShow.Width = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition= System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManager.Height;
            SidePanel.Top = btnManager.Top;
            pnShow.Controls.Clear();
            login = new Login();
            login.Dock = DockStyle.Fill;
            login.BringToFront();
            pnShow.Controls.Add(login);
        }
    }
}
