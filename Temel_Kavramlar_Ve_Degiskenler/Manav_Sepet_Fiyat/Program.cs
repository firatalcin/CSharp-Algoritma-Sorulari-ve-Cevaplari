using System;

namespace Manav_Sepet_Fiyat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Manav Kasa Programı
             C# ile kullanıcıların manavdan almış oldukları ürünlerin kilogram değerlerine göre toplam tutarını 
            ekrana yazdıran programı yazın.

             Meyveler ve KG Fiyatları

             Armut : 2,14 TL
             Elma : 3,67 TL
             Domates : 1,11 TL
             Muz: 0,95 TL
             Patlıcan : 5,00 TL

             Örnek Çıktı;

             Armut Kaç Kilo ? :0
             Elma Kaç Kilo ? :1
             Domates Kaç Kilo ? :1
             Muz Kaç Kilo ? :2
             Patlıcan Kaç Kilo ? :3
             Toplam Tutar : 21.68 TL
             */


            Console.Write("Armut Kaç Kilo ? : ");
            int armut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Elma Kaç Kilo ? : ");
            int elma = Convert.ToInt32(Console.ReadLine());
            Console.Write("Domates Kaç Kilo ? : ");
            int domates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Muz Kaç Kilo ? : ");
            int muz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patlıcan Kaç Kilo ? : ");
            int patlican = Convert.ToInt32(Console.ReadLine());

            double toplam = ((armut * 2.14) + (elma * 3.67) + (domates * 1.11) + (muz * 0.95) + (patlican * 5.00));


            Console.Write("Toplam Tutar : " + toplam);
        }
    }
}
