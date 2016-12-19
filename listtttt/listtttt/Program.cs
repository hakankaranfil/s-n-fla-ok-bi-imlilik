using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listtttt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılar = new List<int>(new int[] { 2, 7, 4, 5, 6});

            //for (int i = 0; i < sayılar.Count; i++)
            //{
                var büyük = sayılar.FindAll( i => i > 5);
            //}

            foreach (var item in büyük)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
