using System;

namespace ifElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11){
                Console.WriteLine("Günaydın!");
              }else if(time <= 18)
            {
                Console.WriteLine("Iyı Gunler!");
            }
            else
            {
                Console.WriteLine("Iyı geceler!");
            }
            string sonuc = time <= 18 ? "Iyı Günler" : "Iyı geceler";

            sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "Iyı Gunler!" : "Iyı Geceler!";
            Console.WriteLine(sonuc);
        }
    }
}
