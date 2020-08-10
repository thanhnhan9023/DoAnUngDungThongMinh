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
using QuanLyVatLieuXayDung.Report;
using DevExpress.XtraReports.UI;


namespace QuanLyVatLieuXayDung.GUI
{
    public partial class TaoHoaDonNhap2 : DevExpress.XtraEditors.XtraUserControl


    {
        bool add = false, update = false, update2 = false, add2 = false;
        HoaDonNhapDALL_BALL hdnhap = new HoaDonNhapDALL_BALL();
        DALL_BALL_HangHoa hanghoa = new DALL_BALL_HangHoa();
        DALL_BALL_NhaCungCap ncc = new DALL_BALL_NhaCungCap();
        DALl_BALl_Phieuchics pc = new DALl_BALl_Phieuchics();
        double vat;
        string tenhhtam,tinhtrang,nhacc;
        string mahh = "";
        long tongtien = 0;
        public static int xacnhandon = 0;
        public TaoHoaDonNhap2()
        {
            InitializeComponent();
         
        }
        public void hoadonnhap_load(object sender, EventArgs e)
        {
            // loadgiaodien
            txtMaHDNhap.Enabled = false;
            txtThanhTien.Enabled = false;
            txtDonVi.Enabled = false;
            // hienthi(false);
            btnSua.Enabled = true;
            // load combox
            loadhoandon();
            loadhanghoa();
            loanghandnhacc();
            txtTenNv.Text = Login.tennv;
            txtTenNv.Enabled = false;
            datatbinds(true);



            seteditValuebyindex();

        }
        public void loadhoandon()
        {
            dshoadonhap.DataSource = hdnhap.loadhoadonhap2(Login.manv);
        }
        public void hienthi(bool t)
        {
            txtSoLuong.Enabled = t;
            txtDonGiaNhap.Enabled = t;

        }

        private void loadhanghoa()
        {
            cboHangHoa.Properties.DataSource = hanghoa.loadhanghoa();
            cboHangHoa.Properties.DisplayMember = "TenHH";
            cboHangHoa.Properties.ValueMember = "MaHH";


        }
        public void loanghandnhacc()
        {
            cboNCC.Properties.DataSource = ncc.loaddataNCC();
            cboNCC.Properties.DisplayMember = "TenNCC";
            cboNCC.Properties.ValueMember = "MaNC";

        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

            txtTenNv.Text = "";


        }



        private void barDockingMenuItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)

            {
                txtMaHDNhap.Text = "HDN001";
            }
            else
                txtMaHDNhap.Text = hdnhap.getmatudongtanhdnhap();

            hienthi(true);
            add = true;
            update = false;
            btnSua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // txtDonGiaNhap.Text = hdnhap.getmatudongtanhdnhap();
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //loanghandnhacc();
            //if (gridView1.RowCount <= 0)
            //{
            //    return;
            //}
            //txtMaHDNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD_Nhap").ToString();
            //string mhd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD_Nhap").ToString();
      
            loadchitiethoadon(txtMaHDNhap.Text);
            //object mancc= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNC").ToString();
            //if(mancc==null)
            //{
            //    return;
            //}
            //nhacc = mancc.ToString();
            //object tongtien2= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TongTien").ToString();
            //if(tongtien2==null)
            //{
            //    return;
            //}
            //object tinhtrang2 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrangNhap").ToString();
            //    if(tinhtrang2==null)
            //{
            //    return;
            //}
            //tinhtrang = tinhtrang2.ToString();
            //txtTongTien.Text = tongtien2.ToString();
            //txtTiencantra.Text = tongtien2.ToString();
            
            //tongtien = long.Parse(tongtien2.ToString());


