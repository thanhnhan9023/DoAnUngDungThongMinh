using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_BALL
{
    public class DALL_BALL_PhanQuyencs
    {
        QLBanHangDataContext data = new QLBanHangDataContext();


        public List<PhanQuyenDTOcs>  laydsquyen(string macv,int manhinh)
        {
            var ds = from k in data.PhanQuyens where
                    k.Macv == macv && k.Mamanhinh == manhinh select new PhanQuyenDTOcs
                    {
                    
                        quyen =(int)k.Quyen
                        
                  };
            return ds.ToList();
                   
                   
        }
        public int xetquyen(string macv,int mamnhinh)
        {
            int quyen = 0;
            PhanQuyen  phan= data.PhanQuyens.Where(t => t.Macv == macv && t.Mamanhinh == mamnhinh).FirstOrDefault();
            return quyen =(int)phan.Quyen;
        }
        
    }

}

