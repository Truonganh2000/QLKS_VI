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
    public partial class Datphong : Form
    {
        public Datphong()
        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        
        private void Đặt_Phòng_Load(object sender, EventArgs e)
        {
            
            gbchon.Enabled = false;
            MessageBox.Show("Vui lòng chọn loại phòng trước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Datphong dp = new Datphong();

            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void rbtdon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtdon.Checked == true)
            {
                gbchon.Enabled = true;
                gbdon.Enabled = true;
                gbdoi.Enabled = false;
                gbtap.Enabled = false;
                gbvip.Enabled = false;

            }
            else
            {
                gbdon.Enabled = false;
                gbdoi.Enabled = true;
                gbtap.Enabled = true;
                gbvip.Enabled = true;

            }
            picanh.Image = Image.FromFile("Phongdon.jpg");
            picanh.SizeMode= PictureBoxSizeMode.StretchImage;
        }

        private void rbtdoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtdoi.Checked == true)
            {
                gbchon.Enabled = true;
                gbdoi.Enabled = true;
                gbdon.Enabled = false;
                gbtap.Enabled = false;
                gbvip.Enabled = false;

            }
            else
            {
                gbdoi.Enabled = false;
                gbdon.Enabled = true;
                gbtap.Enabled = true;
                gbvip.Enabled = true;
            }
            picanh.Image = Image.FromFile("Doi.jpg");
            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbttap_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttap.Checked == true)
            {
                gbchon.Enabled = true;
                gbtap.Enabled = true;
                gbdoi.Enabled = false;
                gbdon.Enabled = false;
                gbvip.Enabled = false;

            }
            else
            {
                gbtap.Enabled = false;
                gbdoi.Enabled = true;
                gbdon.Enabled = true;
                gbvip.Enabled = true;

            }
            picanh.Image = Image.FromFile("tap.png");
            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbtvip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtvip.Checked == true)
            {
                gbchon.Enabled = true;
                gbvip.Enabled = true;
                gbdoi.Enabled = false;
                gbtap.Enabled = false;
                gbdon.Enabled = false;

            }
            else
            {
                gbvip.Enabled = false;
                gbdoi.Enabled = true;
                gbtap.Enabled = true;
                gbdon.Enabled = true;

            }
            picanh.Image = Image.FromFile("vip.jpg");
            picanh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button29_Click(object sender, EventArgs e)
        {
            
            Datphong dp = new Datphong();
            
            Dangky dk = new Dangky();
            dk.Show();
            dp.Close();
            foreach (CheckBox cb2 in gbdoi.Controls)
            {
                if (cb2.CheckState == CheckState.Checked)
                {
                   cb2.AutoCheck = false;
                }

            }


        }








        private void Datphong_Activated(object sender, EventArgs e)
        {
            ketnoi.openConn();
            string sql = "select maphong,tinhtrang from phong";

            SqlDataReader drd = ketnoi.executeSQL(sql);
            
            while (drd.Read())
            {
                foreach (CheckBox ckb in gbdon.Controls)
                {


                    if (ckb.Name.ToUpper() == drd["maphong"].ToString().ToUpper())
                    {
                        switch (drd["tinhtrang"])
                        {
                            case "Phòng Trống": ckb.BackColor = Color.LawnGreen; break;
                            case "Phòng Đầy": ckb.BackColor = Color.Red; break;
                            case "Phòng Đang Dọn Dẹp": ckb.BackColor = Color.RoyalBlue; break;

                        }
                        

                    }
                    foreach (CheckBox ckb2 in gbdoi.Controls)
                    {

                        if (ckb2.Name.ToUpper() == drd["maphong"].ToString().ToUpper())
                            switch (drd["tinhtrang"])
                            {
                                case "Phòng Trống": ckb2.BackColor = Color.LawnGreen; break;
                                case "Phòng Đầy": ckb2.BackColor = Color.Red; break;
                                case "Phòng Đang Dọn Dẹp": ckb2.BackColor = Color.RoyalBlue; break;

                            }
                    }
                    foreach (CheckBox ckb3 in gbtap.Controls)
                    {


                        if (ckb3.Name.ToUpper() == drd["maphong"].ToString().ToUpper())
                            switch (drd["tinhtrang"])
                            {
                                case "Phòng Trống": ckb3.BackColor = Color.LawnGreen; break;
                                case "Phòng Đầy": ckb3.BackColor = Color.Red; break;
                                case "Phòng Đang Dọn Dẹp": ckb3.BackColor = Color.RoyalBlue; break;

                            }

                    }
                    foreach (CheckBox ckb4 in gbvip.Controls)
                    {


                        if (ckb4.Name.ToUpper() == drd["maphong"].ToString().ToUpper())
                            switch (drd["tinhtrang"])
                            {
                                case "Phòng Trống": ckb4.BackColor = Color.LawnGreen; break;
                                case "Phòng Đầy": ckb4.BackColor = Color.Red; break;
                                case "Phòng Đang Dọn Dẹp": ckb4.BackColor = Color.RoyalBlue; break;

                            }




                    }
                }

            }
            ketnoi.closeConn();

           
            
                
           

            ketnoi.openConn();
            foreach (CheckBox cb in gbdon.Controls)
            {
               
                if (cb.CheckState == CheckState.Checked)
                {
                    string map = cb.Name.ToUpper();
                    Dangky.dsPhong = map;
                   

                        
                    
                }
                foreach (CheckBox cb2 in gbdoi.Controls)
                {
                    if (cb2.CheckState == CheckState.Checked)
                    {
                        string map = cb2.Name.ToUpper();
                        Dangky.dsPhong = map;
                    }

                }
                foreach (CheckBox cb3 in gbtap.Controls)
                {
                    if (cb3.CheckState == CheckState.Checked)
                    {
                        string map = cb3.Name.ToUpper();
                        Dangky.dsPhong = map;
                    }

                }
                foreach (CheckBox cb4 in gbvip.Controls)
                {
                    if (cb4.CheckState == CheckState.Checked)
                    {
                        string map = cb4.Name.ToUpper();
                        Dangky.dsPhong = map;
                    }

                }
            }
            ketnoi.closeConn();

            ketnoi.openConn();
            foreach (CheckBox cbc in gbdon.Controls)
            {
                if (cbc.CheckState == CheckState.Checked)
                {
                    ketnoi.openConn();
                    string sql2 = "select maphong,giaphong,tinhtrang from phong ";
                    SqlDataReader drd2 = ketnoi.executeSQL(sql2);
                    while (drd2.Read())
                    {
                        if (cbc.Name.ToUpper() == drd2["maphong"].ToString().ToUpper())
                        {
                            string gia = (string)drd2["giaphong"].ToString();
                            txtgia.Text = gia;
                            
                        }

                    }
                    ketnoi.closeConn();
                }

                foreach (CheckBox cbc1 in gbdoi.Controls)
                {
                    if (cbc1.CheckState == CheckState.Checked)
                    {
                        ketnoi.openConn();
                        string sql3 = "select maphong,giaphong,tinhtrang from phong ";
                        SqlDataReader drd3 = ketnoi.executeSQL(sql3);
                        while (drd3.Read())
                        {
                            if (cbc1.Name.ToUpper() == drd3["maphong"].ToString().ToUpper())
                            {
                                string gia = (string)drd3["giaphong"].ToString();
                                txtgia.Text = gia;

                            }
                           

                        }
                        ketnoi.closeConn();
                    }
                    
                



                    foreach (CheckBox cbc3 in gbtap.Controls)
                    {
                        if (cbc3.CheckState == CheckState.Checked)
                        {
                            ketnoi.openConn();
                            string sql4 = "select maphong,giaphong from phong ";
                            SqlDataReader drd4 = ketnoi.executeSQL(sql4);
                            while (drd4.Read())
                            {
                                if (cbc3.Name.ToUpper() == drd4["maphong"].ToString().ToUpper())
                                {
                                    string gia = (string)drd4["giaphong"].ToString();
                                    txtgia.Text = gia;

                                }

                            }
                            ketnoi.closeConn();
                        }


                        foreach (CheckBox cbc4 in gbvip.Controls)
                        {
                            if (cbc4.CheckState == CheckState.Checked)
                            {
                                ketnoi.openConn();
                                string sql5 = "select maphong,giaphong from phong ";
                                SqlDataReader drd5 = ketnoi.executeSQL(sql5);
                                while (drd5.Read())
                                {
                                    if (cbc4.Name.ToUpper() == drd5["maphong"].ToString().ToUpper())
                                    {
                                        string gia = (string)drd5["giaphong"].ToString();
                                        txtgia.Text = gia;

                                    }

                                }
                                ketnoi.closeConn();
                            }


                           



                        }
                    }
                }
            }
        }

        private void gbdon_Enter(object sender, EventArgs e)
        {

        }

        private void s001_CheckedChanged(object sender, EventArgs e)
        {
            if (s001.CheckState == CheckState.Checked)
            {
               
                MessageBox.Show("Bạn đã chọn phòng đơn có mã S001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (s001.CheckState == CheckState.Unchecked)
            {

               
                MessageBox.Show("Bạn đã bỏ chọn phòng đơn có mã S001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void s002_CheckedChanged_1(object sender, EventArgs e)
        {
            if (s002.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã S002 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s003_CheckedChanged(object sender, EventArgs e)
        {
            if (s003.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đơn có mã S003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (s003.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đơn có mã S003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s004_CheckedChanged(object sender, EventArgs e)
        {

            if (s004.Checked == true)
            {

                MessageBox.Show(" Phòng đơn có mã S004, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s005_CheckedChanged(object sender, EventArgs e)
        {
            if (s005.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đơn có mã S005!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (s005.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đơn có mã S005!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s006_CheckedChanged(object sender, EventArgs e)
        {
            if (s006.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã S006 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s007_CheckedChanged(object sender, EventArgs e)
        {
            if (s007.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã S007 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void s008_CheckedChanged(object sender, EventArgs e)
        {
            if (s008.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã S008 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d001_CheckedChanged(object sender, EventArgs e)
        {

            if (d001.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đôi có mã D001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (d001.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đôi có mã D001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d002_CheckedChanged(object sender, EventArgs e)
        {

            if (d002.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đôi có mã D002!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (d002.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đôi có mã D002!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d003_CheckedChanged(object sender, EventArgs e)
        {
            if (d003.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đôi có mã D003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (d003.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đôi có mã D003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d004_CheckedChanged(object sender, EventArgs e)
        {
            if (d004.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng đôi có mã D004!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (d004.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng đôi có mã D004!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d005_CheckedChanged(object sender, EventArgs e)
        {
            if (d005.Checked == true)
            {

                MessageBox.Show("Phòng đôi có mã D005, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d006_CheckedChanged(object sender, EventArgs e)
        {
            if (d006.Checked == true)
            {

                MessageBox.Show("Phòng đôi có mã D006, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d007_CheckedChanged(object sender, EventArgs e)
        {
            if (d007.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã D007 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void d008_CheckedChanged(object sender, EventArgs e)
        {
            if (d008.Checked == true)
            {

                MessageBox.Show("Phòng đơn có mã D008 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t001_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t001.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T001 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t002_CheckedChanged(object sender, EventArgs e)
        {
            if (t002.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T002 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t003_CheckedChanged(object sender, EventArgs e)
        {
            if (t003.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T003 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t004_CheckedChanged(object sender, EventArgs e)
        {
            if (t004.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T004 đã có người chọn!! Quý khách vui lòng chọn phòng khác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t005_CheckedChanged(object sender, EventArgs e)
        {
            if (t005.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng tập thể có mã T005!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (t005.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng tập thể có mã T005!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void t006_CheckedChanged(object sender, EventArgs e)
        {
            if (t006.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T006, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t007_CheckedChanged(object sender, EventArgs e)
        {
            if (t007.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T007, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t008_CheckedChanged(object sender, EventArgs e)
        {
            if (t008.Checked == true)
            {

                MessageBox.Show("Phòng tập thể có mã T008, đang trong quá trình dọn dẹp!! Quý khách vui lòng chọn phòng khác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void v001_CheckedChanged(object sender, EventArgs e)
        {
            if (v001.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng VIP có mã V001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (v001.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng VIP  có mã V001!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void v002_CheckedChanged(object sender, EventArgs e)
        {
            if (v002.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng VIP có mã V002!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (v002.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng VIP  có mã V002!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void v003_CheckedChanged(object sender, EventArgs e)
        {
            if (v003.CheckState == CheckState.Checked)
            {
                
                MessageBox.Show("Bạn đã chọn phòng VIP có mã V003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (v003.CheckState == CheckState.Unchecked)
            {
                
                MessageBox.Show("Bạn đã bỏ chọn phòng VIP  có mã V003!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void v004_CheckedChanged(object sender, EventArgs e)
        {
            if (v004.CheckState == CheckState.Checked)
            {
               
                MessageBox.Show("Bạn đã chọn phòng VIP có mã V004!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (v004.CheckState == CheckState.Unchecked)
            {
              
                MessageBox.Show("Bạn đã bỏ chọn phòng VIP  có mã V004!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    

