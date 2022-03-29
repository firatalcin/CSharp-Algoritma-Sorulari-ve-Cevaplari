using System;

namespace Harmonik_Sayi_Hesaplama
{
    // C# ile girilen sayının harmonik serisinin toplamını bulan program
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += (1.0/i);
            }

            Console.WriteLine("Girilen sayının Harmonik ortalaması: " + sum);
        }
    }
}
