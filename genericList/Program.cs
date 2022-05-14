using System;
using System.Collections.Generic;

namespace genericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //Ststem.Collections.Generic
            //T-> object Türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(2);
            sayiListesi.Add(41);
            sayiListesi.Add(213);
            sayiListesi.Add(32);
            sayiListesi.Add(14);
            sayiListesi.Add(12);
            sayiListesi.Add(23);
            sayiListesi.Add(23);
            sayiListesi.Add(235);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Siyah");
            renkListesi.Add("Kahverengi");
            renkListesi.Add("Bordo");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //foreach ile yazdırma
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Sarı");

            //indisten çıkarma
            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);

            //Liste İçersinde arama

            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içersinde bulundu!");

            //eleman ile index'e erişme.
            Console.WriteLine(renkListesi.BinarySearch("Kahverengi"));

            //Diziyi List'e çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<String>(hayvanlar);

            //Listeyi nasıl temizleriz? 
            hayvanListesi.Clear();

            //List içersinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;
            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Fikir";
            kullanıcı2.Yas = 21;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
            Isim = "Deniz",
            Soyisim = "Arda",
            Yas = 21

            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yasi: " + kullanıcı.Yas);
            }
        }
    }
    


    public class Kullanıcılar
    {
       private string isim;
       private string soyisim;
       private int yas;

        //encapsulation örneği
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}
