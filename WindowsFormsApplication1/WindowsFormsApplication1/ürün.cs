using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public class URUN
    {
        public string ürünadı { get; set; }
        public double Fiyat { get; set; }
        public double kdvhesapla()
        {
            return Fiyat*1.08;
        }
        public URUN()
        {

        }
        public URUN(string ad,double fiyat)
        {
            ad = ürünadı;
            Fiyat = fiyat;
        }
    }
}
