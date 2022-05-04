using System;

namespace whileForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1den başlayarak consoledan girilen sayıya kadar (sayı dahil) ortalama hesaplayan consolea yazıran program
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam / sayi);

            //a'dan zye kadar tüm harfleri consolea yazdır.

            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("*****FOREACH*****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
