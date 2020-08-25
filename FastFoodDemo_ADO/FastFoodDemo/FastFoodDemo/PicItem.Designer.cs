namespace FastFoodDemo
{
    partial class PicItem
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
            this.picSP = new System.Windows.Forms.PictureBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // picSP
            // 
            this.picSP.BackColor = System.Drawing.Color.White;
            this.picSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSP.Location = new System.Drawing.Point(7, 8);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(164, 116);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 0;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGiaBan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblGiaBan.Location = new System.Drawing.Point(0, 147);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(180, 28);
            this.lblGiaBan.TabIndex = 1;
            this.lblGiaBan.Text = "label1";
            this.lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGiaBan.Click += new System.EventHandler(this.lblGiaBan_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenSP.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenSP.Location = new System.Drawing.Point(0, 124);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(180, 23);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "label2";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenSP.Click += new System.EventHandler(this.lblTenSP_Click);
            // 
            // PicItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.picSP);
            this.Name = "PicItem";
            this.Size = new System.Drawing.Size(180, 175);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTenSP;
    }
}
