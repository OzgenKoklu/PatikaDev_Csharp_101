using System;


namespace Inheritance
{
    public class Canlilar //sealed class yapýlýrsa hiçkimse ondan inherit edemez.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlýlar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlýlar Solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlýlar boþaltým yapar.");
        }

        public virtual void uyaranlaraTepki()
        {
            Console.WriteLine("Canlýlar uyaranlara tepki verir.");
        }
    }
}