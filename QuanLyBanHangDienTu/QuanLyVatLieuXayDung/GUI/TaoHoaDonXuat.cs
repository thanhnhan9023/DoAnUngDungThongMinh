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
using DevExpress.XtraEditors.Controls;
using QuanLyVatLieuXayDung.Report;
using DevExpress.XtraReports.UI;

namespace QuanLyVatLieuXayDung.GUI
{
    public partial class TaoHoaDonXuat : DevExpress.XtraEditors.XtraUserControl
    {
        bool add = false, update = false, add2 = false, update2 = false;
      
        public static int maxacnhan=0;
        public  TaoHoaDonXuat()
        {
            InitializeComponent();
           
        }
        
        bool coxoa = false;
        DALL_BALL_Hoadonxuat hdxuat = new DALL_BALL_Hoadonxuat();
        DALL_BALL_KhachHang kh = new DALL_BALL_KhachHang();
        DALL_BALL_HangHoa hh = new DALL_BALL_HangHoa();
        DALL_BALL_Phieuthu pt = new DALL_BALL_Phieuthu();

        private string tinhtrang = "Đang giao dịch", tenhhtam
            , tinhtrang2;
        float vat;
        
        
       
       
        public void load_hoadonxuat(object sender, EventArgs e)
        {

            loadhoadon();
            loadhanghoa();
            loadkhachhang();
            txtNgaySinh.DateTime = DateTime.Now;
            txtTenNv.Text = Login.tennv;
            txtTenNv.Enabled = false;
            databinds();
         
       

         
          
        }
       

        public void loadkhachhang()
        {
            cboKhachHang.Properties.DataSource = kh.getdskhachhang();
            cboKhachHang.Properties.DisplayMember = "TenKH";
            cboKhachHang.Properties.ValueMember = "MaKH";
        }

        public void loadhoadon()
        {
            dshoadonhap.DataSource = hdxuat.loadataHoaDonXuat();


        

        }
        public void loadhanghoa()
        {

            cboHangHoa.Properties.DataSource = hh.loadhanghoa();
            cboHangHoa.Properties.DisplayMember = "TenHH";
            cboHangHoa.Properties.ValueMember = "MaHH";

        
        }

        public void loaddulieuhoadonxuat(string mahdxuat)
        {

         dsChitietHd.DataSource= hdxuat.loadchitiethoadonxuat(mahdxuat);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsttam.Count>0)
            {
                coxoa = true;
            }
            if(coxoa)
            {
                lsttam.Remove(lsttam.Single(x => x.MaHH == gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaHH").ToString()));

            }
            if(dsChitietHd.DataSource!=null)
            {
                if (XtraMessageBox.Show("Bạn có muốn Xóa ", "Đồng Ý Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mahh = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHH").ToString();
                    
                    hdxuat.xoa1chitiethoadon(mahh);
                    loaddulieuhoadonxuat(txtMaHDXuat.Text);
                    loadhoadon();
                   // loadhoadon();
                    XtraMessageBox.Show("Thành công");
                }
            }
        }

        private void btnTaoPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                txtMaHDXuat.Text = "HDX001";
            }
            else
            {
                txtMaHDXuat.Text = hdxuat.getmaHoadonxuat();
            }
            txtNgaySinh.EditValue = DateTime.Now;
                

