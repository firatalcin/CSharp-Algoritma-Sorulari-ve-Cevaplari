using System;

namespace KDV_Tutari_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             KDV Tutarı Hesaplayan Program
             C# ile kullanıcıdan alınan para değerinin KDV'li fiyatını ve 
             KDV tutarını hesaplayıp ekrana bastıran programı yazın.

             (Not : KDV tutarını 18% olarak alın)

             KDV'siz Fiyat = 10;

             KDV'li Fiyat = 11.8;

             KDV tutarı = 1.8;

             Ödev
             Eğer girilen tutar 0 ve 1000 TL arasında ise KDV oranı %18 , 
             tutar 1000 TL'den büyük ise KDV oranını %8 olarak KDV tutarı hesaplayan programı yazınız.
            */

            Console.WriteLine("Tutar giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());

            double KDV_Tutari = (tutar >= 0 && tutar <= 1000) ? 0.18 : 0.08;


            Console.WriteLine("KDV'siz Fiyat: " + tutar);
            Console.WriteLine("KDV'li Fiyat: " + (tutar + (tutar * KDV_Tutari)));
            Console.WriteLine("KDV Tutarı: " + (tutar * KDV_Tutari));


        }
    }
}
