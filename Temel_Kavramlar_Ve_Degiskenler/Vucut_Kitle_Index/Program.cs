using System;

namespace Vucut_Kitle_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Vücut Kitle İndeksi Hesaplama
             C# ile kullanıcıdan boy ve kilo değerlerini alıp bir değişkene atayın. Aşağıdaki formüle göre kullanıcının "Vücut Kitle İndeks" değerini hesaplayıp ekrana yazdırın.

             Formül
             Kilo (kg) / Boy(m) * Boy(m)
            */

            Console.Write("Kilonuzu giriniz(kg): ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boyunuzu giriniz(m): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double indeks = kilo / (boy * boy);

            Console.WriteLine("Vücut kitle indeksiniz: " + indeks);

        }
    }
}
