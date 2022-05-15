using System;

namespace staticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0]", Calisan.CalisanSayisi);//buna erişildiği için çalışan sayısı set edildi

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan sayısı: {0]", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Oğuz", "Kara", "yazılım");
            Console.WriteLine("Çalışan sayısı: {0]", Calisan.CalisanSayisi);


            //static classa erişim için "[sınıfadı]."şeklinde yapılır.
            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(100, 200));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    //bir sınıfı static yaparsaniz içindeki tüm metodlar statik olmak zorunda.
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }
}

    
