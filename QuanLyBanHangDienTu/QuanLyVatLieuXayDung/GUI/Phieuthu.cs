using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DALL_BALL;

namespace QuanLyVatLieuXayDung.GUI
{
    public partial class Phieuthu : DevExpress.XtraEditors.XtraUserControl
    {
        DALL_BALL_Phieuthu ctpt = new DALL_BALL_Phieuthu();
        

        public Phieuthu()
        {
            InitializeComponent();
        }

        public  void load_phieuthu(object sender,EventArgs e)
        {
           gridControl1.DataSource=ctpt.loadphieuthu();
           
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            if(TaoHoaDonXuat.maxacnhan==1)
            gridView1.RefreshData();
        }

        private void gridControl1_CursorChanged(object sender, EventArgs e)
        {
        }
    }
}
