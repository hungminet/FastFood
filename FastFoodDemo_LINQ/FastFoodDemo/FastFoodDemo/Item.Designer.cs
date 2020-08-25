namespace FastFoodDemo
{
    partial class Item
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.picSP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 1);
            this.panel1.TabIndex = 0;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(120, 27);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(62, 23);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "label1";
            this.lblTenSP.Click += new System.EventHandler(this.lblTenSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(96, 82);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(62, 21);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "label3";
            this.lblSoLuong.Click += new System.EventHandler(this.lblSoLuong_Click);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaBan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(296, 82);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(112, 21);
            this.lblGiaBan.TabIndex = 5;
            this.lblGiaBan.Text = "x 44.000 &đ";
            this.lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGiaBan.Click += new System.EventHandler(this.lblGiaBan_Click);
            // 
            // picSP
            // 
            this.picSP.BackColor = System.Drawing.Color.White;
            this.picSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSP.Location = new System.Drawing.Point(-1, 8);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(98, 64);
            this.picSP.TabIndex = 1;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.panel1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(425, 111);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiaBan;
    }
}
