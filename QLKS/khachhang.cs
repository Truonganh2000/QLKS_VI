using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        DataTable dta;
        void loaddata()
        {
            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select* from khachhang");
            ketnoi.closeConn();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select*from khachhang";
                dta = new DataTable();
                dta = ketnoi.loadDataTable(sql);
                dta.DefaultView.RowFilter = "makh like '%" + comboBox1.Text.ToString() + "%'";
                dgv.DataSource = dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            loaddata();
            ketnoi.openConn();
            String sql = "SELECT makh,makh AS hienthi FROM khachhang";
            DataTable dt = ketnoi.loadDataTable(sql);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "makh";
            comboBox1.DisplayMember = "hienthi";
            ketnoi.closeConn();

        }
    }
}
