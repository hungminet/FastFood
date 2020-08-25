namespace FastFoodDemo
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPic3 = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.btnPic1 = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnPic3);
            this.panel1.Controls.Add(this.btnPic2);
            this.panel1.Controls.Add(this.btnPic1);
            this.panel1.Controls.Add(this.picHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 825);
            this.panel1.TabIndex = 1;
            // 
            // btnPic3
            // 
            this.btnPic3.BackColor = System.Drawing.Color.Transparent;
            this.btnPic3.BackgroundImage = global::FastFoodDemo.Properties.Resources.circle2;
            this.btnPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic3.FlatAppearance.BorderSize = 0;
            this.btnPic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic3.Location = new System.Drawing.Point(1473, 398);
            this.btnPic3.Name = "btnPic3";
            this.btnPic3.Size = new System.Drawing.Size(20, 20);
            this.btnPic3.TabIndex = 1;
            this.btnPic3.UseVisualStyleBackColor = false;
            this.btnPic3.Click += new System.EventHandler(this.btnPic3_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.BackColor = System.Drawing.Color.Transparent;
            this.btnPic2.BackgroundImage = global::FastFoodDemo.Properties.Resources.circle2;
            this.btnPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic2.FlatAppearance.BorderSize = 0;
            this.btnPic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic2.Location = new System.Drawing.Point(1473, 363);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(20, 20);
            this.btnPic2.TabIndex = 1;
            this.btnPic2.UseVisualStyleBackColor = false;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // btnPic1
            // 
            this.btnPic1.BackColor = System.Drawing.Color.Transparent;
            this.btnPic1.BackgroundImage = global::FastFoodDemo.Properties.Resources.circle1;
            this.btnPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic1.FlatAppearance.BorderSize = 0;
            this.btnPic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic1.Location = new System.Drawing.Point(1473, 327);
            this.btnPic1.Name = "btnPic1";
            this.btnPic1.Size = new System.Drawing.Size(20, 20);
            this.btnPic1.TabIndex = 1;
            this.btnPic1.UseVisualStyleBackColor = false;
            this.btnPic1.Click += new System.EventHandler(this.btnPic1_Click);
            // 
            // picHome
            // 
            this.picHome.BackgroundImage = global::FastFoodDemo.Properties.Resources.home1;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(46, 3);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(1401, 801);
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1520, 822);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPic1;
        private System.Windows.Forms.Button btnPic3;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.Timer timer1;
    }
}
