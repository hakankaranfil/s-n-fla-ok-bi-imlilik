using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            Console.Write("bir sayı giriniz= ");
            int çift = 0, tek = 0;
            int sayı = Convert.ToInt32(Console.ReadLine());
            int[] sayılar = new int[sayı];
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = rasgele.Next(-100, 100);

            }
            foreach (int x in sayılar)
            {
                if (x%2==0)
                {
                    çift++;
                }
                else
                {
                    tek++;
                }
            }
            /*Console.WriteLine();*/
            Console.WriteLine("{0} tane çift sayı",çift);
            Console.WriteLine("{0} tane tek sayı var",tek);
            Console.ReadLine();
        }
    }
}
