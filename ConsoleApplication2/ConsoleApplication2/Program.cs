using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] günler = new string[] { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            Console.Write("bir sayı giriniz=");
            int sayı = Convert.ToInt32(Console.ReadLine());



            foreach (var x in günler)
            {
                Console.WriteLine(x[sayı]);

            }
            Console.ReadLine();
        }
    }
}
