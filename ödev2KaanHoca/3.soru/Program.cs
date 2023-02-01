using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kaçıncı Asal Sayıyı Arıyorsunuz?");//sorunda 10001 i istiyor
            int arananAsal = int.Parse(Console.ReadLine());

            Console.WriteLine(ArananAsal(arananAsal));
            Console.ReadKey();

        }

        static int ArananAsal(int arananKacinciAsal)
        {
            int sayac = 0, asalSayac = 0, arananAsal=0;
            for (int i = 2; i < int.MaxValue; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }

                }
                if (sayac == 0)//sayaç 0 den büyükse sayı asal değildir
                {
                    asalSayac++;//asal sayı bulunursa asalsayaçı artır

                }
                sayac = 0;
                if (asalSayac == arananKacinciAsal)
                {
                    arananAsal = i;
                    i = int.MaxValue - 1;
                }
                                
            }
            return arananAsal;
        }
    }
}