            add = true;
            update = false;
           
            

        }

      
        

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView3.RowCount<0)
            {
                return;
            }

            
            var donvi = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "DonViTinh");
            if (donvi==null)
            {
                return;
            }
           txtDonVi.Text = donvi.ToString();

           // txtDonVi.DataBindings.Clear();
          //  txtDonVi.DataBindings.Add("Text", cboHangHoa.Properties.DataSource, "DonViTinh");
        }

        private void g(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {

        }
        public void databinds()
        {
            txtTongtien.DataBindings.Clear();
            txtTongtien.DataBindings.Add("Text",dshoadonhap.DataSource,"TongTien");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                txtMaHDXuat.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD_Xuat").ToString();
                txtNgaySinh.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayLap_Xuat");
                loaddulieuhoadonxuat(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD_Xuat").ToString());
               
                tinhtrang2= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrangXuat").ToString();

                
                


                //  binds ten khach hang
                for (int i = 0; i < kh.loadallkh().Count; i++)
                {
                    var ds = cboKhachHang.Properties.GetKeyValue(i);
                      var ds2 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH");
                    if (ds2 == null)
                    {
                        return;
                    }
                    if (ds == null)
                    {
                        return;
                    }
                    if (ds.ToString() == ds2.ToString())
                    {
                        cboKhachHang.EditValue = cboKhachHang.Properties.GetKeyValue(i);
                        return;
                    }
                }
               // bind ngaylap



            }
        }

        private void btnTaoPhieuXuat_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void barDockingMenuItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string mahdxuat = txtMaHDXuat.Text;
            string makh = cboKhachHang.EditValue.ToString();
            // DateTime ngaylap =DateTime.Parse(txtNgaySinh.EditValue.ToString());
            string manv = Login.manv;

            int ngay = txtNgaySinh.DateTime.Day, thang = txtNgaySinh.DateTime.Month, nam = txtNgaySinh.DateTime.Year;

            DateTime ngaylap = DateTime.Parse(ngay+"/"+thang+"/"+nam);
            


            if (add)
            {
                if (XtraMessageBox.Show("Bạn có muốn Thêm ", "Đồng Ý Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    hdxuat.them1HoaDonXuat(mahdxuat, makh, manv, ngaylap, tinhtrang,0);
                    load_hoadonxuat(sender,e);
                    XtraMessageBox.Show("Thành công");
                }

            }
        }
        List<Chitiethoadonxuattam> lsttam = new List<Chitiethoadonxuattam>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            add2 = true;
           
                Chitiethoadonxuattam ct = new Chitiethoadonxuattam();
                ct.MAHD_Xuat = txtMaHDXuat.Text;
                ct.MaHH = cboHangHoa.EditValue.ToString();
                ct.TenHH = tenhhtam;
                ct.DonGia_Xuat = double.Parse(txtGiaNhap.Text);
                ct.SoLuong_Xuat = int.Parse(txtSoLuong.Text);
                ct.ThanhTienXuat = long.Parse(txtThanhTien.Text);
                ct.DonVi = txtDonVi.Text;
                ct.Vat = vat;
                int s = 1;
                if (lsttam.Count == 0)
                {
                    s = 1;
                }
                else
                {
                    for (int i = 0; i < lsttam.Count; i++)
                    {
                        if (tenhhtam == lsttam[i].TenHH)
                        {
                            s++;
                        }
                    }
                }
                if (s == 1)
                {
                    lsttam.Add(ct);

                    loadtam();
                }
            

        }

        private void loadtam()
        {
            dsChitietHd.DataSource = "";
            dsChitietHd.DataSource = lsttam;
        }

        private void cboHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            tenhhtam=gridView3.GetRowCellValue(gridView3.FocusedRowHandle,"TenHH").ToString();
           
        }

      
   

      

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if(gridView2.RowCount<=0)
            {
                return;
            }
          
            txtSoLuong.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SoLuong_Xuat").ToString();
            txtGiaNhap.Text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DonGia_Xuat").ToString();
            txtDonVi.Text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DonVi").ToString();
            txtThanhTien.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ThanhTienXuat").ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update2 = true;
            add2 = false;
        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaNhap_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void btnXoaNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hóa đơn", "Đồng Ý Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


             


                hdxuat.xoa1chitethoadonall(txtMaHDXuat.Text);
                hdxuat.xoa1HoadonNhap(txtMaHDXuat.Text);
                loaddulieuhoadonxuat(txtMaHDXuat.Text);
                loadhoadon();
                XtraMessageBox.Show("Thành công");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            load_hoadonxuat(sender,e);
        }

        private void txtBoxSo1_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length <= 0 || txtGiaNhap.Text.Length <= 0)
            {
                return;
            }
            else
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtGiaNhap.Text) * (1 - vat)).ToString();
        }

        private void txtGiaNhap_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length <= 0 || txtGiaNhap.Text.Length <= 0)
            {
                return;
            }
            else
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtGiaNhap.Text) * (1 - vat)).ToString();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            update2 = true;
            add2 = false;
        }

        private void btnXoaNhap_ListItemClick_1(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void btnXoaNhap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Xóa", "Đồng Ý Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hdxuat.xoa1chitethoadonall(txtMaHDXuat.Text);
                hdxuat.xoa1HoadonNhap(txtMaHDXuat.Text);
                loadhoadon();
                XtraMessageBox.Show("Thành công");
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChiTietHDXuat2 rpt = new ChiTietHDXuat2();

            rpt.DataSource = hdxuat.loadchitiethdxuat(txtMaHDXuat.Text);
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.ShowPreview();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            long tongtien;
           if(cboThue.SelectedText=="5%")
            {
                vat = 5;
                tongtien = (long)(long.Parse(txtTongtien.Text) * (1 - 0.05));
                txtTongtien.Text = tongtien.ToString();
            }
           else
            {
                vat = 10;
                tongtien = (long)(long.Parse(txtTongtien.Text) * (1 - 0.1));
                txtTongtien.Text = tongtien.ToString();
            }
        }

        private void txtKhachDua_EditValueChanged(object sender, EventArgs e)
        {
            long tienkhanhdua;
            tienkhanhdua=long.Parse(txtKhachDua.Text)-long.Parse(txtTongtien.Text);
            if(tienkhanhdua!=0)
            {
                txtTienThua.Text = tienkhanhdua.ToString();
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            long tongtienxuat =long.Parse(txtTongtien.Text);

            DateTime ngaylap = (DateTime)txtNgaySinh.EditValue;
            if(tinhtrang2=="Đang giao dịch")
            {
                pt.themphieuthikhithanhtoan("", "Khách Hàng", tinhtrang2, Login.manv, tongtienxuat, ngaylap);
                hdxuat.sua1hoadonnhapxuat(txtMaHDXuat.Text);
             
                loadhoadon();
                MessageBox.Show("Thanh toán thành công");
            }
            
            
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (add2 )
            {
                if (hdxuat.kiemtracohoadonxuat(txtMaHDXuat.Text).Count <= 0)
                {


                    if (XtraMessageBox.Show("Bạn có muốn Thêm", "Đồng Ý Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (lsttam.Count > 0)
                        {
                            for (int i = 0; i < lsttam.Count; i++)
                            {
                                hdxuat.them1chitiethoadonxuat(lsttam[i].MAHD_Xuat, lsttam[i].MaHH, lsttam[i].SoLuong_Xuat, lsttam[i].DonGia_Xuat, lsttam[i].ThanhTienXuat, lsttam[i].Vat, lsttam[i].DonVi);
                            }

                            lsttam.Clear();
                        }

                        load_hoadonxuat(sender, e);
                        XtraMessageBox.Show("Thành công");
                    }
                }else
                {
                    XtraMessageBox.Show("Không được thêm");
                }

            }
           
            if(update2)
            {
                if (XtraMessageBox.Show("Bạn có muốn sửa", "Đồng Ý sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    string mahh = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHH").ToString();
                    int soluong = int.Parse(txtSoLuong.Text);
                    double giaxuat = double.Parse(txtGiaNhap.Text);
                    long thanhtienxuat = long.Parse(txtThanhTien.Text);
                    float vat = 0;
                    string donvi = txtDonVi.Text;
                    hdxuat.sua1chitiethoadonxuat(mahh,soluong,thanhtienxuat,vat,giaxuat,donvi);
                    loaddulieuhoadonxuat(txtMaHDXuat.Text);
                    
                    XtraMessageBox.Show("Thành công");
                }
            }


        }

        private void barDockingMenuItem5_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            
        }

        public void selectfistTenhanghoa()
        {
          
        }
    

     
    }
}
