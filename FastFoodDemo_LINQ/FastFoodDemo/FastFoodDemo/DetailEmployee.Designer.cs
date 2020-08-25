namespace FastFoodDemo
{
    partial class DetailEmployee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnKind = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.pnPass = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGT = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnKind.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnPass.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnTieuDe.Controls.Add(this.btnClose);
            this.pnTieuDe.Controls.Add(this.btnMinimize);
            this.pnTieuDe.Controls.Add(this.lblName);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(893, 45);
            this.pnTieuDe.TabIndex = 1;
            this.pnTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTieuDe_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::FastFoodDemo.Properties.Resources.icons8_multiply_32px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(842, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::FastFoodDemo.Properties.Resources.icons8_subtract_32px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Location = new System.Drawing.Point(795, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Form\'s Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.cbGT);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.picNV);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 339);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnKind);
            this.panel7.Controls.Add(this.pnPass);
            this.panel7.Location = new System.Drawing.Point(32, 202);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(615, 107);
            this.panel7.TabIndex = 21;
            // 
            // pnKind
            // 
            this.pnKind.Controls.Add(this.label4);
            this.pnKind.Controls.Add(this.panel6);
            this.pnKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnKind.Location = new System.Drawing.Point(0, 53);
            this.pnKind.Name = "pnKind";
            this.pnKind.Size = new System.Drawing.Size(615, 54);
            this.pnKind.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kind";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbKind);
            this.panel6.Location = new System.Drawing.Point(212, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(373, 42);
            this.panel6.TabIndex = 19;
            // 
            // cbKind
            // 
            this.cbKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKind.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý cấp 1",
            "Quản Lý cấp 2"});
            this.cbKind.Location = new System.Drawing.Point(6, 1);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(358, 31);
            this.cbKind.TabIndex = 16;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // pnPass
            // 
            this.pnPass.Controls.Add(this.panel1);
            this.pnPass.Controls.Add(this.label5);
            this.pnPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPass.Location = new System.Drawing.Point(0, 0);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(615, 53);
            this.pnPass.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Location = new System.Drawing.Point(212, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 35);
            this.panel1.TabIndex = 14;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.White;
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(6, 5);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(358, 23);
            this.txtMK.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // cbGT
            // 
            this.cbGT.AutoSize = true;
            this.cbGT.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGT.Location = new System.Drawing.Point(548, 96);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(69, 27);
            this.cbGT.TabIndex = 17;
            this.cbGT.Text = "Sex";
            this.cbGT.UseVisualStyleBackColor = true;
            this.cbGT.CheckedChanged += new System.EventHandler(this.cbGT_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::FastFoodDemo.Properties.Resources.icons8_save_20px;
            this.btnSave.Location = new System.Drawing.Point(669, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "    Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picNV
            // 
            this.picNV.BackgroundImage = global::FastFoodDemo.Properties.Resources.nam;
            this.picNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNV.Location = new System.Drawing.Point(669, 26);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(179, 213);
            this.picNV.TabIndex = 13;
            this.picNV.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtHoTen);
            this.panel4.Location = new System.Drawing.Point(244, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 35);
            this.panel4.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(6, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(358, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Location = new System.Drawing.Point(244, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 35);
            this.panel3.TabIndex = 11;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.White;
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMND.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(6, 5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(259, 23);
            this.txtCMND.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtSDT);
            this.panel5.Location = new System.Drawing.Point(244, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 35);
            this.panel5.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(6, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(358, 23);
            this.txtSDT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee\'s Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DetailEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailEmployee";
            this.Load += new System.EventHandler(this.DetailEmployee_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pnKind.ResumeLayout(false);
            this.pnKind.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnPass.ResumeLayout(false);
            this.pnPass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbGT;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnKind;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}