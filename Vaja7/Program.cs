using Projekt.Krog;
using System;

class Program
{
    static void Main(string[] args)
    {
        Krog k1 = new Krog(5);
        Krog k2 = new Krog(6);

        Console.WriteLine("Ploščina kroga k1 = " + k1.Ploscina());
        Console.WriteLine("Ploščina kroga k2 = " + k2.Ploscina());
    }
}
