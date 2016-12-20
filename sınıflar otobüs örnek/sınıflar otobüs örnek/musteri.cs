using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar_otobüs_örnek
{
    class musteri
    {
        public string adsoyad;
        public bool cinsiyet;
        public string otobüstürü;
        public override string ToString()
        {
            return this.adsoyad+"\t"+cinsiyet+"\t" + otobüstürü;
        }
    }
}
