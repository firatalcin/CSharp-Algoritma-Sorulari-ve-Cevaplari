using System;

namespace Tek_Sayilarin_Toplami
{
    internal class Program
    {
        /*
        C# döngüler ile negatif bir değer girilene kadar kullanıcıdan girişleri kabul eden ve 
        girilen değerlerden tek sayıları toplayıp ekrana basan programı yazıyoruz.

        Ödev
        C# döngüler ile tek bir sayı girilene kadar kullanıcıdan girişleri kabul eden ve 
        girilen değerlerden çift ve 4'ün katları olan sayıları toplayıp ekrana basan programı yazıyoruz.
        */
        static void Main(string[] args)
        {

            int sayi = 0, toplam = 0;

            do
            {
                Console.WriteLine("Sayi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi % 2 == 1)
                {
                    toplam += sayi;
                }

            } while (sayi > 0);

            Console.WriteLine("Toplam: " + toplam);

            Console.WriteLine("******************************************************************************************");
            toplam = 0;
            do
            {
                Console.WriteLine("Sayi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 4 == 0)
                {
                    toplam += sayi;
                }
            } while (sayi % 2 == 0);

            Console.WriteLine("Toplam: " + toplam);

        }
    }
}
