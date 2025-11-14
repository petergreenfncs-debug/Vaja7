using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaja7.Pravokotnik;

namespace Vaja7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pravokotnik p1 = new Pravokotnik(3, 3);

            Pravokotnik p2 = new Pravokotnik(6, 4);

            Console.WriteLine("Ploščina prvega pravokotnika: " + p1.Ploscina());
            Console.WriteLine("Ploščina drugega pravokotnika: " + p2.Ploscina());

        }
    }
}
