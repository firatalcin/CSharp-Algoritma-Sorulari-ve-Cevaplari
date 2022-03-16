using System;

namespace Uslu_Sayi_Hesaplama
{
    internal class Program
    {
        /*
        Ödev
        C# ile kullanıcının girdiği değerler ile üslü sayı hesaplayan programı "For Döngüsü" kullanarak yapınız.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Taban sayısını giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üst sayısını griniz: ");
            int ust = Convert.ToInt32(Console.ReadLine());

            int sonuc = 1;
            for (int i = 1; i <= ust; i++)
            {
                sonuc *= taban;
            }

            Console.WriteLine(taban + "'ın " + ust + " kuvveti : " + sonuc);
        }
    }
}
