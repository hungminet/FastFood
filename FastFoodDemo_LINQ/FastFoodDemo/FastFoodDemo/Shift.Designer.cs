namespace FastFoodDemo
{
    partial class Shift
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_toshift = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_to_shift = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb_ADD_SHIFT = new System.Windows.Forms.RadioButton();
            this.cbb_shift = new System.Windows.Forms.ComboBox();
            this.cbb_emp_ID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pn_em_shift = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.pn_toshift.SuspendLayout();
            this.pnTieuDe.SuspendLayout();
            this.pn_em_shift.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::FastFoodDemo.Properties.Resources.icons8_multiply_32px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(800, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pn_em_shift);
            this.panel2.Controls.Add(this.pn_toshift);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.rdb_ADD_SHIFT);
            this.panel2.Controls.Add(this.cbb_emp_ID);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 334);
            this.panel2.TabIndex = 6;
            // 
            // pn_toshift
            // 
            this.pn_toshift.Controls.Add(this.label3);
            this.pn_toshift.Controls.Add(this.cbb_to_shift);
            this.pn_toshift.Location = new System.Drawing.Point(29, 119);
            this.pn_toshift.Name = "pn_toshift";
            this.pn_toshift.Size = new System.Drawing.Size(554, 71);
            this.pn_toshift.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Shift";
            // 
            // cbb_to_shift
            // 
            this.cbb_to_shift.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbb_to_shift.FormattingEnabled = true;
            this.cbb_to_shift.Location = new System.Drawing.Point(197, 25);
            this.cbb_to_shift.Name = "cbb_to_shift";
            this.cbb_to_shift.Size = new System.Drawing.Size(341, 31);
            this.cbb_to_shift.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.radioButton1.Location = new System.Drawing.Point(635, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 27);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EDIT SHIFT";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdb_ADD_SHIFT
            // 
            this.rdb_ADD_SHIFT.AutoSize = true;
            this.rdb_ADD_SHIFT.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rdb_ADD_SHIFT.Location = new System.Drawing.Point(635, 32);
            this.rdb_ADD_SHIFT.Name = "rdb_ADD_SHIFT";
            this.rdb_ADD_SHIFT.Size = new System.Drawing.Size(133, 27);
            this.rdb_ADD_SHIFT.TabIndex = 23;
            this.rdb_ADD_SHIFT.TabStop = true;
            this.rdb_ADD_SHIFT.Text = "ADD SHIFT";
            this.rdb_ADD_SHIFT.UseVisualStyleBackColor = true;
            this.rdb_ADD_SHIFT.CheckedChanged += new System.EventHandler(this.rdb_ADD_SHIFT_CheckedChanged);
            // 
            // cbb_shift
            // 
            this.cbb_shift.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbb_shift.FormattingEnabled = true;
            this.cbb_shift.Location = new System.Drawing.Point(197, 15);
            this.cbb_shift.Name = "cbb_shift";
            this.cbb_shift.Size = new System.Drawing.Size(341, 31);
            this.cbb_shift.TabIndex = 17;
            // 
            // cbb_emp_ID
            // 
            this.cbb_emp_ID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbb_emp_ID.FormattingEnabled = true;
            this.cbb_emp_ID.Location = new System.Drawing.Point(225, 31);
            this.cbb_emp_ID.Name = "cbb_emp_ID";
            this.cbb_emp_ID.Size = new System.Drawing.Size(341, 31);
            this.cbb_emp_ID.TabIndex = 16;
            this.cbb_emp_ID.SelectedIndexChanged += new System.EventHandler(this.cbb_emp_ID_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::FastFoodDemo.Properties.Resources.icons8_save_20px;
            this.btnSave.Location = new System.Drawing.Point(652, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "    Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee\'s Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee\'s ID";
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnTieuDe.Controls.Add(this.btnClose);
            this.pnTieuDe.Controls.Add(this.lblName);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(851, 45);
            this.pnTieuDe.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Shift";
            // 
            // pn_em_shift
            // 
            this.pn_em_shift.Controls.Add(this.cbb_shift);
            this.pn_em_shift.Controls.Add(this.label2);
            this.pn_em_shift.Location = new System.Drawing.Point(29, 247);
            this.pn_em_shift.Name = "pn_em_shift";
            this.pn_em_shift.Size = new System.Drawing.Size(554, 66);
            this.pn_em_shift.TabIndex = 26;
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTieuDe);
            this.Name = "Shift";
            this.Size = new System.Drawing.Size(851, 379);
            this.Load += new System.EventHandler(this.Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_toshift.ResumeLayout(false);
            this.pn_toshift.PerformLayout();
            this.pnTieuDe.ResumeLayout(false);
            this.pnTieuDe.PerformLayout();
            this.pn_em_shift.ResumeLayout(false);
            this.pn_em_shift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdb_ADD_SHIFT;
        private System.Windows.Forms.ComboBox cbb_to_shift;
        private System.Windows.Forms.ComboBox cbb_shift;
        private System.Windows.Forms.ComboBox cbb_emp_ID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pn_toshift;
        private System.Windows.Forms.Panel pn_em_shift;
    }
}
