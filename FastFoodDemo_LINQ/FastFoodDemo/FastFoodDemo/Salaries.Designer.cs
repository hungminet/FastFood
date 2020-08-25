namespace FastFoodDemo
{
    partial class Salaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_all_salar = new System.Windows.Forms.Button();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_empIDs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pannel_abs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cklb_shifts3 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cklb_shifts1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cklb_shifts2 = new System.Windows.Forms.CheckedListBox();
            this.cklb_shifts4 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_tinhluong = new System.Windows.Forms.Button();
            this.dtp_cal = new System.Windows.Forms.DateTimePicker();
            this.dtp_print = new System.Windows.Forms.DateTimePicker();
            this.rdb_showsalary = new System.Windows.Forms.RadioButton();
            this.rdb_cal = new System.Windows.Forms.RadioButton();
            this.pn_showSalary = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.pannel_abs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_showSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "SALARIES";
            // 
            // btn_all_salar
            // 
            this.btn_all_salar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_all_salar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_salar.Location = new System.Drawing.Point(412, 13);
            this.btn_all_salar.Name = "btn_all_salar";
            this.btn_all_salar.Size = new System.Drawing.Size(145, 41);
            this.btn_all_salar.TabIndex = 10;
            this.btn_all_salar.Text = "Save";
            this.btn_all_salar.UseVisualStyleBackColor = true;
            this.btn_all_salar.Click += new System.EventHandler(this.btn_all_salar_Click);
            // 
            // dgvLuong
            // 
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dgvLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuong.ColumnHeadersHeight = 35;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.NgayTL,
            this.Salary});
            this.dgvLuong.EnableHeadersVisualStyles = false;
            this.dgvLuong.GridColor = System.Drawing.Color.DimGray;
            this.dgvLuong.Location = new System.Drawing.Point(7, 56);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLuong.RowHeadersWidth = 53;
            this.dgvLuong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLuong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLuong.RowTemplate.Height = 28;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.Size = new System.Drawing.Size(596, 459);
            this.dgvLuong.TabIndex = 6;
            this.dgvLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgayTL
            // 
            this.NgayTL.HeaderText = "NgayTL";
            this.NgayTL.MinimumWidth = 8;
            this.NgayTL.Name = "NgayTL";
            this.NgayTL.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 8;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // cbb_empIDs
            // 
            this.cbb_empIDs.FormattingEnabled = true;
            this.cbb_empIDs.Location = new System.Drawing.Point(-1, 36);
            this.cbb_empIDs.Name = "cbb_empIDs";
            this.cbb_empIDs.Size = new System.Drawing.Size(277, 34);
            this.cbb_empIDs.TabIndex = 11;
            this.cbb_empIDs.SelectedIndexChanged += new System.EventHandler(this.cbb_empIDs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Absented";
            // 
            // pannel_abs
            // 
            this.pannel_abs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pannel_abs.Controls.Add(this.panel1);
            this.pannel_abs.Controls.Add(this.panel2);
            this.pannel_abs.Controls.Add(this.label2);
            this.pannel_abs.Controls.Add(this.btn_tinhluong);
            this.pannel_abs.Controls.Add(this.btn_all_salar);
            this.pannel_abs.Controls.Add(this.dtp_cal);
            this.pannel_abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pannel_abs.Location = new System.Drawing.Point(22, 111);
            this.pannel_abs.Name = "pannel_abs";
            this.pannel_abs.Size = new System.Drawing.Size(612, 521);
            this.pannel_abs.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cklb_shifts3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cklb_shifts1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cklb_shifts2);
            this.panel1.Controls.Add(this.cklb_shifts4);
            this.panel1.Location = new System.Drawing.Point(9, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 331);
            this.panel1.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 42);
            this.panel3.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Shifts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Week 4";
            // 
            // cklb_shifts3
            // 
            this.cklb_shifts3.CheckOnClick = true;
            this.cklb_shifts3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklb_shifts3.FormattingEnabled = true;
            this.cklb_shifts3.Location = new System.Drawing.Point(226, 82);
            this.cklb_shifts3.Name = "cklb_shifts3";
            this.cklb_shifts3.Size = new System.Drawing.Size(86, 236);
            this.cklb_shifts3.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Week 3";
            // 
            // cklb_shifts1
            // 
            this.cklb_shifts1.CheckOnClick = true;
            this.cklb_shifts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklb_shifts1.FormattingEnabled = true;
            this.cklb_shifts1.Location = new System.Drawing.Point(8, 82);
            this.cklb_shifts1.Name = "cklb_shifts1";
            this.cklb_shifts1.Size = new System.Drawing.Size(86, 236);
            this.cklb_shifts1.TabIndex = 14;
            this.cklb_shifts1.SelectedIndexChanged += new System.EventHandler(this.cklb_shifts1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Week 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Week 1";
            // 
            // cklb_shifts2
            // 
            this.cklb_shifts2.CheckOnClick = true;
            this.cklb_shifts2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklb_shifts2.FormattingEnabled = true;
            this.cklb_shifts2.Location = new System.Drawing.Point(113, 82);
            this.cklb_shifts2.Name = "cklb_shifts2";
            this.cklb_shifts2.Size = new System.Drawing.Size(86, 236);
            this.cklb_shifts2.TabIndex = 28;
            // 
            // cklb_shifts4
            // 
            this.cklb_shifts4.CheckOnClick = true;
            this.cklb_shifts4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklb_shifts4.FormattingEnabled = true;
            this.cklb_shifts4.Location = new System.Drawing.Point(337, 82);
            this.cklb_shifts4.Name = "cklb_shifts4";
            this.cklb_shifts4.Size = new System.Drawing.Size(86, 236);
            this.cklb_shifts4.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbb_empIDs);
            this.panel2.Location = new System.Drawing.Point(9, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 72);
            this.panel2.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 40);
            this.panel4.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Employee ID";
            // 
            // btn_tinhluong
            // 
            this.btn_tinhluong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_tinhluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_tinhluong.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_tinhluong.ForeColor = System.Drawing.Color.White;
            this.btn_tinhluong.Location = new System.Drawing.Point(476, 460);
            this.btn_tinhluong.Name = "btn_tinhluong";
            this.btn_tinhluong.Size = new System.Drawing.Size(131, 41);
            this.btn_tinhluong.TabIndex = 24;
            this.btn_tinhluong.Text = "Calculate";
            this.btn_tinhluong.UseVisualStyleBackColor = false;
            this.btn_tinhluong.Click += new System.EventHandler(this.btn_tinhluong_Click);
            // 
            // dtp_cal
            // 
            this.dtp_cal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_cal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtp_cal.Location = new System.Drawing.Point(182, 20);
            this.dtp_cal.Name = "dtp_cal";
            this.dtp_cal.Size = new System.Drawing.Size(200, 32);
            this.dtp_cal.TabIndex = 22;
            // 
            // dtp_print
            // 
            this.dtp_print.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtp_print.Location = new System.Drawing.Point(3, 15);
            this.dtp_print.Name = "dtp_print";
            this.dtp_print.Size = new System.Drawing.Size(200, 32);
            this.dtp_print.TabIndex = 23;
            this.dtp_print.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // rdb_showsalary
            // 
            this.rdb_showsalary.AutoSize = true;
            this.rdb_showsalary.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rdb_showsalary.Location = new System.Drawing.Point(116, 53);
            this.rdb_showsalary.Name = "rdb_showsalary";
            this.rdb_showsalary.Size = new System.Drawing.Size(154, 27);
            this.rdb_showsalary.TabIndex = 25;
            this.rdb_showsalary.TabStop = true;
            this.rdb_showsalary.Text = "Show Salary";
            this.rdb_showsalary.UseVisualStyleBackColor = true;
            this.rdb_showsalary.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_cal
            // 
            this.rdb_cal.AutoSize = true;
            this.rdb_cal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rdb_cal.Location = new System.Drawing.Point(304, 53);
            this.rdb_cal.Name = "rdb_cal";
            this.rdb_cal.Size = new System.Drawing.Size(200, 27);
            this.rdb_cal.TabIndex = 26;
            this.rdb_cal.TabStop = true;
            this.rdb_cal.Text = "Calculate Salary";
            this.rdb_cal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdb_cal.UseVisualStyleBackColor = true;
            // 
            // pn_showSalary
            // 
            this.pn_showSalary.Controls.Add(this.dtp_print);
            this.pn_showSalary.Controls.Add(this.dgvLuong);
            this.pn_showSalary.Location = new System.Drawing.Point(32, 101);
            this.pn_showSalary.Name = "pn_showSalary";
            this.pn_showSalary.Size = new System.Drawing.Size(613, 500);
            this.pn_showSalary.TabIndex = 27;
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_showSalary);
            this.Controls.Add(this.pannel_abs);
            this.Controls.Add(this.rdb_cal);
            this.Controls.Add(this.rdb_showsalary);
            this.Controls.Add(this.label1);
            this.Name = "Salaries";
            this.Size = new System.Drawing.Size(673, 644);
            this.Load += new System.EventHandler(this.Salaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.pannel_abs.ResumeLayout(false);
            this.pannel_abs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pn_showSalary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_all_salar;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.ComboBox cbb_empIDs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pannel_abs;
        private System.Windows.Forms.CheckedListBox cklb_shifts1;
        private System.Windows.Forms.DateTimePicker dtp_cal;
        private System.Windows.Forms.DateTimePicker dtp_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tinhluong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox cklb_shifts3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cklb_shifts2;
        private System.Windows.Forms.CheckedListBox cklb_shifts4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdb_showsalary;
        private System.Windows.Forms.RadioButton rdb_cal;
        private System.Windows.Forms.Panel pn_showSalary;
    }
}
