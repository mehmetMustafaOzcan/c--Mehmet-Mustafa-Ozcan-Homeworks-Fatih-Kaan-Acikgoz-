using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2KaanHoca
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int aranansayi = 20;
            EKadarBölünenSayı(aranansayi);//Dışarıdan değişkende gönderebiliriz.
            Console.ReadLine();
        }

        private static void EKadarBölünenSayı(int sayi)
        {
            int sayac = 0;

            for (int i =sayi ; i < int.MaxValue; i++)
            {
                for (int j = 2; j <= sayi; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;

                    }
                    else
                    {
                        j = 21;
                    }

                }
                if (sayac == sayi-1)
                {
                    Console.WriteLine(i);
                    i = int.MaxValue - 1;
                }
                sayac = 0;
            }
        }
    }
}
