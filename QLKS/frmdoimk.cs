using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmdoimk : Form
    {
        public frmdoimk()
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
        private void frmdoimk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pass(txtmkmoi.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!");
                    txtmkmoi.Focus();
                    return;
                }
                else
                    try
                    {
                        ketnoi.openConn();
                        string st = "update dangnhap set matkhau = '" + txtmkmoi.Text + "'where tendangnhap='" + txttk.Text + "'";
                        MessageBox.Show("Cập nhật thành công!");
                        ketnoi.closeConn();
                        this.Close();
                    }
                    catch (Exception)
                    {
 
                        MessageBox.Show("Hãy kiểm tra lại tên đăng nhập và mật khẩu của bạn");
                    }
                 
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
