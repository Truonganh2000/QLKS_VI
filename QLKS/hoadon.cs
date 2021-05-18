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
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }
        int i;
        connection ketnoi = new connection();
        void loaddata()
        {

            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select * from hoadon");

            ketnoi.closeConn();
        }
        private void hoadon_Activated(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void slp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            ketnoi.openConn();
            loaddata();
            ketnoi.closeConn();
            String sql = "SELECT makh,makh AS hienthi FROM datphong ";
            DataTable dt = ketnoi.loadDataTable(sql);
            cbxmakh.DataSource = dt;
            cbxmakh.ValueMember = "makh";
            cbxmakh.DisplayMember = "hienthi";
            String sql1 = "SELECT maphong,maphong AS hienthi2 FROM datphong";
            DataTable dt1 = ketnoi.loadDataTable(sql1);
            cbxmaphong.DataSource = dt1;
            cbxmaphong.ValueMember = "maphong";
            cbxmaphong.DisplayMember = "hienthi2";
            String sql2 = "SELECT ngayden,ngayden AS hienthi3 FROM datphong WHERE makh='"+cbxmakh.Text+"'";
            DataTable dt2 = ketnoi.loadDataTable(sql2);
            cbxden.DataSource = dt2;
            cbxden.ValueMember = "ngayden";
            cbxden.DisplayMember = "hienthi3";
            String sql3 = "SELECT ngaydi,ngaydi AS hienthi4 FROM datphong WHERE makh='" + cbxmakh.Text + "'";
            DataTable dt3 = ketnoi.loadDataTable(sql3);
            cbxdi.DataSource = dt3;
            cbxdi.ValueMember = "ngaydi";
            cbxdi.DisplayMember = "hienthi";
            ketnoi.closeConn();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void hoadonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void hoadonBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void hoadonBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st = "insert into hoadon values('" + txtmahd.Text + "','" + cbxmaphong.Text + "','" + cbxmakh.Text + "','" + cbxden.Text + "','" + cbxdi.Text + "','" + txtdg.Text + "')";
                ketnoi.executeSQL(st);

                ketnoi.closeConn();
                loaddata();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmahd.Clear();
            cbxmaphong.SelectedIndex = 0;
            cbxmakh.SelectedIndex = 0;
            cbxden.SelectedIndex = 0;
            cbxdi.SelectedIndex = 0;
            txtdg.Clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.ReadOnly = true;
            cbxmakh.Enabled = false;
            cbxmaphong.Enabled = false;
            cbxden.Enabled = false;
            cbxdi.Enabled = false;
            i = dgv.CurrentRow.Index;
            txtmahd.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbxmaphong.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbxmakh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbxden.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbxdi.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtdg.Text = dgv.Rows[i].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            String st = "delete from hoadon where mahd='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
            ketnoi.executeSQL(st);

            ketnoi.closeConn();
            loaddata();
        }

        private void cbxmakh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxmakh_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baobieu bb = new baobieu();
            bb.Show();
        }
    }
}
