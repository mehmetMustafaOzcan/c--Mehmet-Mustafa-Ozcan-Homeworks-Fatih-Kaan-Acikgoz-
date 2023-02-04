using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMetodÖdevleriKaanHoca
{
    internal class Program
    {
        static int GetFibonacci(int sayi)
        {
            int fb = 1; int fb2 = 2, toplam = 0;

            while (fb2 < sayi)
            {
                int yfb = fb2;

                fb2 = fb2 + fb;

                fb = yfb;

                if (fb % 2 == 0)
                {
                    toplam += fb;
                }
            }
            return toplam;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetFibonacci(50)); 



            Console.ReadKey();
        }


    }
}


