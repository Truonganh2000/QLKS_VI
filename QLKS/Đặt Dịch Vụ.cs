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
    public partial class Datdv : Form
    {
        public Datdv()

        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        string str = @"Data Source=.;Initial Catalog = QLKS2; Integrated Security = True";


        DataTable table = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void loaddata()
        {
            ketnoi.openConn();
            
            table.Clear();

            table = ketnoi.loadDataTable("select * from dichvu ");
            dgv.DataSource = table;
            dgv.Columns[0].HeaderText = "Mã Dịch Vụ";
            dgv.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgv.Columns[2].HeaderText = "Giá Dịch Vụ";


            ketnoi.closeConn();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmadv.ReadOnly = true;
              
                int i;
                i = dgv.CurrentRow.Index;
                txtmadv.Text = dgv.Rows[i].Cells[0].Value.ToString();
                txtten.Text = dgv.Rows[i].Cells[1].Value.ToString();
                txtgia.Text = dgv.Rows[i].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                if (txtmadv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã dịch vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmadv.Focus();
                    return;
                }
                if (txtten.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên dịch vụ!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtten.Focus();
                    return;
                }
                if (txtgia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá dịch vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgia.Focus();
                    return;
                }

                string query = "insert into dichvu values ('" + txtmadv.Text + "',N'" + txtten.Text + "','" + txtgia.Text + "')";
                ketnoi.executeUpdate(query);
                loaddata();
                MessageBox.Show("Thêm dịch vụ thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.closeConn();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm dịch vụ");
            }
        }

        private void btsua_Click(object sender, EventArgs e)

        {
            try
            {
                ketnoi.openConn();
                if (txtmadv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã dịch vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmadv.Focus();
                    return;
                }
                if (txtten.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên dịch vụ!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtten.Focus();
                    return;
                }
                if (txtgia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá dịch vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgia.Focus();
                    return;
                }


                string query = "update dichvu set madv='" + txtmadv.Text + "',tendv=N'" + txtten.Text + "',giadv='" + txtgia.Text + "' WHERE madv='" + txtmadv.Text + "'";
                ketnoi.executeUpdate(query);
                loaddata();
                MessageBox.Show("Sửa dịch vụ thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.closeConn();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể sửa");            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.openConn();
                if (txtmadv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã dịch vụ muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgia.Focus();
                    return;
                }

                string query = "delete from dichvu where madv='" + txtmadv.Text + "'";
                ketnoi.executeUpdate(query);
                loaddata();
                MessageBox.Show("Xóa dịch vụ thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.closeConn();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể xóa dịch vụ này");
            }
        }

        private void Đặt_Dịch_Vụ_Load(object sender, EventArgs e)
        {
            if (ketnoi.openConn() == true)
            {
                MessageBox.Show("Đã Kết Nối CSDL!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Kết Nối Được CSDL!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            loaddata();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtmadv.Clear();
            txtten.Clear();
            txtgia.Clear();
        }
    }
}
