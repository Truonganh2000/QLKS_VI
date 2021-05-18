namespace QLKS
{
    partial class hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadon));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxdi = new System.Windows.Forms.ComboBox();
            this.cbxden = new System.Windows.Forms.ComboBox();
            this.cbxmakh = new System.Windows.Forms.ComboBox();
            this.cbxmaphong = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cbxdi);
            this.groupBox1.Controls.Add(this.cbxden);
            this.groupBox1.Controls.Add(this.cbxmakh);
            this.groupBox1.Controls.Add(this.cbxmaphong);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtdg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1287, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BIÊN LAI";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1152, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 77);
            this.button4.TabIndex = 27;
            this.button4.Text = "XUẤT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(983, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "XÓA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbxdi
            // 
            this.cbxdi.FormattingEnabled = true;
            this.cbxdi.Location = new System.Drawing.Point(672, 205);
            this.cbxdi.Name = "cbxdi";
            this.cbxdi.Size = new System.Drawing.Size(246, 37);
            this.cbxdi.TabIndex = 25;
            // 
            // cbxden
            // 
            this.cbxden.FormattingEnabled = true;
            this.cbxden.Location = new System.Drawing.Point(232, 215);
            this.cbxden.Name = "cbxden";
            this.cbxden.Size = new System.Drawing.Size(246, 37);
            this.cbxden.TabIndex = 24;
            // 
            // cbxmakh
            // 
            this.cbxmakh.FormattingEnabled = true;
            this.cbxmakh.Items.AddRange(new object[] {
            "-Chọn mã khách hàng-"});
            this.cbxmakh.Location = new System.Drawing.Point(232, 95);
            this.cbxmakh.Name = "cbxmakh";
            this.cbxmakh.Size = new System.Drawing.Size(246, 37);
            this.cbxmakh.TabIndex = 23;
            this.cbxmakh.SelectedIndexChanged += new System.EventHandler(this.cbxmakh_SelectedIndexChanged);
            this.cbxmakh.SelectedValueChanged += new System.EventHandler(this.cbxmakh_SelectedValueChanged);
            // 
            // cbxmaphong
            // 
            this.cbxmaphong.FormattingEnabled = true;
            this.cbxmaphong.Items.AddRange(new object[] {
            "- Chọn mã phòng -"});
            this.cbxmaphong.Location = new System.Drawing.Point(232, 163);
            this.cbxmaphong.Name = "cbxmaphong";
            this.cbxmaphong.Size = new System.Drawing.Size(246, 37);
            this.cbxmaphong.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(983, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "Làm lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdg
            // 
            this.txtdg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdg.Location = new System.Drawing.Point(672, 89);
            this.txtdg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(246, 35);
            this.txtdg.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày Đi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày Đến:";
            // 
            // txtmahd
            // 
            this.txtmahd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmahd.Location = new System.Drawing.Point(232, 36);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(246, 35);
            this.txtmahd.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Hóa Đơn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "TÍNH TIỀN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Phòng:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(420, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIÊN LAI THANH TOÁN TIỀN PHÒNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(29, 85);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1287, 317);
            this.dgv.TabIndex = 13;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahd";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maphong";
            this.Column2.HeaderText = "Mã Phòng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "makh";
            this.Column3.HeaderText = "Mã Khách Hàng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayden";
            this.Column4.HeaderText = "Ngày Đến";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaydi";
            this.Column5.HeaderText = "Ngày Đi";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "thanhtien";
            this.Column6.HeaderText = "Đơn Gía";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(1369, 713);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "hoadon";
            this.Text = "hoadon";
            this.Activated += new System.EventHandler(this.hoadon_Activated);
            this.Load += new System.EventHandler(this.hoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxmakh;
        private System.Windows.Forms.ComboBox cbxmaphong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbxdi;
        private System.Windows.Forms.ComboBox cbxden;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}