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
    public partial class PhieuDKview : Form
    {
        public PhieuDKview()
        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        public static string madp = null;
        private void PhieuDKview_Load(object sender, EventArgs e)
        {
            if (ketnoi.openConn())
            {

                Phieudangky pdk = new Phieudangky();
                // string sql = "select ctdp.maphong, makh,hoten,madv,ngayden,ngaydi from ctdp a , phong b where a.maphong=b.maphong and maphong='"+map.Text+"'";
                string sql = "SELECT dbo.ctdp.maphong as 'Mã Phòng', dbo.ctdp.hoten as 'Tên Khách Hàng', dbo.ctdp.ngayden as 'Ngày Đến', dbo.ctdp.ngaydi as ' Ngày Đi', dbo.dichvu.giadv as ' Giá Dịch Vụ', dbo.dichvu.tendv as ' Tên Dịch Vụ', dbo.phong.giaphong as 'Giá Phòng' FROM  dbo.ctdp INNER JOIN dbo.dichvu ON dbo.ctdp.madv = dbo.dichvu.madv INNER JOIN dbo.khachhang ON dbo.ctdp.makh = dbo.khachhang.makh INNER JOIN dbo.phong ON dbo.ctdp.maphong = dbo.phong.maphong where dbo.ctdp.maphong = '" + map.Text+"'";
                
                DataTable dt = ketnoi.loadDataTable(sql);
                pdk.SetDataSource(dt);

                crystalReportViewer1.ReportSource = pdk;

            }
            else
            {
                MessageBox.Show("Không thể kết nối!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
