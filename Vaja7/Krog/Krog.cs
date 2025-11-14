using System;

namespace Projekt.Krog
{
    public class Krog
    {
        private double r;

        // Privzeti konstruktor
        public Krog()
        {
            r = 1;
        }

        // Konstruktor z argumentom
        public Krog(double r)
        {
            this.r = r;
        }

        // Setter metoda
        public void NastaviR(double r)
        {
            this.r = r;
        }

        // Obseg
        public double Obseg()
        {
            return 2 * Math.PI * r;
        }

        // Ploščina
        public double Ploscina()
        {
            return Math.PI * r * r;
        }
    }
}
