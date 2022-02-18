using System;

namespace Sayi_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aklından bir sayı tut ve söyleme sonra enter tuşuna bas");
            Console.ReadLine();
            Console.WriteLine("Tuttuğun sayıyı iki ile çarp ve enter tuşuna bas");
            Console.ReadLine();
            Console.WriteLine("Bulduğun sonucu belirlediğin ikinci bir sayı ile topla ve bu ikinci sayıyı ekrana yazdıktan sonra enter tuşuna bas");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bulduğun sonucu ikiye böl ve enter tuşuna bas");
            Console.ReadLine();
            Console.WriteLine("Bulduğun sonuçtan ilk tuttuğun sayıyı çıkar ve enter tuşuna bas");
            Console.ReadLine();
            double tahmin = (number / 2);
            Console.WriteLine("Galiba tahmin ediyorum. Bulduğun sayı = " + tahmin);
        }
    }
}
