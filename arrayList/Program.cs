using System;
using System.Collections;
using System.Collections.Generic;


namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //system collection namespace'ini kullanıyor
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //Icersinde verilere göre erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Addrange
            Console.WriteLine("***Add range ****");
            string[] renkler = { "kırmızı", "sari", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***Sort***");
            //sort durumdan duruma patlıyor çünkü int ve stringi karşılaştıramıyor.

            //BinarySearch 
            Console.WriteLine("*** Binary Search ***");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //clear 
            Console.WriteLine("*** Clear ***");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);



        }
    }
}
