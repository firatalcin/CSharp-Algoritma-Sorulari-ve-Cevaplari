using System;

namespace Ebob_Hesaplama
{
    internal class Program
    {
        // C# ile EBOB Hesabı
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int i = 2, ebob = 1;
            while (number1 % i == 0 && number2 % i == 0)
            {
                ebob *= i;
                number1 /= i;
                number2 /= i;
                if (number1 % i == 0 && number2 % i == 0)
                {
                    i--;
                }
                i++;
            }
            Console.WriteLine("----------------");
            Console.WriteLine("EBOB sonucu: " + ebob);
        }
    }
}
