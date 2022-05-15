using System;

namespace Inheritance
{
     public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void uyaranlaraTepki()
        {
            base.uyaranlaraTepki();
            Console.WriteLine("Hayvanlar Temasa Tepki verir.");
        }
    }

    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.uyaranlaraTepki();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.uyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuþlar uçara.");
        }
    }

}