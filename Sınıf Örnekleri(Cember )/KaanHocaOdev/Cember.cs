using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanHocaOdev
{
    internal class Cember
    {
        private double MerkezX { get; set; }
        private double MerkezY { get; set; }
        private double Yaricap { get; set; }
        public Cember(double x, double y, double yaricap)
        {
            MerkezX = x;
            MerkezY = y;
            Yaricap = yaricap;
        }
        public string Yaz()
        {
            return $"Dairenin merkez konumu{MerkezX},{MerkezY} yaricapi ise{Yaricap}";
        }
        public void SetMerkez(double x, double y)
        {
            MerkezX = x;
            MerkezY = y;
        }
        public void SetYarcap(double r)
        {
            Yaricap = r;
        }
        public double GetAlan()
        {
            return (Math.PI * (Math.Pow(Yaricap, 2)));
        }
        public double GetCevre()
        {
            return (2 * Math.PI * Yaricap);
        }

        public double Mesafe(Cember a)
        {
            return (Math.Sqrt(Math.Round(MerkezX - a.MerkezX) + Math.Round(MerkezY - a.MerkezY))) - (Yaricap + a.Yaricap);
        }
        public bool IcindeMi(Cember a)
        {
            double mesafe = (Math.Sqrt(Math.Pow(Math.Abs(MerkezX - a.MerkezX),2) + Math.Pow(Math.Abs(MerkezY - a.MerkezY),2)));   //c=√(x-a.x)^2-(y-a.y)^2

            if (mesafe < Yaricap && a.Yaricap < Yaricap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Cember Buyukolan(Cember b)
        {
            return Yaricap > b.Yaricap ? this : b;
         
        }
        public void TegetYap(char Eksen)
        {
            if (Eksen.ToString().ToUpper() == "X")
            {
                MerkezY = Yaricap;
            }
            else if (Eksen.ToString().ToUpper() == "Y")
            {
                MerkezX = Yaricap;
            }
           
        }

    }
}
