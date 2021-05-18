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
    public partial class baobieu : Form
    {
        public baobieu()
        {
            InitializeComponent();
        }
        connection ketnoi = new connection();
        private void baobieu_Load(object sender, EventArgs e)
        {
            String sql = "SELECT* FROM hoadon";
            DataTable dt = ketnoi.loadDataTable(sql);
            Hoadon hd = new Hoadon();
            hd.SetDataSource(dt);
            crystalReportViewer1.ReportSource = hd;
        }
    }
}
