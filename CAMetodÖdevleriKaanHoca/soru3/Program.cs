using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace soru3
{
    internal class Program
    {
        static long GetEnBüyükAsal(long sayi)
        {
            
            int sayac = 0, asal = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 2)
                    {
                        asal = i;
                    }
                    else
                    {
                        sayi = sayi / i;
                    }
                    sayac = 0;
                }

            }
            return asal;

        }
        static void Main(string[] args)
        {
            long sayi = Int64.Parse(Console.ReadLine());
            
            Console.WriteLine(GetEnBüyükAsal(sayi));

            Console.ReadKey();
        }
    }
}
