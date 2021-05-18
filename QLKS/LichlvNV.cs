using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLKS
{
    public partial class LichlvNV : Form
    {

        public LichlvNV()
        {
            InitializeComponent();
        }
        int i;
        connection ketnoi = new connection();
        void loaddata()
        {

            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select * from lichlamviec");

            ketnoi.closeConn();
        }

        private void LichlvNV_Load(object sender, EventArgs e)
        {
            loaddata();
            ketnoi.openConn();
            String sql = "SELECT manv, manv AS hienthi FROM nhanvien";
            DataTable dt = ketnoi.loadDataTable(sql);
            cbxmanv.DataSource = dt;
            cbxmanv.ValueMember = "manv";
            cbxmanv.DisplayMember = "hienthi";
            ketnoi.closeConn();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtmalich.ReadOnly = true;
                i = dgv.CurrentRow.Index;
                txtmalich.Text = dgv.Rows[i].Cells[0].Value.ToString();
                cbxmanv.Text = dgv.Rows[i].Cells[1].Value.ToString();
                cbxca.Text = dgv.Rows[i].Cells[2].Value.ToString();
                dtngay.Text = dgv.Rows[i].Cells[3].Value.ToString();
               
            }
            catch (Exception ex)
            {
            }
        }

            private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                DateTime d = dtngay.Value;
                string d1 = d.ToString("MM-dd-yyyy");
                String st = "insert into lichlamviec values ('" +txtmalich.Text+"','"+ cbxmanv.Text + "',N'" + cbxca.Text + "','" + d1 + "')";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }

            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                DateTime d = dtngay.Value;
                string d1 = d.ToString("MM-dd-yyyy");
                String st = "update lichlamviec set malich='"+txtmalich.Text+"',manv='" + cbxmanv.Text + "',ca=N'" + cbxca.Text + "',ngaylv='" + d1 + "' WHERE manv='" + dgv.Rows[i].Cells[1].Value.ToString() + "'";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
     
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st = "delete from lichlamviec where malich='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
    
        }

        private void LichlvNV_Activated(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
