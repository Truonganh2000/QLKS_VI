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
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
      
        int i;
        connection ketnoi = new connection();
        void loaddata()
        {

            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select * from khachhang");

            ketnoi.closeConn();

        }
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st= "insert into khachhang values ('" + txtmakh.Text + "',N'" + txthoten.Text + "',N'" + cbgioitinh.Text + "','" + txtcmnd.Text + "','" + txtsdt.Text + "',N'" + txtdiachi.Text+"','"+ cbxtdn.Text+ "')";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        
        private void QLKH_Load(object sender, EventArgs e)
        {
            loaddata();
            ketnoi.openConn();
            String sql = "SELECT tendangnhap, tendangnhap AS hienthi FROM dangnhap Where maquyen='C'";
            DataTable dt = ketnoi.loadDataTable(sql);
            cbxtdn.DataSource = dt;
            cbxtdn.ValueMember = "tendangnhap";
            cbxtdn.DisplayMember = "hienthi";
            ketnoi.closeConn();
        }

       

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st = "update khachhang set makh='" + txtmakh.Text +"',hoten=N'" + txthoten.Text + "',gioitinh=N'" + cbgioitinh.Text + "',cmnd='" + txtcmnd.Text + "',sdt='" + txtsdt.Text + "',diachi=N'" + txtdiachi.Text +"',tendangnhap='"+cbxtdn.Text+"' WHERE makh='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void bttxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st= "delete from khachhang where makh='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btlamlai_Click(object sender, EventArgs e)
        {
            txtmakh.ReadOnly = false;
            txtmakh.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtcmnd.Clear();
            txtsdt.Clear();
            cbgioitinh.ResetText();
            cbxtdn.ResetText();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmakh.ReadOnly = true;
                i = dgv.CurrentRow.Index;
                txtmakh.Text = dgv.Rows[i].Cells[0].Value.ToString();
                txthoten.Text = dgv.Rows[i].Cells[1].Value.ToString();
                cbgioitinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
                txtcmnd.Text = dgv.Rows[i].Cells[3].Value.ToString();
                txtsdt.Text = dgv.Rows[i].Cells[4].Value.ToString();
                txtdiachi.Text = dgv.Rows[i].Cells[5].Value.ToString();
                cbxtdn.Text = dgv.Rows[i].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
