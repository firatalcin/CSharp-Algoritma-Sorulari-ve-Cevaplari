using System;

namespace Kombinasyon_Hesabi
{
    internal class Program
    {
        /*
        N elemanlı bir kümenin elemanları ile oluşturulacak r elemanlı farklı grupların sayısı 
        n’in r’li kombinasyonu olarak adlandırılır.N’in r’li kombinasyonu C(n, r) şeklinde gösterilir.

        Java ile kombinasyon hesaplayan program yazınız.

        Kombinasyon formülü
        C(n, r) = n! / (r! * (n - r)!)
        */

        static void Main(string[] args)
        {
            Console.WriteLine("N sayısı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r sayısı giriniz: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int fark = n - r;
            int r_fac = 1, n_fac = 1, fark_fac = 1;

            for (int i = 1; i <= n; i++)
            {
                n_fac *= i;
            }

            for (int i = 1; i <= r; i++)
            {
                r_fac *= i;
            }

            for (int i = 1; i <= fark; i++)
            {
                fark_fac *= i;
            }

            Console.WriteLine("Sonuc: " + (n_fac / (r_fac * fark_fac)));

        }
    }
}
