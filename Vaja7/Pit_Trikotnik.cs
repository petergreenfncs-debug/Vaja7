using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja7
{
    class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;

        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public Pit_Trikotnik(double a, double b)
        {
            c = Math.Sqrt(a * a + b * b);
        }

        public void Nastavi_Vrednosti(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Ploscina()
        {
            return (a * b) / 2;
        }

        public double Obseg()
        {
            return a + b + c;
        }
    }
}
