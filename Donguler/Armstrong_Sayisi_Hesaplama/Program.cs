using System;

namespace Armstrong_Sayisi_Hesaplama
{
    class Program
    {
        /*
        
        Armstrong Sayı Nedir ?
        N haneli bir sayının basamaklarının n’inci üstlerinin toplamı, sayının kendisine eşitse, böyle sayılara Armstrong sayı denir.

        Örneğin 407 sayısını ele alalım. (4^3)+ (0^3)+(7^3) = 64+0+343 = 407 sonucunu verir. Bu da 407 sayısının armstrong bir sayı olduğunu gösterir.

        1342 sayısına da bakalım. (1^4)+(3^4)+(4^4)+(2^4) =1+81+256+16=354 sayısı 1342’ye eşit olmadığı için armstrong sayı olmaz.
        
        */
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi, basamak_sayisi = 0, basamak = 0,toplam = 0;

            while (temp > 0)
            {
                temp = temp / 10;
                basamak_sayisi++;
            }

            temp = sayi;

            while (temp > 0)
            {
                basamak = temp % 10;
                temp = temp / 10;
                toplam += UstAlma(basamak,basamak_sayisi); // Üst alma işlemini method ile kendimiz yaptık. Math.Pow() da kullanılabilir.
            }


            if (toplam == sayi)
            {
                Console.WriteLine("Bu sayi Armstrong sayısıdır.");
            }
            else
            {
                Console.WriteLine("Bu sayi Armstrong sayısı değildir.");
            }
        }

        static int UstAlma(int a, int b)
        {
            int toplam = 1;
            for (int i = 1; i <= b; i++)
            {
                toplam *= a;
            }
            return toplam;
        }
    }
}
