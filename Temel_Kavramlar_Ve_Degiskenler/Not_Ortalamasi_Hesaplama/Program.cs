using System;

namespace Not_Ortalamasi_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Not Ortalaması Hesaplayan Program
            C# ile Matematik, Fizik, Kimya, Türkçe, Tarih, Müzik derslerinin 
            sınav puanlarını kullanıcıdan alan ve ortalamalarını hesaplayıp ekrana 
            bastırılan programı yazın.

            Ödev
            Aynı program içerisinde koşullu ifadeler kullanılarak, eğer kullanıcının 
            ortalaması 60'dan büyük ise ekrana "Sınıfı Geçti" , küçük ise "Sınıfta Kaldı" yazsın.

            Not : If ve Else kullanılmayacak...
            */

            Console.WriteLine("Matematik notunuzu giriniz: ");
            int Matematik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fizik notunuzu giriniz: ");
            int Fizik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kimya notunuzu giriniz: ");
            int Kimya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Türkçe notunuzu giriniz: ");
            int Turkce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tarih notunuzu giriniz: ");
            int Tarih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müzik notunuzu giriniz: ");
            int Muzik = Convert.ToInt32(Console.ReadLine());

            double ort = (Matematik + Fizik + Kimya + Turkce + Tarih + Muzik) / 6;

            Console.WriteLine("Ortalama: " + ort);

            String sonuc = (ort > 60) ? "Sınıfı Geçti" : "Sınıfta Kaldı";

            Console.WriteLine("Sonuc: " + sonuc);
        }

    }
}
