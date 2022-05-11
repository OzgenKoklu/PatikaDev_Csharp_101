using System;

namespace stringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, hoşgeldiniz!"; 
            string degisken2 = "Csharp";

            //length
            Console.WriteLine(degisken.Length);

            //toUpper, toLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Özgen"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //padleft, padright;
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '+'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0, 1));

            //replace
            Console.WriteLine(degisken.Replace("Csharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //split 
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
