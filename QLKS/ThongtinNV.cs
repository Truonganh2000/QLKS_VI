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
    public partial class ThongtinNV : Form
    {
        public ThongtinNV()
        {
            InitializeComponent();
        }
        int i;
        connection ketnoi = new connection();
        void loaddata()
        {

            ketnoi.openConn();
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ketnoi.loadDataTable("select * from nhanvien");
            
            ketnoi.closeConn();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                ketnoi.openConn();
                DateTime d = datengaysinh.Value;
                if (2020 - d.Year > 18)
                {
                    string d1 = d.ToString("MM-dd-yyyy");
                    String st = "insert into nhanvien values('" + txtmanv.Text + "','" + txtmacv.Text + "',N'" + txthoten.Text + "','" + d1 + "',N'" + cbxgioitinh.Text + "','" + txtsdt.Text + "','" + txtcmnd.Text + "',N'" + txtdiachi.Text + "','" + cbxtk.Text + "')";
                    MessageBox.Show("Thêm thành công!");
                    ketnoi.executeSQL(st);
                    ketnoi.closeConn();
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                }
         
            }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                String st = "delete from nhanvien where manv='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    txtmanv.ReadOnly = true;

                    i = dgv.CurrentRow.Index;
                    txtmanv.Text = dgv.Rows[i].Cells[0].Value.ToString();
                    txtmacv.Text = dgv.Rows[i].Cells[1].Value.ToString();
                    txthoten.Text = dgv.Rows[i].Cells[2].Value.ToString();
                    datengaysinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
                    cbxgioitinh.Text = dgv.Rows[i].Cells[4].Value.ToString();
                    txtsdt.Text = dgv.Rows[i].Cells[5].Value.ToString();
                    txtcmnd.Text = dgv.Rows[i].Cells[6].Value.ToString();
                    txtdiachi.Text = dgv.Rows[i].Cells[7].Value.ToString();
                    cbxtk.Text = dgv.Rows[i].Cells[8].Value.ToString();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        private void ThongtinNV_Load(object sender, EventArgs e)
        {
            loaddata();
            ketnoi.openConn();
            String sql = "SELECT tendangnhap, tendangnhap AS hienthi FROM dangnhap Where maquyen='B'";
            DataTable dt = ketnoi.loadDataTable(sql);
            cbxtk.DataSource = dt;
            cbxtk.ValueMember = "tendangnhap";
            cbxtk.DisplayMember = "hienthi";
            ketnoi.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            DateTime d = datengaysinh.Value;
            if (2020 - d.Year > 18)
            {
                string d1 = d.ToString("MM-dd-yyyy");
                String st = "update nhanvien set manv='" + txtmanv.Text + "',macv='" + txtmacv.Text + "',hoten=N'" + txthoten.Text + "',ngaysinh='" + d1 + "',gioitinh='" + cbxgioitinh.Text + "',cmnd='" + txtcmnd.Text + "',diachi='" + txtdiachi.Text + "',tendangnhap='" + cbxtk.Text + "' WHERE manv='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
                MessageBox.Show("Sửa thành công!");
                ketnoi.executeSQL(st);
                ketnoi.closeConn();
                loaddata();
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txtmacv.Clear();
            txthoten.Clear();
            cbxgioitinh.SelectedIndex = 0;
            txtsdt.Clear();
            txtcmnd.Clear();
            txtdiachi.Clear();
            cbxtk.SelectedIndex = 0;
        }

        private void cbxgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

