using System;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());    
            } //finally kısmı opsiyonal
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.Write("İşlem başarıyla tamamlandı.");
            }

        }
    }
}
