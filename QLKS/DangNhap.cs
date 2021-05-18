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
using System.Text.RegularExpressions;
namespace QLKS
{
    public partial class fmdangnhap : Form
    {
        connection ketnoi = new connection();
        public fmdangnhap()
        {
            InitializeComponent();
        }
        public static string PASS = "^[A-Za-z0-9.-_]{6,20}";
        public bool Pass(string pass)
        {
            if (pass == null)
                return false;
            return Regex.IsMatch(pass, PASS);
        }
        private void button1_Click(object sender, EventArgs e)

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
                    ketnoi.cmd = new SqlCommand("select tendangnhap,maquyen from dangnhap where tendangnhap='" + txtten.Text + "' and matkhau='" + txtmk.Text + "'", ketnoi.conn);
                    ketnoi.drd = ketnoi.cmd.ExecuteReader();
                    if (ketnoi.drd.Read() == true)
                    {
                        fmmanhinh.quyen = ketnoi.drd["maquyen"].ToString().Trim();
                        fmmanhinh.user = ketnoi.drd["tendangnhap"].ToString().Trim();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hãy kiểm tra lại tên đăng nhập và mật khẩu của bạn");
                    }
                    ketnoi.drd.Close();
                    ketnoi.closeConn();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }





        private void fmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmdangnhap_Load_1(object sender, EventArgs e)
        {

        }

        private void cbxten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}