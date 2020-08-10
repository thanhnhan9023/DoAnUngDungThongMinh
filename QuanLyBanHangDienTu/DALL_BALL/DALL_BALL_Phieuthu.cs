using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_BALL
{
   public class DALL_BALL_Phieuthu
    {
        QLBanHangDataContext data = new QLBanHangDataContext();
        public IQueryable loadphieuthu()
        {
            var ds = from k in data.PhieuThus
                     select new
                     {

                         k.MaPhieuThu,
                         k.DoiTuong,
                         k.TrangThai,
                         k.MaNV,
                         k.NhanVien.TenNV,
                         k.Sotienchi,
                         k.Ngayghinhan,
                     };
            return ds;
        }
       public void themphieuthikhithanhtoan(string maphieuthu,string doituong,string trangthai,string manv,long sotienthu,DateTime ngayghinhan)
        {

            using (QLBanHangDataContext data = new QLBanHangDataContext())
            {
                PhieuThu pt = new PhieuThu();
                pt.MaPhieuThu = maphieuthu;
                pt.DoiTuong = doituong;
                pt.TrangThai = trangthai;
                pt.MaNV = manv;
                pt.Sotienchi = sotienthu;
                pt.Ngayghinhan = ngayghinhan;
                data.PhieuThus.InsertOnSubmit(pt);
                data.SubmitChanges();
            }


          
        }

    }
}
