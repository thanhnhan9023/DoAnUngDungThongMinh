using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_BALL
{
   public class DALL_BALl_Khocs
    {
        QLBanHangDataContext data = new QLBanHangDataContext();
        public IQueryable loadulieukho()
        {
            var ds = from k in data.Khos select new { k.IDKho, k.HangHoa.TenHH, k.SoLuong };
            return ds;
        }
        public void xoa1kho(string makho)
        {
            Kho kh = new Kho();
            kh = data.Khos.Where(t => t.IDKho == makho).FirstOrDefault();
            data.Khos.DeleteOnSubmit(kh);
            data.SubmitChanges();
        }
        public IQueryable loadkhotheoloai(string maloai)
        {
            var ds = from Khos in data.Khos
                     where
                       Khos.HangHoa.LoaiHang.MaLoai == maloai
                     select new
                     {
                         Khos.IDKho,
                         Khos.HangHoa.TenHH,
                         Khos.SoLuong
                     };
            return ds;
        }

    }
}
