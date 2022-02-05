using System;

namespace Taksimetre_Programi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Taksimetre Programı

             C# ile gidilen mesafeye (KM) göre taksimetre tutarını ekrana yazdıran programı yazın.

             Taksimetre KM başına 2.20 TL tutmaktadır.
             Minimum ödenecek tutar 20 TL'dir. 20 TL altında ki ücretlerde yine 20 TL alınacaktır.
             Taksimetre açılış ücreti 10 TL'dir.
            */

            Console.WriteLine("Lüften gidilen yolu yazınız(KM): ");
            double km = Convert.ToDouble(Console.ReadLine());

            double Acilis_Ucreti = 10.0;
            double tutar = Acilis_Ucreti + km * 2.20;

            double sonuc = (tutar > 20) ? tutar : 20;

            Console.WriteLine("Taksimetre ücretiniz: " + sonuc);
        }
    }
}
