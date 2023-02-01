using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;//herhangi bir değişken gönderilebilir.
            Console.WriteLine(KarelerveToplamlarKaresi(sayi)); 

            Console.ReadKey();
        }

        private static int KarelerveToplamlarKaresi(int sayi)
        {
            int kare = 0, sum = 0;
            for (int i = 1; i <= sayi; i++)
            {
                kare += (int)Math.Pow(i, 2);

                sum += i;
            }

            return (int)Math.Pow(sum, 2) - kare;
        }
    }
}
