using System;

namespace Faktoriyel_Hesaplama
{
    class Program
    {
        // C# ile Kullanıcının girdiği sayının faktoriyelini hesaplayan program
        public static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i; 
            }

            Console.WriteLine(sayi + "! faktöriyel : " + faktoriyel);
        }
    }
}
