﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanLyVatLieuXayDung.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuVien;
using DALL_BALL;
using System.Collections;

namespace QuanLyVatLieuXayDung
{


    

    /// <summary>
  
    /// </summary>
    public partial class s : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        AddTab add = new AddTab();
        public s()
        {
            InitializeComponent();
            skins();
         
       
           
           
          
        }
   
        public void skins()
        
    
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
          thems.LookAndFeel.SkinName = "Xmas 2008 Blue";
           
        }
       

        //public Form kiemtratontai(Type ftype)
        //{
        //    foreach (Form f in this.MdiChildren)
        //    {
        //        if(f.GetType()==ftype)
        //        {
        //            return f;
        //        }
        //    }
        //    return null;
        //}

            public void hienthi(RibbonControl rb)

        {
            ArrayList dsPage = rb.TotalPageCategory.GetVisiblePages();
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
             

                
            }
        }

        private void skinRibbonGalleryBarItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void s_Load(object sender, EventArgs e)
        {
            Login frm = new Login();
            btntendangnhap.Caption = "Chào " ;
          
           
           
        }
       
     
       

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs;
            rs = XtraMessageBox.Show("ban có đăng xuất   không", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                this.Close();
                Login f = new Login();
                f.Show();
            }
        }

        
        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1,"","Xuất Hàng", new TaoHoaDonXuat());
            }

            //panelControl1.Controls.Clear();
            //TaoHoaDonXuat hoadonxuat = new TaoHoaDonXuat(manv, tennv, loaitk);
            //hoadonxuat.Show();
            //hoadonxuat.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(hoadonxuat);

        }

        private void btnThongTinTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //panelControl1.Controls.Clear();
            //panelControl1.Dock = DockStyle.Fill;
            //QuanTriNgD qtr = new QuanTriNgD();
            //qtr.Show();
            //qtr.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(qtr);
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Người Dùng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Người Dùng", new QuanTriNgD());
            }
        }
        
        public void hienthiphanquyen(string manv)
        {
         
        }
        private void SetButtonVisibility(BarSubItem subItem, string btnName)
        {
            List<BarButtonItem> lst = new List<BarButtonItem>();
            for (int i = 0; i < lst.Count; i++)
            {

            }
            foreach (BarItemLink itemLink in subItem.ItemLinks)
            {
                BarSubItemLink subItemLink = itemLink as BarSubItemLink;
                if (subItemLink != null)
                    SetButtonVisibility(subItemLink.Item as BarSubItem, btnName);
                if (itemLink.Item.Tag.ToString() == btnName)
                    itemLink.Visible = true;
                else
                    itemLink.Visible = false;
            }
        }
        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {
                return;
            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Nhân Viên", new cnNhanVien());
            }
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          


            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Nhà Cung Cấp")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {
                return;
            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Nhà Cung Cấp", new NhaCungCap1());
            }
        }

        private void BtnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //    panelControl1.Controls.Clear();
            //    panelControl1.Dock = DockStyle.Fill;
            //    ThongTinLoaiHang loaihang = new ThongTinLoaiHang();
            //    loaihang.Show();
            //    loaihang.Dock = DockStyle.Fill;
            //    panelControl1.Controls.Add(loaihang);

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text =="Loại Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {
                return;
            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Loại Hàng", new ThongTinLoaiHang());
            }

        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //panelControl1.Controls.Clear();
            //panelControl1.Dock = DockStyle.Fill;
            //ThongTinHangHoa hanghoa = new ThongTinHangHoa();
            //hanghoa.Show();
            //hanghoa.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(hanghoa);
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text =="Hàng Hóa")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Hàng Hóa", new ThongTinHangHoa());
            }

        }

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //panelControl1.Controls.Clear();
            //panelControl1.Dock = DockStyle.Fill;
            //TaoHoaDonNhap loaihang = new TaoHoaDonNhap(true, "", loaitk, manv, tennv);
            //loaihang.Show();
            //loaihang.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(loaihang);

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Nhập Hàng", new TaoHoaDonNhap2());
            }
        }

        private void btnXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs;

            rs = XtraMessageBox.Show("Bạn Muốn Thoát Không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btntendangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDskhachang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //panelControl1.Controls.Clear();
            //KhachHangc kh = new KhachHangc();
            //kh.Show();
            //kh.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(kh);


            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Khách Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Khách Hàng", new KhachHangc());
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //panelControl1.Controls.Clear();
            //Kho kho = new Kho();
            //kho.Show();
            //kho.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(kho);

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Kho")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Kho", new GUI.Kho());
            }

        }

        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //panelControl1.Controls.Clear();
            //Thongke tk = new Thongke();
            //tk.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(tk);
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thong ke")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Thong ke", new ThongKeNhapHang());
            }

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void xtraTabControl1_CloseButtonClick_1(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Khách Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Khách Hàng", new KhachHangc());
            }

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Duyệt Đơn Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Duyệt Đơn Hàng", new DuyetDonHang());
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phiếu Thu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                    add.AddTabControl(xtraTabControl1, "", "Phiếu Thu", new Phieuthu());
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phiếu Chi")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                add.AddTabControl(xtraTabControl1, "", "Phiếu Chi", new Phieuchi());
            }
        }
    }
}