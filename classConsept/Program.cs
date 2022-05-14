using System;

namespace classConsept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizini
            //Class sinif adı
            //Class SinifAdi
            //{
            //  [Erişim belirliyici] [veri tipi] ÖzellikAdi
            //  [Erişim belirleyici] [geri dönüş tipi] MetodADı(parametre listesi)
            // {
            //  // metod komutları
            // }
            //}

            //erişim belirleyiciler
            // * Public
            // * Private
            // * Internal 
            // * Protected 

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 12514;
            calisan1.Departman= "Insan kaynakları";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Aslan";
            calisan2.No = 25612;
            calisan2.Departman = "Yazılım";

            calisan2.CalisanBilgileri();

        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı:{0}", Ad);
                Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
                Console.WriteLine("Çalışan Numarası:{0}", No);
                Console.WriteLine("Çalışan Departmanı:{0}", Departman);
            }

        }

    }
}

