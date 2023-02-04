using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAsoru4
{

    internal class Program
    {
        static int EnBüyükPalindrom(int basamaksayisi)
        {
            //int basamaksayisi = int.Parse(Console.ReadLine());
            int sayac = 0, enbuyuk = 0;
            int bassay = (int)Math.Pow(10, basamaksayisi);

            string metin = "";
            for (int z = bassay / 10; z < bassay; z++)
            {
                for (int j = bassay / 10; j <= bassay; j++)
                {
                    string k = (z * j).ToString();

                    for (int i = 0; i < k.Length / 2; i++)
                    {

                        if (k[i] == k[(k.Length - 1) - i])
                        {
                            sayac++;

                        }
                    }
                    if (sayac == (k.Length / 2) && (z * j) > enbuyuk)
                    {
                        metin = $"{z}*{j}";
                        enbuyuk = Convert.ToInt32(k);


                    }
                    sayac = 0;

                }
            }
            return enbuyuk;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(EnBüyükPalindrom(4));

            Console.ReadLine();

        }

        
    }
}
