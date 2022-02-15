using System;

namespace Hesap_Makinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# ile basit hesap makinesini switch-case kullanarak yapınız.

            Console.WriteLine("1. Sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama: 1\nÇıkarma: 2\nÇarpma: 3\nBölme: 4");
            Console.WriteLine("Bir işlem giriniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
                    break;
                case 2:
                    Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
                    break;
                case 3:
                    Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
                    break;
                case 4:
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }


            
        }
    }
}
