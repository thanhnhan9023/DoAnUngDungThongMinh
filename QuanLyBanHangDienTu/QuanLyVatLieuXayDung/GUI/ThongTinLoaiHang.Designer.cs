﻿namespace QuanLyVatLieuXayDung.GUI
{
    partial class ThongTinLoaiHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinLoaiHang));
            this.dsLoaihang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiHang = new DevExpress.XtraEditors.TextEdit();
            this.txtLink = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoaihang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLoaihang
            // 
            this.dsLoaihang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsLoaihang.Location = new System.Drawing.Point(2, 2);
            this.dsLoaihang.MainView = this.gridView2;
            this.dsLoaihang.Name = "dsLoaihang";
            this.dsLoaihang.Size = new System.Drawing.Size(1024, 416);
            this.dsLoaihang.TabIndex = 0;
            this.dsLoaihang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dsLoaihang.Click += new System.EventHandler(this.dsLoaihang_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.dsLoaihang;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại";
            this.gridColumn1.FieldName = "MaLoai";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại";
            this.gridColumn2.FieldName = "TenLoai";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô Tả";
            this.gridColumn3.FieldName = "Mota";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Link Hình Ảnh";
            this.gridColumn4.FieldName = "Linkloaihang";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 48);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(329, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(260, 32);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Thông Tin Loại Hàng";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dsLoaihang);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 439);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1028, 420);
            this.panelControl2.TabIndex = 1;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 48);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(200, 391);
            this.panelControl3.TabIndex = 2;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnSua);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(196, 387);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức Năng";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // BtnSua
            // 
            this.BtnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Appearance.Options.UseFont = true;
            this.BtnSua.ImageOptions.Image = global::QuanLyVatLieuXayDung.Properties.Resources.update32;
            this.BtnSua.Location = new System.Drawing.Point(53, 246);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(104, 47);
            this.BtnSua.TabIndex = 0;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Appearance.Options.UseFont = true;
            this.BtnXoa.ImageOptions.Image = global::QuanLyVatLieuXayDung.Properties.Resources.del32;
            this.BtnXoa.Location = new System.Drawing.Point(53, 146);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(104, 49);
            this.BtnXoa.TabIndex = 0;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Appearance.Options.UseFont = true;
            this.BtnThem.ImageOptions.Image = global::QuanLyVatLieuXayDung.Properties.Resources.add32;
            this.BtnThem.Location = new System.Drawing.Point(53, 56);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(104, 53);
            this.BtnThem.TabIndex = 0;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtDiaChi);
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.btnHuy);
            this.panelControl4.Controls.Add(this.btnLuu);
            this.panelControl4.Controls.Add(this.txtTenLoaiHang);
            this.panelControl4.Controls.Add(this.txtLink);
            this.panelControl4.Controls.Add(this.txtMaLH);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(200, 48);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(828, 391);
            this.panelControl4.TabIndex = 3;
            this.panelControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(156, 165);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(249, 120);
            this.txtDiaChi.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(432, 72);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(363, 181);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(210, 291);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 41);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(47, 291);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 41);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(156, 104);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiHang.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiHang.Size = new System.Drawing.Size(233, 28);
            this.txtTenLoaiHang.TabIndex = 1;
            this.txtTenLoaiHang.EditValueChanged += new System.EventHandler(this.txtTenLoaiHang_EditValueChanged);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(492, 29);
            this.txtLink.Name = "txtLink";
            this.txtLink.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Properties.Appearance.Options.UseFont = true;
            this.txtLink.Size = new System.Drawing.Size(221, 28);
            this.txtLink.TabIndex = 1;
            this.txtLink.EditValueChanged += new System.EventHandler(this.txtDienGiai_EditValueChanged);
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(156, 34);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Properties.Appearance.Options.UseFont = true;
            this.txtMaLH.Size = new System.Drawing.Size(233, 30);
            this.txtMaLH.TabIndex = 1;
            this.txtMaLH.EditValueChanged += new System.EventHandler(this.txtMaLH_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 223);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Địa Chỉ";
            this.labelControl4.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tên Loại Hàng";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(418, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Link";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Loại Hàng";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // ThongTinLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ThongTinLoaiHang";
            this.Size = new System.Drawing.Size(1028, 859);
            this.Load += new System.EventHandler(this.ThongTinLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLoaihang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiHang;
        private DevExpress.XtraEditors.TextEdit txtLink;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaLH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dsLoaihang;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
