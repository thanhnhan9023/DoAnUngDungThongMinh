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
    public partial class QuanTriNgD : DevExpress.XtraEditors.XtraUserControl
    {
       
        bool add = false, update = false;
   
        DALL_QuantriNguoiDung qtringdung = new DALL_QuantriNguoiDung();
        DALL_BALL_Login login = new DALL_BALL_Login();
        DALL_BALL_NhanVien nv = new DALL_BALL_NhanVien();
        public QuanTriNgD()
        {
            InitializeComponent();
        }

        public void QuanTriNgD_Load(object sender, EventArgs e)
        {
            hienthi(true);
                
           
            txtPassWord.Properties.UseSystemPasswordChar = true;
            txtPasswordX2.Properties.UseSystemPasswordChar = true;
            loaddstk();
            loadcomboxnv();
            
        }

        public void loaddstk()
        {
           dstaikhoan.DataSource=qtringdung.loaddachsachtaikhoan();
        }
        public void khoitao()
        {

           
            
       
        }
        public void xemtaikhoan()
        {

           

        }
        public void loadcomboxtk()
        {

        }
        public void bind()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dstaikhoan.DataSource, "UserName");
            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("Text", dstaikhoan.DataSource, "Loai");
          
        }
        public void hienthi(bool t)
        {
            if (t)
            {
                txtPassWord.Enabled = false;
                txtTaiKhoan.Enabled = false;
                btnLuu.Enabled = false;
                
              
                txtPasswordX2.Enabled = false;
             
            }
            else
            {
                if(gridView1.RowCount>=0)
                {
                    cboNhanVien.Enabled = true;
                   
                }
                txtPasswordX2.Enabled = true;
                txtPassWord.Enabled = true;
                txtTaiKhoan.Enabled = true;
                btnLuu.Enabled = true;
              
            }
        }
        public void hienthi2(bool t)
        {

            if (t)
            {
            
                txtPassWord.Enabled = false;
                
                
                txtPasswordX2.Enabled = false;

                btnLuu.Enabled = true;

            }
            else
            {
                txtTaiKhoan.Enabled = false;
                txtPasswordX2.Enabled = true;
                txtPassWord.Enabled = true;
                txtTaiKhoan.Enabled = true;
                btnLuu.Enabled = true;
             
            }


        }
        public void loadtheocombox()
        {
         
       }
        public bool hamkiemtrahople(string x)
        {
            x = txtPassWord.Text;
            if(txtPasswordX2.Text==x)
            {
                return true;
            }
            return false;
        }



        private void cboNguoiDung_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
         
       
        }
    

          

        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            khoitao();
            DialogResult rs;
            rs = XtraMessageBox.Show("Bạn Có Muốn ResetPassWord","Có",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(rs==DialogResult.Yes)
            {
            }
        }

        public void resetvalues()
        {
            txtTaiKhoan.Text = "";
            txtPasswordX2.Text = "";
            txtPassWord.Text = "";
            
        }
        public void loadcomboxnv()
        {
            cboNhanVien.DataSource = nv.loaddulieuNhanVien();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            khoitao();
            if(add)
            {      
                string s = txtPasswordX2.Text;

                qtringdung.them1nguoidung(txtTaiKhoan.Text, cboNhanVien.SelectedValue.ToString(), login.SHA256(s));
                QuanTriNgD_Load(sender, e);


                XtraMessageBox.Show("Thành công");
               
             }
            if(update)
            {
             
            }
               
        }

        private void cboNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true;
       //     cohieu = true;
            add = false;
            txtTaiKhoan.Enabled = false;
            txtPasswordX2.Enabled = true;
            txtPassWord.Enabled = true;
            txtPassWord.Text = "";
            txtPasswordX2.Text = "";
            btnLuu.Enabled = true;
          
            
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            QuanTriNgD_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khoitao();
            DialogResult rs;
            rs = XtraMessageBox.Show("Bạn Có Muốn Xóa Không", "Có", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Yes)
            {

                qtringdung.xoa1nguoidung(txtTaiKhoan.Text);

                QuanTriNgD_Load(sender, e);
            }
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {
            
        }

        private void ckTrangThai_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void ckTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            update = false;
            resetvalues();
            hienthi(false);
        }
    }
}
