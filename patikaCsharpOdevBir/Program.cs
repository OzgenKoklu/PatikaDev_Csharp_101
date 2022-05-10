using System;
using System.Collections.Generic;

namespace patikaCsharpOdevBir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ODEV 1.1 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            ///Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Öncelikle bir tam sayı gireceksiniz, sonra bu tam sayı miktarında sayı girmeniz istenecek, çift olanlar ekrana yazdırılacak -> ");
            int numbersToEnter1 = 0;
            
            do
            {
                Console.Write("Pozitif bir tamsayı giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out numbersToEnter1) && numbersToEnter1 > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (numbersToEnter1 <= 0);

            Console.WriteLine(numbersToEnter1 + " tane pozitif sayı giriniz");

            List<int> numberList1 = new List<int>();

            for (int i = 0; i<numbersToEnter1; i++)
            {
                int girdi = 0;
                do //çok fazla tekrarlı kod oldu. iyi bir practice olmadığının farkındayım. Hızlı hızlı ödevi yapmaya çalıştım. Abstraction kullanmadım.
                {
                    Console.Write("Pozitif bir tamsayı giriniz -> ");
                    if (int.TryParse(Console.ReadLine(), out girdi) && girdi > 0)
                        break;
                    Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

                } while (girdi <= 0);

                if (girdi % 2 == 0)
                    numberList1.Add(girdi);
            }

           numberList1.ForEach(Console.WriteLine);

            //ODEV 1.2 Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("N ve M değeri girin, sonra N kadar pozitif sayı girdikten sonra M'e eşit veya tam bölünenler ekrana yazılacak -> ");
            int sayiN = 0;
            int sayiM = 0;

            do
            {
                Console.Write("Bir adet N değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out sayiN) && sayiN > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (sayiN <= 0);

            do
            {
                Console.Write("Bir adet M değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out sayiM) && sayiM > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (sayiN <= 0);

            List<int> numberList2 = new List<int>();

            for (int i = 0; i < sayiN; i++)
            {
                int girdi = 0;
                do 
                {
                    Console.Write("Pozitif bir tamsayı giriniz -> ");
                    if (int.TryParse(Console.ReadLine(), out girdi) && girdi > 0)
                        break;
                    Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

                } while (girdi <= 0);

                if (girdi == sayiM || girdi%sayiM == 0)
                    numberList2.Add(girdi);
            }
            numberList2.ForEach(Console.WriteLine);

            //ODEV 1.3 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Pozitif bir N sayısı girin, sonra N adet kelime girmeniz istenecek, sonra yazdığınız kelimeler baştan sonra sıralanacak -> ");
            int kelimeSayisiN = 0;

            do
            {
                Console.Write("Bir adet N değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out kelimeSayisiN) && kelimeSayisiN > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (kelimeSayisiN <= 0);

            List<string> kelimeList1 = new List<string>();

            for (int i = 0; i < kelimeSayisiN; i++)
            {
                string girdi = Console.ReadLine();
                kelimeList1.Add(girdi);
            }
            kelimeList1.Reverse();
            kelimeList1.ForEach(Console.WriteLine);

           //ODEV 1.4 Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
           Console.WriteLine("Noktayla biten bir cümle yazın. Daha sonrasında Cümledeki toplam harf ve kelime sayıları ekrana yazılacak -> ");
            int harfSayisi = 0;
            int kelimeSayisi = 1;
            string cumle = Console.ReadLine();

            for(int i = 0; i <= cumle.Length - 1; i++)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (cumle[i] == ' ' || cumle[i] == '\n' || cumle[i] == '\t')
                {
                    kelimeSayisi++;
                }
                if(cumle[i] != ' ' && cumle[i] != '.')
                harfSayisi++;
            }

            Console.WriteLine("Kelime sayisi: " + kelimeSayisi + " Harf Sayısı: " + harfSayisi);

        }
    }
}
