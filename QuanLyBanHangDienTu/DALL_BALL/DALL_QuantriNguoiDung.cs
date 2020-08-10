using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL_BALL;

namespace DALL_BALL
{
   public class DALL_QuantriNguoiDung
    {

        QLBanHangDataContext data = new QLBanHangDataContext();

                public IQueryable  loaddachsachtaikhoan()
            {
            var ds = from NguoiDungs in data.NguoiDungs
                     select new
                     {
                         NguoiDungs.UserName,
                         NguoiDungs.NhanVien.TenNV,
                         NguoiDungs.NhanVien.MaCV,
                         NguoiDungs.NhanVien.TinhTrang,
                       
                     };
            return ds;
         }

        public void them1nguoidung (string username,string manv,string password)
        {
            NguoiDung nd = new NguoiDung();
            nd.UserName = username;
            nd.MaNV = manv;
            nd.PassWord = password;
          


            data.NguoiDungs.InsertOnSubmit(nd);
            data.SubmitChanges();
           
        }
        public void xoa1nguoidung(string username)
        {
            NguoiDung nd = new NguoiDung();
            nd = data.NguoiDungs.Where(t => t.UserName == username).FirstOrDefault();
            data.NguoiDungs.DeleteOnSubmit(nd);
            data.SubmitChanges();
        }
        
    
    }
}
