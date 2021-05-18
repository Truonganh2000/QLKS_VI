

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
    public partial class Quanlyphong : Form
    {
        public Quanlyphong()
        {
            InitializeComponent();
        }

        private void dgvQuanLyPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        connection ketnoi = new connection();


        DataTable table = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void loaddata()
        {
            table.Clear();
            table = ketnoi.loadDataTable("select * from phong ");
            dgv.DataSource = table;
            dgv.Columns[0].HeaderText = "Mã Phòng";
            dgv.Columns[1].HeaderText = "Loại Phòng";
            dgv.Columns[2].HeaderText = "Tình trạng";
            dgv.Columns[3].HeaderText = "Giá Phòng";







        }

        private void bttim_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            string query = "select * from phong where maphong " ;
            ketnoi.executeUpdate(query);
            loaddata();
            ketnoi.closeConn();

        }

       

        private void btsua_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            if (txtmaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaphong.Focus();
                return;
            }
            if (txtloaiphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại phòng!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtloaiphong.Focus();
                return;
            }
            if (txttinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tình trạng phòng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttinhtrang.Focus();
                return;
            }
            if (txtgia.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn phải nhập giá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgia.Focus();
                return;
            }
             
            string query = "update phong set maphong='" + txtmaphong.Text + "',tenlp=N'" + txtloaiphong.Text + "',tinhtrang=N'" + txttinhtrang.Text + "',giaphong='" + txtgia.Text + "' WHERE maphong='" + txtmaphong.Text + "'";
            ketnoi.executeUpdate(query);
            MessageBox.Show("Bạn đã sửa thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddata();
            ketnoi.closeConn();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphong.ReadOnly = true;
            txttinhtrang.Enabled = false;
            int i;
            i = dgv.CurrentRow.Index;
            txtmaphong.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtloaiphong.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txttinhtrang.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtgia.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void Quanlyphong_Load(object sender, EventArgs e)
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
            ketnoi.closeConn();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            if (txtmaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtmaphong.Focus();
            return;
        }
            if (txtloaiphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại phòng!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtloaiphong.Focus();
                return;
            }
            if (txttinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng phòng!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtloaiphong.Focus();
                return;
            }
            if (txtgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá phòng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgia.Focus();
                return;
            }

string query = "insert into phong values ('" + txtmaphong.Text + "',N'" + txtloaiphong.Text + "',N'" + txttinhtrang.Text + "','" + txtgia.Text + "')";
ketnoi.executeUpdate(query);
loaddata();
MessageBox.Show("Thêm phòng thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
ketnoi.closeConn();
        }

    

        private void btxoa_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            if (txtmaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgia.Focus();
                return;
            }

            string query = "delete from phong where maphong='" + txtmaphong.Text + "'";
            ketnoi.executeUpdate(query);
            loaddata();
            MessageBox.Show("Xóa phòng thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.closeConn();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
