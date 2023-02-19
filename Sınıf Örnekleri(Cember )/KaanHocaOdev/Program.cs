using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanHocaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cember cember1 = new Cember(1,1,10);
            Console.WriteLine(cember1.Yaz()); 
            Console.WriteLine(cember1.GetAlan());
            Console.WriteLine(cember1.GetCevre());

            Cember cember2 = new Cember(2,2,20);

            Console.WriteLine("İçinde mi?");
            Console.WriteLine(cember2.IcindeMi(cember1));
            Console.WriteLine("Büyük olan?");
            Console.WriteLine(cember1.Buyukolan(cember2).Yaz());
            
            cember2.TegetYap('y');
            Console.WriteLine(cember2.Yaz());
            Console.ReadLine();
        }
    }
}
