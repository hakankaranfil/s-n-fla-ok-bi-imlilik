using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication15
{
    class müsteri
    {
        public string adsoyad;
        public bool ev;
        public bool şirket;
        public double ödeme;


        public override string ToString()
        {
            return this.adsoyad + " " + ödeme;
        }
    }
}
