using System;

namespace interfaceOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******INTERFACE*****");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("**********");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("******ABSTRACT****");
            NewFocus newfocus = new NewFocus();
            Console.WriteLine(newfocus.HangiMarkanınAraci().ToString());
            Console.WriteLine(newfocus.KacTekerlektenOlusur());
            Console.WriteLine(newfocus.StandartRengiNe().ToString());

            Console.WriteLine("**********");
            NewCivic newcivic = new NewCivic();
            Console.WriteLine(newcivic.HangiMarkanınAraci().ToString());
            Console.WriteLine(newcivic.KacTekerlektenOlusur());
            Console.WriteLine(newcivic.StandartRengiNe().ToString());
        }
    }
}
