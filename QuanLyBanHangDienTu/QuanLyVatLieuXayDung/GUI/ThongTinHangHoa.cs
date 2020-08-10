using DALL_BALL;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung.GUI
{

    public partial class ThongTinHangHoa : XtraUserControl
    {

        DALL_BALL_HangHoa hh = new DALL_BALL_HangHoa();
        DALL_BALL_Loaihang lh = new DALL_BALL_Loaihang();
        bool add = false, update = false;
        OpenFileDialog open;
        bool saveanh = false;




        public ThongTinHangHoa()
        {
            InitializeComponent();
          

        }
        public void ThongTinHangHoa_Load(object sender, EventArgs e)
        {

            loadcombox();
            laydulieuhanghoa();
            databinds(true);
            txtMaHangHoa.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();





        }


        public void laydulieuhanghoa()
        {

            // dshang.DataSource = hh.loadhanghoa();
            dshang.DataSource = hh.loadhanghoaandlh();
        }





        public void loadcombox()
        {
            // BUS.HangHoaBUS.Instance.loadmaloaicombox(cboMaLoai);

            cboLoaihanghoa.Properties.DataSource = lh.loaddulieuloaihang();
            cboLoaihanghoa.Properties.DisplayMember = "TenLoai";
            cboLoaihanghoa.Properties.ValueMember = "MaLoai";
        }
        public void hienthi(bool t)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }












        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ThongTinHangHoa_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true;
            add = false;
            hienthi(false);
        }

        private void dshang_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Duongdan" && e.IsGetData)

                e.Value = e.Value + "OKKKKK";

        }

        private void txtDuongDan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            add = true;
            txtTenHangHoa.Text = "";
           
            txtDuongDan.Text = "";
            txtMota.Text = "";
            txtGiabansi.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBanle.Text = "";
            databinds(false);
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            pictureEdit1.DataBindings.Clear();

            hienthi(false);
            if (gridView1.DataRowCount <= 0)
            {
                txtMaHangHoa.Text = "HH001";
            }
            else
            {
                txtMaHangHoa.Text = hh.getmahhtutang();
            }
        }



        public void databinds(bool t)
        {
            if (t)
            {

                txtMaHangHoa.DataBindings.Clear();
                txtMaHangHoa.DataBindings.Add("Text", dshang.DataSource, "MAHH");
                txtTenHangHoa.DataBindings.Clear();
                txtTenHangHoa.DataBindings.Add("Text", dshang.DataSource, "TenHH");
                txtDonViTinh.DataBindings.Clear();
                txtDonViTinh.DataBindings.Add("Text", dshang.DataSource, "DonViTinh");
                txtGiabansi.DataBindings.Clear();
                txtGiabansi.DataBindings.Add("Text", dshang.DataSource, "Giabansi");
                txtGiaBanle.DataBindings.Clear();
                txtGiaBanle.DataBindings.Add("Text", dshang.DataSource, "Giabanle");
                txtGiaNhap.DataBindings.Clear();
                txtGiaNhap.DataBindings.Add("Text", dshang.DataSource, "Gianhap");
                txtDuongDan.DataBindings.Clear();
                txtDuongDan.DataBindings.Add("Text", dshang.DataSource, "Duongdan");
                txtMota.DataBindings.Clear();
                txtMota.DataBindings.Add("Text", dshang.DataSource, "MoTa");
               

                cboLoaihanghoa.DataBindings.Clear();
                cboLoaihanghoa.DataBindings.Add("Text", dshang.DataSource, "TenLoai");
            }

            if (!t)
            {

                txtMaHangHoa.DataBindings.Clear();

                txtTenHangHoa.DataBindings.Clear();

                txtDonViTinh.DataBindings.Clear();
                
                txtGiabansi.DataBindings.Clear();

                txtGiaBanle.DataBindings.Clear();

                txtGiaNhap.DataBindings.Clear();

                txtMota.DataBindings.Clear();

                txtDuongDan.DataBindings.Clear(); ;

                cboLoaihanghoa.DataBindings.Clear();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        



            string s = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Duongdan").ToString();
            if(s==null)
            {
                return;
            }
            pictureEdit1.LoadAsync(s);
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (XtraMessageBox.Show("Bạn có muốn Thêm", "Đồng Ý Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    float giabanle = float.Parse(txtGiaBanle.Text);
                    float giabansi = float.Parse(txtGiabansi.Text);
                    float gianhap = float.Parse(txtGiaNhap.Text);

                    hh.them1loaihanghoa(txtMaHangHoa.Text,
                        cboLoaihanghoa.EditValue.ToString(), txtDuongDan.Text,
                        txtTenHangHoa.Text, txtDonViTinh.Text, txtMota.Text, giabanle, giabansi, gianhap, 0);
                    ThongTinHangHoa_Load(sender, e);
                    XtraMessageBox.Show("Thành công");
                }



            }
            if (update)
            {
                if (XtraMessageBox.Show("Bạn có muốn Sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    float giabanle = float.Parse(txtGiaBanle.Text);
                    float giabansi = float.Parse(txtGiabansi.Text);
                    float gianhap = float.Parse(txtGiaNhap.Text);

                    hh.sua1hh(txtMaHangHoa.Text,
                        cboLoaihanghoa.EditValue.ToString(), txtDuongDan.Text,
                        txtTenHangHoa.Text, txtDonViTinh.Text, txtMota.Text, giabanle, giabansi, gianhap);
                    laydulieuhanghoa();
                    XtraMessageBox.Show("Thành công");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Xóa", "Đồng Ý Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                hh.xoa1hanghoa(txtMaHangHoa.Text);
                laydulieuhanghoa();
                XtraMessageBox.Show("Thành công");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            add = false;
            update = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            databinds(true);

        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            ThongTinHangHoa_Load(sender, e);
        }

        private void btnThem_Click_2(object sender, EventArgs e)
        {
            add = true;
            txtTenHangHoa.Text = "";
            txtDuongDan.Text = "";
            txtMota.Text = "";
            txtGiabansi.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBanle.Text = "";
            databinds(false);
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            pictureEdit1.DataBindings.Clear();
            hienthi(false);
            if (gridView1.DataRowCount <= 0)
            {
                txtMaHangHoa.Text = "HH001";
            }
            else
            {
                txtMaHangHoa.Text = hh.getmahhtutang();
            }
        }

        private void btnXoa_Click_2(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Xóa", "Đồng Ý Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hh.xoa1hanghoatrongkho(txtMaHangHoa.Text);
                hh.xoa1hanghoa(txtMaHangHoa.Text);
                XtraMessageBox.Show("Thành công");
                ThongTinHangHoa_Load(sender, e);
                
            }
        }

        private void btnSua_Click_2(object sender, EventArgs e)
        {
            add = false;
            update = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            databinds(true);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {


            if(txtGiaBanle.Text.Length<=0)
            {
                XtraMessageBox.Show("Bạn chưa nhập giá  lẻ");
                return;
            }
            if(txtGiabansi.Text.Length<=0)
            {
                XtraMessageBox.Show("Bạn chưa nhập giá  sỉ");
                return;

            }
            if(txtGiaNhap.Text.Length<=0)
            {
                XtraMessageBox.Show("Bạn chưa nhập giá nhập");
                return;
            }
            float giabanle = float.Parse(txtGiaBanle.Text);
            float giabansi = float.Parse(txtGiabansi.Text);
            float gianhap = float.Parse(txtGiaNhap.Text);

            if (add)
            {
                if (XtraMessageBox.Show("Bạn có muốn Thêm", "Đồng Ý Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                 

                    hh.them1loaihanghoa(txtMaHangHoa.Text,
                        cboLoaihanghoa.EditValue.ToString(), txtDuongDan.Text,
                        txtTenHangHoa.Text, txtDonViTinh.Text, txtMota.Text, giabanle, giabansi, gianhap, 0);
                    ThongTinHangHoa_Load(sender, e);
                    XtraMessageBox.Show("Thành công");
                }



            }
            if (update)
            {
                if (XtraMessageBox.Show("Bạn có muốn Sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    hh.sua1hh(txtMaHangHoa.Text,
                    cboLoaihanghoa.EditValue.ToString(), txtDuongDan.Text,
                   txtTenHangHoa.Text, txtDonViTinh.Text, txtMota.Text, giabanle,giabansi, gianhap);
                    laydulieuhanghoa();
                    XtraMessageBox.Show("Thành công");
                }
            }
        }

        private void btnHuyBo_Click_2(object sender, EventArgs e)
        {
            ThongTinHangHoa_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }
    }
}


