using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class Dangky : Form
    {
        connection ketnoi = new connection();
        static public string dsPhong = null;
        public Dangky()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ĐăngKý_Load(object sender, EventArgs e)
        {
            ketnoi.openConn();
            loaddata();
            gbdv.Enabled = false;
            gbthongtinkh.Enabled = true;

            ketnoi.closeConn();
            ketnoi.openConn();
            string sql = "select madv,madv+'-'+tendv as hienthi from dichvu";

            DataTable dt = ketnoi.loadDataTable(sql);
            cbxtendv.DataSource = dt;
            cbxtendv.DisplayMember = "hienthi";
            cbxtendv.ValueMember = "madv";

            ketnoi.closeConn();

           

            txtgiadv.ReadOnly = true;

            gbdv.Enabled = false;
            gbthongtinkh.Enabled = true;

            txtmaphong.Text = dsPhong;

        }
        private void loaddata()
        {
            table.Clear();
            table = ketnoi.loadDataTable("select maphong, makh,hoten,madv,ngayden,ngaydi from ctdp where maphong = '"+txtmaphong.Text+ "'");
            dgv.DataSource = table;
            dgv.Columns[0].HeaderText = "Mã Phòng";
            dgv.Columns[1].HeaderText = "Mã Khách Hàng";
            dgv.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv.Columns[3].HeaderText = "Mã Dịch Vụ";

            dgv.Columns[4].HeaderText = "Ngày Đến ";
            dgv.Columns[5].HeaderText = "Ngày Đi";






        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbdv.Enabled = true;

        }

        private void btlamlai_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txthoten.Clear();



        }

        private void bthuy_Click(object sender, EventArgs e)

        {
            Dangky dk = new Dangky();
            Datphong dp = new Datphong();
            DialogResult rs = MessageBox.Show("Bạn đã hủy quá trình điền thông tin đăng ký phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DialogResult rs1 = MessageBox.Show("Bạn muốn quay lại chọn phòng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs1 == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn đã quay lại chọn phòng!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dk.Close();
                    dp.Show();

                }

            }
            else
            {
                dk.Close();
            }

        }
        DateTime ngaythang = DateTime.Now;
        private void btthem_Click(object sender, EventArgs e)
        {
            
            ketnoi.openConn();
            if (txtmakh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
                return;
            }
            if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên khách hàng!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }

            DateTime d = dtngayden.Value;
            DateTime d1 = dtngaydi.Value;
            string d2 = d.ToString("MM-dd-yyyy");
            string d3 = d1.ToString("MM-dd-yyyy");
            string query = "insert into ctdp values  ('" + txtmaphong.Text + "','" + txtmakh.Text + "',N'" + txthoten.Text + "','" + cbxtendv.SelectedValue.ToString() + "','" + d2+ "','" + d3+ "')";
            ketnoi.executeUpdate(query);
            loaddata();
            ketnoi.closeConn();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            ketnoi.openConn();
            string query = "delete from ctdp where madv='" + cbxtendv.SelectedValue.ToString() + "'";
            ketnoi.executeUpdate(query);
            loaddata();
            ketnoi.closeConn();
        }

        private void cbxtendv_SelectedValueChanged(object sender, EventArgs e)
        {
            
                ketnoi.openConn();
                string sql2 = "select * from dichvu where madv ='" + cbxtendv.SelectedValue.ToString() + "'";
                SqlDataReader drd = ketnoi.executeSQL(sql2);
                while (drd.Read())
                {
                    string gia = (string)drd["giadv"].ToString();
                    txtgiadv.Text = gia;
                    string ten = (string)drd["tendv"].ToString();
                    switch (ten)
                    {
                        case "Bữa Sáng":
                            picanh.Image = Image.FromFile("sang.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Bữa Trưa":
                            picanh.Image = Image.FromFile("trua.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Bữa Tối":
                            picanh.Image = Image.FromFile("toi.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Đưa Đón Sân Bay":
                            picanh.Image = Image.FromFile("duadon.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Cho thuê xe tự lái":
                            picanh.Image = Image.FromFile("thuexe.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            MessageBox.Show("Đây là dịch vụ dành cho đối tượng khách muốn thuê xe để đi tham quan các điểm đến du lịch của địa phương.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "Bể bơi bốn mùa":
                            picanh.Image = Image.FromFile("beboi.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;

                            break;
                        case "Karaoke":
                            picanh.Image = Image.FromFile("Karaoke.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Quầy Bar":
                            picanh.Image = Image.FromFile("bar.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Giặt Ủi":
                            picanh.Image = Image.FromFile("giatui.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Phòng tập thể thao":
                            picanh.Image = Image.FromFile("gym.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Sân tennis":
                            picanh.Image = Image.FromFile("tennis.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Đặt vé máy bay, tour du lịch":
                            picanh.Image = Image.FromFile("datve.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            MessageBox.Show("Quý khách có nhu cầu đi tham quan các điểm du lịch của địa phương hay cần đặt vé máy bay để di chuyển thì hãy liên hệ nhân viên lễ tân khách sạn để được phục vụ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "Trông trẻ":
                            picanh.Image = Image.FromFile("trongtre.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Minibar tại phòng":
                            picanh.Image = Image.FromFile("nuoc.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "Văn Phòng":
                            picanh.Image = Image.FromFile("vanphong.jpg");
                            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
                            MessageBox.Show("Dịch vụ văn phòng sẽ bao gồm các tiện ích văn phòng như: máy tính kết nối Internet, máy in, máy photocopy…", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                            
                    }
                }
            ketnoi.closeConn();
        } 
        


        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            //int i;
            //i = dgv.CurrentRow.Index;
            MessageBox.Show("Cám ơn bạn đã đặt phòng ở khách sạn chúng tôi!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string dt= dgv.CurrentRow.Cells[0].Value.ToString();

          //  PhieuDKview.madp = dt;
            PhieuDKview dk = new PhieuDKview();
            dk.map.Text = dt;
            dk.Show();
            this.Close();
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.ReadOnly = true;

            DateTime d = dtngayden.Value;
            string d1 = d.ToString("dd-MM-yyyy");
            DateTime d3 = dtngaydi.Value;
            string d2 = d3.ToString("dd-MM-yyyy");
            int i;
            i = dgv.CurrentRow.Index;
           dsPhong = dgv.Rows[i].Cells[0].Value.ToString();
            txtmakh.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgv.Rows[i].Cells[2].Value.ToString();

            cbxtendv.SelectedValue = dgv.Rows[i].Cells[3].Value.ToString();
           d1= dgv.Rows[i].Cells[4].Value.ToString();
            d2= dgv.Rows[i].Cells[1].Value.ToString();

        }

        private void gbthongtinkh_Enter(object sender, EventArgs e)
        {

        }
    }
}
