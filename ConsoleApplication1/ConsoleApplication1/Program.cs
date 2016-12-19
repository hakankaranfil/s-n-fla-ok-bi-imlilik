using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] günler = new string[7];
            günler[0] = "pazartesi";
            günler[1] = "salı";
            günler[2] = "çarşambai";
            günler[3] = "perşembe";
            günler[4] = "cuma";
            günler[5] = "cumartesi";
            günler[6] = "pazar";
            
            bool devam = true;
            while (devam)
            {
                Console.Write("bir sayı giriniz=");
                int sayı = Convert.ToInt32(Console.ReadLine());

                if (sayı>=0 && sayı<=7)
            {
                Console.WriteLine("şeçtiğiniz sayıya göre gelen gün=" + günler[sayı - 1]);
            }
                else
                {
                    Console.WriteLine("seçiminize uygun bir gün yok");
                }
                Console.Write("devam etmek istyormusunuz");
            
            
            string cevap = Console.ReadLine();
            if (cevap=="evet")
            {
                devam = true;
            }
            else
            {
                devam = false;
            }
            
            }
            Console.ReadLine();
        }
    }
}
