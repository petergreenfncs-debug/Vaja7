using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pit_Trikotnik Trikotnik1 = new Pit_Trikotnik(6, 8);

            Console.WriteLine(Trikotnik1.Ploscina());
        }
    }
}
