using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace QLKS
{
    public partial class QLTK : Form
    {
        public QLTK()
        {
            InitializeComponent();
        }
        public static string PASS = "^[A-Za-z0-9.-_]{6,20}";
        connection ketnoi = new connection();
        int i;
        public bool Pass(string pass)
        {
            if (pass == null)
                return false;
            return Regex.IsMatch(pass, PASS);
        }
        void loaddata()
        {
           
            ketnoi.openConn();
            dgv.DataSource = ketnoi.loadDataTable("select * from dangnhap");
            ketnoi.closeConn();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   if (Pass(txtmk.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!");
                    txtmk.Focus();
                    return;
                }
                else
                {
                    ketnoi.openConn();

                    String st = "insert into dangnhap values ('" + txttk.Text + "','" + txtmk.Text + "','" + txtmq.Text + "')";
                    ketnoi.executeSQL(st);

                    ketnoi.closeConn();
                    loaddata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txttk.ReadOnly = true;
                i = dgv.CurrentRow.Index;
                txttk.Text = dgv.Rows[i].Cells[0].Value.ToString();
                txtmk.Text = dgv.Rows[i].Cells[1].Value.ToString();
                txtmq.Text = dgv.Rows[i].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pass(txtmk.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!");
                    txtmk.Focus();
                    return;
                }
                else
                {
                    ketnoi.openConn();
                    String st = "delete from dangnhap where tendangnhap='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                    ketnoi.executeSQL(st);

                    ketnoi.closeConn();
                    loaddata();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pass(txtmk.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!");
                    txtmk.Focus();
                    return;
                }
                else
                {
                    ketnoi.openConn();
                    String st = "update dangnhap set tendangnhap = '" + txttk.Text + "', matkhau = '" + txtmk.Text + "',maquyen ='" + txtmq.Text + "' WHERE tendangnhap = '" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                    ketnoi.executeSQL(st);

                    ketnoi.closeConn();
                    loaddata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txttk.Clear();
            txtmk.Clear();
            txtmq.Clear();
        }
    }
}
