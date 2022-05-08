using System;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("** Sırassız Dizi**");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("**Sıralı dizi**");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //clear 

            Console.WriteLine("** array clear ** ");
            // sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 elenanı sıfırlar
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //reverse

            Console.WriteLine("** array reverse ** ");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //indexof

            Console.WriteLine("** array indexof ** ");

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //resize
            Console.WriteLine("** array resize ** ");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
