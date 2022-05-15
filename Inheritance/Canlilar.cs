using System;


namespace Inheritance
{
    public class Canlilar //sealed class yap�l�rsa hi�kimse ondan inherit edemez.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canl�lar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canl�lar Solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canl�lar bo�alt�m yapar.");
        }

        public virtual void uyaranlaraTepki()
        {
            Console.WriteLine("Canl�lar uyaranlara tepki verir.");
        }
    }
}