using System;

namespace structConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classlar default constuctor kullanmasak bile initial değer olarak atama yapabilir
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class alan hesabı: {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct; //= new Dikdortgen_Struct(); structlarda bunu yazmak zorunda değilsiniz.
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            //structlarda değer vermezsek initial değer veremez. stuctlar heap'de değil stackte tutulduğu için performans artışı sağlayabilir. 
            //16 byte'a kadar olan verileriniz için stack, 16+ byte için class daha mantıklı, referans tipinin gücünün avantajı daha fazla.
            Console.WriteLine("Struct alan hesabı: {0}", dikdortgen_struct.AlanHesapla());

        }
    

    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        //default Constuctor'a izin var
        public Dikdortgen()
        {
            KisaKenar = 2;
            UzunKenar = 3;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }


    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        //default Constuctor'a izin yok.

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

}
