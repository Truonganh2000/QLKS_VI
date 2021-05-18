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
    public partial class tracuunhanvien : Form
    {
        public tracuunhanvien()
        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        DataTable dta;
        void loaddata()
        {
            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select* from nhanvien");
            ketnoi.closeConn();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select*from NhanVien";
                dta = new DataTable();
                dta = ketnoi.loadDataTable(sql);
                dta.DefaultView.RowFilter = "manv like '%" + comboBox1.Text.ToString() + "%'";
                dgv.DataSource = dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tracuunhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
            ketnoi.openConn();
            String sql = "SELECT manv,manv AS hienthi FROM nhanvien";
            DataTable dt = ketnoi.loadDataTable(sql);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "manv";
            comboBox1.DisplayMember = "hienthi";
            ketnoi.closeConn();

        }
    }
}
