using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,a2 + b2 = c2 For example, 32 + 42 = 9 + 16 = 25 = 52

            //There exists exactly one Pythagorean triplet for which a +b + c = 1000.Find the product abc

            Console.WriteLine("Aradığınız pisagor üçgeni kenar toplamı kaç olacak?");
            
            int kenartoplamı =int.Parse( Console.ReadLine());//soruda 1000 isteniyor
            PisagorBul(kenartoplamı);

        }

        private static void PisagorBul(int aranan)
        {
         

            for (int a = 1; a < int.MaxValue; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    int sayı = (int)(Math.Pow(a, 2) + Math.Pow(b, 2));

                    for (int c = 1; c < a + b; c++)
                    {
                        if ((int)Math.Pow(c, 2) == sayı && a + b + c == aranan)
                        {
                            Console.WriteLine($"{b}*{a}*{c}={a * b * c}");
                        }
                    }
                }

            }
        }
    }
}
