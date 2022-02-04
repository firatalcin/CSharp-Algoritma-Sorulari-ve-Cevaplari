using System;

namespace Dik_Ucgende_Hipotenus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dik Üçgende Hipotenüs Bulan Program
             C# ile kullanıcıdan dik kenarlarının uzunluğunu alan ve 
             hipotenüsü hesaplayan programı yazın.

             Ödev
             Üç kenar uzunluğunu kullanıcıdan aldığınız üçgenin alanını hesaplayan programı yazınız.

             Formül
             Üç𝑔𝑒𝑛𝑖𝑛 ç𝑒𝑣𝑟𝑒𝑠𝑖 = 2𝑢

             𝑢 = (a+b+c) / 2

             Alan * Alan = 𝑢 * (𝑢 − 𝑎)* (𝑢 − 𝑏) * (𝑢 − 𝑐)
             */


            // hipotenüs bulma

            //Console.WriteLine("1. Kenarı giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Kenarı giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //double c = Math.Sqrt((a * a + b * b));

            //Console.WriteLine("Hipotenüs: " + c);

            // Üçgen Çevresi Ve Alanı Bulma

            Console.WriteLine("1. Kenarı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Kenarı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Kenari giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double u = (a + b + c) / 2;

            Console.WriteLine("Üçgenin Çevresi: " + (2 * u));

            double alan = Math.Sqrt(u * (u - a) * (u - b) * (u - c));

            Console.WriteLine("Üçgenini Alanı: " + alan);
        }
    }
}
