using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirtici geri_donustipi metod_adı(parametre listesi/arguman)
            //{
            //komutlar
            //return ;
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            Console.WriteLine(Topla(a, b));
            int sonuc = Topla(5, 7);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir("örnek");
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            ornek.EkranaYazdir(Convert.ToString(ornek.ArttirVeTopla(ref a, ref b)));
            
        }

        //Call by value 
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }


    }



    class Metotlar
    {

        //call by value
        public void EkranaYazdir(String veri)
        {
            Console.WriteLine(veri);

        }

        //call by reference - a ve b artık değişecek
        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2; 
        }
    }
}
