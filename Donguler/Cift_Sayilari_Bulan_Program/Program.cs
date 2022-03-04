using System;

namespace Cift_Sayilari_Bulan_Program
{
    public class Program
    {
        /*
        C# döngüler ile kullanıcının girdiği sayıya kadar çift olan sayıları bulan programı yazıyoruz.

        Ödev
        C# döngüler ile 0'dan girilen sayıya kadar olan sayılardan 3 ve 4'e tam bölünen sayıların ortalamasını 
        hesaplayan programı yazınız.

        */

        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("************************************************************************");

            int ort = 0, toplam = 0, sayac = 0;

            for (int i = 0; i < sayi; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    toplam += i;
                    sayac++;
                }
            }
            ort = toplam / sayac;
            Console.WriteLine(ort);

        }
    }
}
