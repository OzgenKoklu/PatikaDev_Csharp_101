using System;

namespace constructorMethods
{
        //REPODAKİ classConcepts programının geliştirilmiş halidir
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

                Calisan calisan1 = new Calisan("Ayşe", "Kara", 253534, "İnsan kaynakları");

                calisan1.CalisanBilgileri();

                Console.WriteLine("*********");

                Calisan calisan2 = new Calisan();
                calisan2.Ad = "Deniz";
                calisan2.Soyad = "Aslan";
                calisan2.No = 25612;
                calisan2.Departman = "Yazılım";

                calisan2.CalisanBilgileri();

                Console.WriteLine("*********");
                Calisan calisan3 = new Calisan("Hasan", "Nü");
                calisan3.CalisanBilgileri();

        }
            class Calisan
            {
                public string Ad;
                public string Soyad;
                public int No;
                public string Departman;

           //constructor classlar
                public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
     
            }

            public Calisan() { }
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