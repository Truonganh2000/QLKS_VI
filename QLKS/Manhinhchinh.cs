using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fmmanhinh : Form
    {
        public static string quyen = "0";
        static public string user = null;
        List<ToolStripMenuItem> Admin = new List<ToolStripMenuItem>();
        List<ToolStripMenuItem> NV = new List<ToolStripMenuItem>();
        List<ToolStripMenuItem> Khach = new List<ToolStripMenuItem>();
        public void Hienthi(List<ToolStripMenuItem> ls, bool visible)
        {
            foreach (ToolStripMenuItem item in ls)
                item.Visible = visible;
        }
        public fmmanhinh()
        {
            InitializeComponent();
            Admin.Add(đăngNhậpToolStripMenuItem);
            Admin.Add(quanlyToolStripMenuItem);
            Admin.Add(lịchLàmViệcToolStripMenuItem);
            Admin.Add(quảnLýPhòngToolStripMenuItem);
            Admin.Add(thốngKêToolStripMenuItem);
            Admin.Add(traCứuToolStripMenuItem);
            NV.Add(đăngNhậpToolStripMenuItem);
            NV.Add(quanlyToolStripMenuItem);
            NV.Add(quảnLýDịchVụToolStripMenuItem);
            NV.Add(thốngKêToolStripMenuItem);
            NV.Add(traCứuToolStripMenuItem);
            NV.Add(traCứuLịchLàmViệcToolStripMenuItem);
            Khach.Add(đăngNhậpToolStripMenuItem);
            Khach.Add(đặtPhòngToolStripMenuItem);
        }


        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmdangnhap dangnhap = new fmdangnhap();
            dangnhap.Show();
            đăngXuấtToolStripMenuItem.Visible = true;
            
        }

        private void lịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichlvNV lv = new LichlvNV();
            lv.Show();
          
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH kh = new QLKH();
            kh.Show();
         
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datphong dp = new Datphong();
            dp.Show();
       
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Tạm Biệt!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datdv dv = new Datdv();
            dv.Show();

        }

        private void fmmanhinh_Load(object sender, EventArgs e)
        {
          
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongtinNV nv = new ThongtinNV();
            nv.Show();

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTK tk = new QLTK();
            tk.Show();

        }

        private void fmmanhinh_Activated(object sender, EventArgs e)
        {

                if (user == null)
                    đăngNhậpToolStripMenuItem1.Text = "Đăng nhập";
                else đăngNhậpToolStripMenuItem1.Text = "Chào, " + user;
                if (quyen == "A")
                {

                    Hienthi(Admin, true);
                }
                else if (quyen == "B")
                {
                    Hienthi(NV, true);
                quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
                thôngTinNhânViênToolStripMenuItem.Visible = false;
            }
                else if (quyen == "C")
                {
                    Hienthi(Khach, true);
                }
                else
                {
                    đặtPhòngToolStripMenuItem.Visible = false;
                    quảnLýPhòngToolStripMenuItem.Visible = false;
                    lịchLàmViệcToolStripMenuItem.Visible = false;
                    quanlyToolStripMenuItem.Visible = false;
                    thốngKêToolStripMenuItem.Visible = false;
                    traCứuToolStripMenuItem.Visible = false;
                traCứuLịchLàmViệcToolStripMenuItem.Visible = false;
                }
            }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoimk mk = new frmdoimk();
            mk.Show();
        }

        private void traCứuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracuunhanvien tcnv = new tracuunhanvien();
            tcnv.Show();
        }

        private void traCứuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            kh.Show();
        }

        private void traCứuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void traCứuLịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tralichlamviec tl = new tralichlamviec();
            tl.Show();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlyphong phong = new Quanlyphong();
            phong.Show();
        }
    }
        
    }
    
    
