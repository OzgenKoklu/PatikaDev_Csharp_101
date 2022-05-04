using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("Lütfen Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0; 
            for (int i = 0; i<= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;

                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam : " + tekToplam + " Çift Toplam : " + ciftToplam);

            //break ve continue
            
            for (int i = 1; i<10; i++) //for(;;) ile sonsuz döngü sağlanabiliyor
            {
                if (i == 4)
                    break; //4ü gördüğü anda 4'ü atlayıp loopu sonlandırdı
                    //continue; sadece 4'ü atlardı 10a kadar devam ederdi
                Console.WriteLine(i);
            }
        }
    }
}
