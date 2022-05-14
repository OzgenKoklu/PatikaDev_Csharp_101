using System;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.Sinif = 3;
            ogrenci.OgrenciNo = 252;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 276, 1);
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci{

        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        //{get {return isim;}
        //set {isim = value;}}
        //yukardaki yazım ile aynı şey. 

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => OgrenciNo; set => OgrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set
            {   if(value <= 1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir!");
                    sinif = 1;
                }else
                sinif = value;
            }
        }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci Numarası :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   :{0}", this.Sinif); 
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {

            this.Sinif = this.Sinif - 1;
        }
    }

}
