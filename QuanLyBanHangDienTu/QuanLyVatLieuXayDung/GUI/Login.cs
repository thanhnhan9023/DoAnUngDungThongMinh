using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyVatLieuXayDung.GUI;
using DALL_BALL;

namespace QuanLyVatLieuXayDung.GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {

        DALL_BALL_Login logintt = new DALL_BALL_Login();
        public string macv;
        public static string manv = "";
        public static string tennv = "";
      
        public static string tendangnhap;
        public Login()
        {
            InitializeComponent();
            skins();
            
        }

      
      
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Xmas 2008 Blue";

        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
                

            if (txtMatKhau.Text.Length <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu");
                return;
            }
             if (txtDangNhap.Text.Length <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập");
            }

            List<NguoiDung> nd = new List<NguoiDung>();
            nd = logintt.login(txtDangNhap.Text,logintt.SHA256(txtMatKhau.Text));
             if(nd.Count>0)
            {


                macv = logintt.laymacvtuusser(txtDangNhap.Text);

                manv = nd[0].MaNV;
                tennv = nd[0].NhanVien.TenNV;
                this.Hide();
                s s = new s();
                s.Show();
              
          

          
               

               
              
               
            }
         


             
            
        }
              
            
        
       
  

        private void Login_Load(object sender, EventArgs e)
        {
            txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void checkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkhienthi.Checked)
            {

                txtMatKhau.Properties.UseSystemPasswordChar = true;

            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
    }
}