﻿using System;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve işlem atama operatorleri");
            //atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("Mantıksal operatorler");
            //mantıksal operatorler || %% !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            Console.WriteLine("ilişki operatorleri");
            //ilişki operatörleri
            //<, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("Aritmatik operatörler");
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            // % mod almak için kullanılır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}