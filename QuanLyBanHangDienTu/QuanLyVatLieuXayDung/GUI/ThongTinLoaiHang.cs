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
using DevExpress.XtraGrid.Views.Grid;
using System.Net;
using System.IO;
using System.IO.Compression;
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLyVatLieuXayDung.GUI
{
    public partial class ThongTinLoaiHang : DevExpress.XtraEditors.XtraUserControl
    {

    
        
        bool add , update;
        
        DALL_BALL_Loaihang lhl = new DALL_BALL_Loaihang();
        bool tinhtrang;
        public ThongTinLoaiHang()
        {
            InitializeComponent();
        }
 
       
        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ThongTinLoaiHang_Load(object sender, EventArgs e)
        {
         hienthi(false);
                xemloaihang();
          //  gridView1.DataSource = lhl.loaddulieuloaihang();
              txtMaLH.Enabled = false;  
                bind(true);
            btnLuu.Enabled = false;
            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            gridView2.OptionsView.ColumnAutoWidth = true;
            gridView2.OptionsView.BestFitMaxRowCount = -1;
            gridView2.BestFitColumns();




        }
        public void bind(bool t)
        {
            if (t)
            {
                txtMaLH.DataBindings.Clear();
                txtMaLH.DataBindings.Add("Text", dsLoaihang.DataSource, "MaLoai");
                txtTenLoaiHang.DataBindings.Clear();
                txtTenLoaiHang.DataBindings.Add("Text", dsLoaihang.DataSource, "TenLoai");
                txtLink.DataBindings.Clear();
                txtLink.DataBindings.Add("Text", dsLoaihang.DataSource, "Linkloaihang");
                //    ckTranThai.DataBindings.Add("Text", dsLoaihang.DataSource, "inhTrangHang");
            }
            else
            {
                txtMaLH.DataBindings.Clear();
                txtTenLoaiHang.DataBindings.Clear();
                txtLink.DataBindings.Clear();
            }
                

        }
        public void hienthi(bool t)
        {

            txtTenLoaiHang.Enabled = t;
            txtLink.Enabled = t;
           
            

        } 
        public void xemloaihang()
        {
            //LoaiHangBUS.Instance.xemloaihang(dsLoaihang);
            //gridView1.Columns[0].Caption = "Mã Loại Hàng";
            //gridView1.Columns[1].Caption = "Tên Loại Hàng";
            //gridView1.Columns[2].Caption = "Diễn Giải";
            List<DALL_BALL.LoaiHang> lst = new List<DALL_BALL.LoaiHang>();
            lst = lhl.loaddulieuloaihang();
            dsLoaihang.DataSource = lst;
          
        }
 
    public bool kiemtradulieu()
        {
            if(txtTenLoaiHang.Text.Length<=0)
            {
                XtraMessageBox.Show("Không Được Bỏ Trống Tên Loại Hàng");
                return false;
            }
            if (txtLink.Text.Length <= 0)
            {
                XtraMessageBox.Show("Không Được Bỏ Trống Diễn Giải");
                return false;
            }
            else
                return true;
           
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
           // khoitao();
            if (add)
            {
                  lhl.them1loaihang(txtMaLH.Text,txtTenLoaiHang.Text,txtLink.Text,tinhtrang,txtDiaChi.Text);
                
                    XtraMessageBox.Show("Thành Công");
                ThongTinLoaiHang_Load(sender, e);
              
            }
            if(update)
            {
               bool kq= lhl.sua1loaihang(txtMaLH.Text, txtTenLoaiHang.Text, txtLink.Text, tinhtrang,txtDiaChi.Text);

                if (kq)
                {
                    XtraMessageBox.Show("Thành Công");
                    ThongTinLoaiHang_Load(sender, e);
                }
                else
                    XtraMessageBox.Show("Thất bại");

            }
        }
        public void resetvalues()
        {
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            add = true;
            update = false;
           // txtMaLH.Enabled = true;
            txtMaLH.Text = "";
            txtLink.Text = "";
            txtTenLoaiHang.Text = "";
            BtnSua.Enabled =false;
            btnLuu.Enabled = true;
            BtnXoa.Enabled = false;
            hienthi(true);
            bind(false);
            if (gridView2.RowCount <= 0)
            {
                txtMaLH.Text = "LH001";
            }
            else
            {
               txtMaLH.Text= lhl.getmaloaihang("LH00");
            }
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            update = true;
            add = false;
            hienthi(true);
            BtnThem.Enabled = false;
            btnLuu.Enabled = true;
            BtnXoa.Enabled = false;
              
    
            
        }
        public async Task<Image> GetImageAsync(string url)
        {
            var tcs = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith(task =>
                {
                    var webResponse = (HttpWebResponse)task.Result;
                    Stream responseStream = webResponse.GetResponseStream();
                    if (webResponse.ContentEncoding.ToLower().Contains("gzip"))
                        responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                    else if (webResponse.ContentEncoding.ToLower().Contains("deflate"))
                        responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

                    if (responseStream != null) webImage = Image.FromStream(responseStream);
                    tcs.TrySetResult(webImage);
                    webResponse.Close();
                    responseStream.Close();
                });
            return tcs.Task.Result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongTinLoaiHang_Load(sender, e);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            lhl.xoahanghoatheoloai(txtMaLH.Text);
            if(lhl.xoa1loaihang(txtMaLH.Text))
            {
                XtraMessageBox.Show("Thành Công");
                ThongTinLoaiHang_Load(sender, e);
            }
          
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
        
        }

        private void dsLoaihang_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtDienGiai_EditValueChanged(object sender, EventArgs e)
        {
            if (txtLink.Text.Length > 0)
            {

                // PictureBox img = new System.Windows.Forms.PictureBox();


                pictureEdit1.LoadAsync(txtLink.Text);
                pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLoaiHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;





            workbook = application.Workbooks.Add(Type.Missing);
            application.Visible = true;
            application.WindowState = Excel.XlWindowState.xlMaximized;
            //getdatabase   
            workbook.Worksheets.Add();
            worksheet = workbook.Sheets[1];


            worksheet.Cells[1, 1] = "Thông Tin Loại Hàng";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã Loại";
            worksheet.Cells[3, 3] = "Tên Loại";
            worksheet.Cells[3, 4] = "Mô Tả";
            worksheet.Cells[3, 5] = "Link Hình ảnh";

            List<LoaiHang> lh = new List<LoaiHang>();
            lh = lhl.loaddulieuloaihang();

            for (int i = 0; i < lh.Count; i++)
            {
                worksheet.Cells[i + 4, 1] = i + 1;
                worksheet.Cells[i + 4, 2] = lh[i].MaLoai;
                worksheet.Cells[i + 4, 3] = lh[i].TenLoai;
                worksheet.Cells[i + 4, 4] = lh[i].Mota;
                worksheet.Cells[i + 4, 5] = lh[i].Linkloaihang;
            }
            // định dạng trang
            worksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            worksheet.PageSetup.TopMargin = 0;

            //định dạng cột

            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "I100"].Font.Size = 14;
            worksheet.Range["A1", "I1"].MergeCells = true;
            worksheet.Range["A1", "I3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "E" + (lh.Count + 3)].Borders.LineStyle = 1;


            // định dạng các dòng
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "I3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "I4" + lh.Count.ToString()].HorizontalAlignment = 3;

            worksheet.Columns.AutoFit();
        }

        private void ckTranThai_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
