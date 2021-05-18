namespace QLKS
{
    partial class Datdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datdv));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý  Dịch Vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmadv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(18, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1264, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Dịch Vụ";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(248, 171);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(454, 44);
            this.txtten.TabIndex = 9;
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(786, 269);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(212, 60);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xóa Dịch Vụ";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Location = new System.Drawing.Point(786, 158);
            this.btsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(212, 56);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "Sửa  Dịch Vụ";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btthem.BackgroundImage = global::QLKS.Properties.Resources.them;
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Location = new System.Drawing.Point(786, 43);
            this.btthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(212, 59);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Thêm Dịch Vụ";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(243, 285);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(458, 44);
            this.txtgia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(243, 58);
            this.txtmadv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(458, 44);
            this.txtmadv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Dịch Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Dịch Vụ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 520);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(1272, 318);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1062, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Làm Lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Datdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS.Properties.Resources.giai_nhiet_mua_he_voi_bo_suu_tap_hinh_nen_bien_xanh;
            this.ClientSize = new System.Drawing.Size(1316, 875);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Datdv";
            this.Text = "Đặt_Dịch_Vụ";
            this.Load += new System.EventHandler(this.Đặt_Dịch_Vụ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button button1;
    }
}