            //for (int i = 0; i < ncc.loadnhacclist().Count; i++)
            //{
            //    var ds = cboNCC.Properties.GetKeyValue(i);
            //    var ds2 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNC").ToString();
            //    if (ds.ToString() == ds2.ToString())
            //    {
            //        cboNCC.EditValue = cboNCC.Properties.GetKeyValue(i);
            //        return;
            //    }
            //}



        }


        private void barDockingMenuItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có muốn Xóa", "Đồng Ý Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hdnhap.xoanhd(txtMaHDNhap.Text);
                hdnhap.xoachitiethoadonnhap(txtMaHDNhap.Text);
                hoadonnhap_load(sender, e);
                XtraMessageBox.Show("Thành công");
            }

        }

        private void barDockingMenuItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //txtMaHDNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD_Nhap").ToString();
            //string mahd = txtMaHDNhap.Text;
            //gridControl2.DataSource = hdnhap.loadhoadonhapchitiet(mahd);
            //txtTenNv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            //dateNgayLapHoaDon.Value = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayLapHD").ToString());
            string MAHD_Nhap = txtMaHDNhap.Text;
            DateTime NgayLapHD = dateNgayLapHoaDon.Value;
            string manv = Login.manv;
            string MaNC = cboNCC.EditValue.ToString();
            //chi tiet hoa don
            string MAHH;
            MAHH = cboHangHoa.EditValue.ToString();
            // so luong nhap
            int SoLuong_Nhap;
            string DonVi = txtDonVi.Text;

            string TinhTrangNhap="Đang giao dịch";
           

            if (add)
            {
                hdnhap.them1hoadonhap(MAHD_Nhap, MaNC, manv, NgayLapHD, TinhTrangNhap,0);
                //  hdnhap.them1chitiethoadon(MAHD_Nhap, MAHH, SoLuong_Nhap, DonGia_Nhap, Thanhtien, DonVi, vat);
                hoadonnhap_load(sender, e);
                XtraMessageBox.Show("Thành Công");

            }


        }
        public void databinds()
        {
            

            } 

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (gridView2.RowCount > 0)
            {
              
                txtSoLuong.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SoLuong_Nhap").ToString();
                txtDonGiaNhap.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DonGia_Nhap").ToString();

                object mah = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHH");
             

                if (mah == null)
                    return;
                   mahh = mah.ToString();


                // cboThue.SelectedText = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Vat").ToString() + "%";
            }



        }

        public void loadthe()
        {
            List<String> lits = new List<string>();
            lits.Add("5%");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cboNCC.EditValue = cboNCC.Properties.GetKeyValue(0);

        }



        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDonVi.Text= gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "DonViTinh").ToString();
            tenhhtam = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "TenHH").ToString();
        }
            
          
      
        

        private void txtDonGiaNhap_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length <= 0 || txtDonGiaNhap.Text.Length <= 0)
            {
                return;
            }
            else
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtDonGiaNhap.Text) * (1 - vat)).ToString();
        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length <= 0 || txtDonGiaNhap.Text.Length <= 0)
            {
                return;
            }
            else
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtDonGiaNhap.Text) - (1 - vat)).ToString();
        }

        private void cboVat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboThue.SelectedIndex == 0)
            {
                vat = 5;
            }
            else
                vat = 10;

        }

        private void barDockingMenuItem4_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }
        // sua chitiethoadon
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            update2 = true;
            btnSua.Enabled = true;
            hienthi(true);
            add2 = false;


        }

        public void datatbinds(bool t)
        {

            if(t)
            {
                txtMaHDNhap.DataBindings.Clear();
                txtMaHDNhap.DataBindings.Add("Text", dshoadonhap.DataSource, "MaHD_Nhap");
                dateNgayLapHoaDon.DataBindings.Clear();
                dateNgayLapHoaDon.DataBindings.Add("Text",dshoadonhap.DataSource,"NgayLapHD");
                cboNCC.DataBindings.Clear();
                cboNCC.DataBindings.Add("Text", dshoadonhap.DataSource, "TenNCC");
             
                
            }
            else
            {
                txtMaHDNhap.DataBindings.Clear();
                dateNgayLapHoaDon.DataBindings.Clear();
               

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            hoadonnhap_load(sender, e);
        }
        public void loadchitiethoadon(string mahd)
        {
            dschitiethoadon.DataSource = hdnhap.loadhoadonhapchitiet(mahd);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Xóa", "Đồng Ý Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                hdnhap.xoachitiethoadonnhap(mahh);
                loadchitiethoadon(txtMaHDNhap.Text);
                loadhoandon();
                XtraMessageBox.Show("Thành công");
            }
        }

        private void barDockingMenuItem5_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        List<Chitiethoadontamcs> lst = new List<Chitiethoadontamcs>();
        public void loadtam()
        {
            dschitiethoadon.DataSource = "";
            dschitiethoadon.DataSource = lst;
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

        }

        private void barDockingMenuItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void cboThue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

        }

       
        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void cboNCC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void griviewlockup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptInChiTietHDNhap rpt = new RptInChiTietHDNhap();
            List<ChiTietHD_Nhap> lst = hdnhap.loadhoadonchitiet(txtMaHDNhap.Text);
            rpt.DataSource = lst;
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.ShowPreview();
        }

        private void txtTientra_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTientra.Text.Length > 0)
            {
                
                long tientra = long.Parse(txtTientra.Text);
                if (tientra > tongtien)
                {

                    txtTienThua.Text = (tientra - tongtien).ToString();
                }
            }
        }

        private void dshoadonhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {


            if (tinhtrang == "Đang giao dịch")
            {
                pc.them1phieuchi("", null, "Nhà Cung Cấp", dateNgayLapHoaDon.Value, "Đã Thanh Toán", tongtien);

                hdnhap.updatehoadonhapkhithanhtoan(txtMaHDNhap.Text, "Đã thanh toán", 0);
                ncc.updatenhacckhithanthoan(nhacc);
                loadhoandon();
                XtraMessageBox.Show("Hoàn Thành Thanh Toán");
            }
           


            //DateTime ngaylap = DateTime.Parse(dateNgayLapHoaDon.Value.ToString());
            //pc.them1phieuchi("",null,"Nhà Cung Cấp",ngaylap,"Đã Thanh Toán",tongtien);
            //xacnhandon = 1;
            //XtraMessageBox.Show("Hoàn Thành Thanh Toán");
         
            
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            add2 = true;
            update2 = false;
      


            string mahd = txtMaHDNhap.Text;
            //chi tiet hoa don


            // so luong nhap
            int SoLuong_Nhap1;
            if (txtSoLuong.Text.Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập só lượng");
                return;
            }
            else
            {
                SoLuong_Nhap1 = int.Parse(txtSoLuong.Text);
            }
            // đơn giá nhập
            float DonGia_Nhap;
            if (txtDonGiaNhap.Text.Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập đơn giá nhập");
                return;
            }

            else
            {
                DonGia_Nhap = float.Parse(txtDonGiaNhap.Text);
            }

            // thanh tien
            double Thanhtien;
            if (txtThanhTien.Text.Length == 0)
            {
                return;
            }
            else
            {
                Thanhtien = double.Parse(txtThanhTien.Text);
            }

            string DonVi1 = txtDonVi.Text;





            Chitiethoadontamcs ct = new Chitiethoadontamcs();
            ct.MAHD_Nhap = txtMaHDNhap.Text;
            ct.MaHH = cboHangHoa.EditValue.ToString();
            ct.TenHH = tenhhtam;
            ct.DonGia_Nhap = DonGia_Nhap;
            ct.SoLuong_Nhap = SoLuong_Nhap1;
            ct.Thanhtien = Thanhtien;
            ct.DonVi = DonVi1;
            ct.Vat = vat;
            int s = 1;
            if (lst.Count == 0)
            {
                s = 1;
            }
            else
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (tenhhtam == lst[i].TenHH)
                    {
                        s++;
                    }
                }
            }
            if (s == 1)
            {
                lst.Add(ct);
                loadtam();
            }





        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            if (add2)
            {

                if (hdnhap.kiemtradulieuhoadonnhap(txtMaHDNhap.Text).Count <= 0)
                {



                    if (XtraMessageBox.Show("Bạn có muốn Thêm", "Đồng Ý Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (lst.Count > 0)
                        {
                            for (int i = 0; i < lst.Count; i++)
                            {
                                hdnhap.them1chitiethoadon(lst[i].MAHD_Nhap, lst[i].MaHH, lst[i].SoLuong_Nhap, lst[i].DonGia_Nhap, lst[i].Thanhtien, lst[i].DonVi, lst[i].Vat);

                                // loadchitiethoadon(mahd);
                            }
                            lst.Clear();
                        }

                        loadchitiethoadon(txtMaHDNhap.Text);
                        loadhoandon();
                        XtraMessageBox.Show("Thành công");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được thêm");
                }


            }
            if (update2)
            {
                string mahd = txtMaHDNhap.Text;
                //chi tiet hoa don
                string MAHH;
                MAHH = cboHangHoa.EditValue.ToString();
                // so luong nhap
                int SoLuong_Nhap;
                if (txtSoLuong.Text.Length == 0)
                {
                    return;
                }
                else
                {
                    SoLuong_Nhap = int.Parse(txtSoLuong.Text);
                }
                // đơn giá nhập
                float DonGia_Nhap;
                if (txtDonGiaNhap.Text.Length == 0)
                {
                    return;
                }

                else
                {
                    DonGia_Nhap = float.Parse(txtDonGiaNhap.Text);
                }

                // thanh tien
                double Thanhtien;
                if (txtThanhTien.Text.Length == 0)
                {
                    return;
                }
                else
                {
                    Thanhtien = double.Parse(txtThanhTien.Text);
                }

                string DonVi = txtDonVi.Text;


                string TinhTrangNhap;
            
                if (XtraMessageBox.Show("Bạn có muốn Sửa", "Đồng Ý Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    hdnhap.sua1chitiethoadon(mahd, MAHH, SoLuong_Nhap, DonGia_Nhap, Thanhtien, DonVi, vat);
                    loadchitiethoadon(mahd);

                    XtraMessageBox.Show("Thành công");
                }

            }
        }

        public void seteditValuebyindex()
        {
            var ds = cboNCC.Properties.GetKeyValue(0);
            cboNCC.EditValue = ds;
            var ds2 = cboHangHoa.Properties.GetKeyValue(0);
            cboHangHoa.EditValue = ds2;
        }


    }

}
