using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //              Canlılar
            //          |               |
            //      Bitkiler        Hayvanlar
            //     |        |       |       |
            //  Tohumlu   Tohumsuz Surungen  Kuslar

            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            tohumlubitki.TohumlaCogalma();

            Console.WriteLine("************");

            Kuslar martı  = new Kuslar();
            martı.Ucmak();


        }
    }
}
