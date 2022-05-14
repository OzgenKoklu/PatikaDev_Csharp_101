using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system collections generic
           Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yıldırım");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(31, "Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("****Elemanlara erişim****");
            Console.WriteLine(kullanıcılar[12]);

            foreach(var item in kullanıcılar)
                Console.WriteLine(item);

            //COunt;
            Console.WriteLine(kullanıcılar.Count);

            //Contains;
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye"));

            //remove
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item.Value);

            //keys & values
            Console.WriteLine("Keys");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            Console.WriteLine("Valuess");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);
        }
    }
}
