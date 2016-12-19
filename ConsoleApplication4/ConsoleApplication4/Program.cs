using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılar = new List<int>(new int[] { 4, 7, 8, 12, 4 });
            var büyük = sayılar.FindAll(l=> l > 5);
            foreach (var item in büyük)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
