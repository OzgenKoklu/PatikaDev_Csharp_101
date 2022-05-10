using System;

namespace methodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out peremetreler
            string sayi = "999";
     

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //metot aşırı yükleme - overloading 

            int ifade = 999;
            instance.EkranaYazdir(ifade);

            //metod imzası
            //metod adı + parametre sayısı + parametre
            instance.EkranaYazdir("Özgen", "Köklü");

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        //metod overloading
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + " " + veri2);
        }
    }

}
