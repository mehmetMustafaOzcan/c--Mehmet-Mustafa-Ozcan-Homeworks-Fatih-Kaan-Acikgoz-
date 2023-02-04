using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca3ve5
{
    internal class Program
    {
        static int GetBolumToplam(int sayi)
        {

            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    toplam += i;
                }
            }
            return toplam;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetBolumToplam(1000)); 
            Console.ReadKey();
        }

         
    }
}
