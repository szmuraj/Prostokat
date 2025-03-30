using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    class Prostokat
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        public double Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        public double Obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }

        public void Wypisz()
        {
            Console.WriteLine($"Powierzchnia: {Powierzchnia()}\nObwód: {Obwod()}");
        }
    }
}
