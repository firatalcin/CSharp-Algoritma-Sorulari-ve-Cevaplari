using System;

namespace Basamak_Toplami_Hesaplama
{
    public class Program
    {
        // C# ile kullanıcının girdiği bir sayıyının basamakları toplamını hesaplayan program

        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi;
            int toplam = 0;
            while (temp > 0)
            {
                toplam += temp % 10;
                temp /= 10;
            }

            Console.WriteLine(sayi + " sayısının basamakları toplamı: " + toplam);

        }
    }
}
