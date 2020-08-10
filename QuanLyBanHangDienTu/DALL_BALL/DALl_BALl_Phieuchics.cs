using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_BALL
{
 public   class DALl_BALl_Phieuchics
    {
        QLBanHangDataContext data = new QLBanHangDataContext();
      
        public IQueryable loadphieuchi()
        {
           
                var ds = from k in data.PhieuChis
                         select new
                         {

                             k.MaPhieuChi,
                             k.DoiTuong,
                             k.TrangThai,
                             k.MaNV,
                             k.NhanVien.TenNV,
                             k.Sotienchi,
                             k.NgayGhiNhan,
                         };
                return ds;
           
           
        }

        public void them1phieuchi(string mapc,string manv,string doituong,DateTime ngaylap,string trangthai,long sotienchi)
        {
          
            using (QLBanHangDataContext data = new QLBanHangDataContext())
            {
                PhieuChi pc = new PhieuChi();
                pc.MaPhieuChi = mapc;
                pc.MaNV = manv;
                pc.NgayGhiNhan = ngaylap;
                pc.TrangThai = trangthai;
                pc.Sotienchi = sotienchi;
                pc.DoiTuong = doituong;
                data.PhieuChis.InsertOnSubmit(pc);
                data.SubmitChanges();
            }



        }
    }


}
