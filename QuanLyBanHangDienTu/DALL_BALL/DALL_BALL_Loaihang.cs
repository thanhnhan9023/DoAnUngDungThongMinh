using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_BALL
{
   public class DALL_BALL_Loaihang
    {
        TuDongTang tt = new TuDongTang();

        QLBanHangDataContext data = new QLBanHangDataContext();
        public List<LoaiHang> loaddulieuloaihang()
        {
            var dslh = from ds in data.LoaiHangs select ds;

            return dslh.ToList();
        }

        public void them1loaihang(string maloai,string tenloai,string linkloaihang,bool tinhtranghang,string moata)
        {
            LoaiHang lh = new LoaiHang();

          
                lh.MaLoai = maloai;
                lh.TenLoai = tenloai;
                lh.Linkloaihang = linkloaihang;
            lh.Mota = moata;
                data.LoaiHangs.InsertOnSubmit(lh);
                data.SubmitChanges();
             
           

        }


        public bool sua1loaihang(string maloai, string tenloai, string linkloaihang, bool tinhtranghang,string mota)
        {

            LoaiHang lh = new LoaiHang();
            lh = data.LoaiHangs.Where(m => m.MaLoai == maloai).FirstOrDefault();
            if (lh != null)
            {
              //  lh.MaLoai = maloai;
                lh.TenLoai = tenloai;
                lh.Linkloaihang = linkloaihang;
                lh.Mota = mota;

                data.SubmitChanges();
                return true;
            }
            else
                return false;

        }
        public void xoahanghoatheoloai(string maloai)
        {
            
            HangHoa hh = new HangHoa();
            hh = data.HangHoas.Where(t=>t.MaLoai==maloai).FirstOrDefault();
            if(hh!=null)
            {
                data.HangHoas.DeleteOnSubmit(hh);
                data.SubmitChanges();
            }
        }

        public bool xoa1loaihang(string maloai)
        {

            LoaiHang lh = new LoaiHang();
            lh = data.LoaiHangs.Where(m => m.MaLoai == maloai).FirstOrDefault();
            if (lh != null)
            {
                data.LoaiHangs.DeleteOnSubmit(lh);
                data.SubmitChanges();
                return true;
            }
            else
                return false;

        }
        public string getmaloaihang(string y)
        {

            string x = data.LoaiHangs.Max(m => m.MaLoai);
            return tt.laymatudongtang(x, y);

        }

    }
}
