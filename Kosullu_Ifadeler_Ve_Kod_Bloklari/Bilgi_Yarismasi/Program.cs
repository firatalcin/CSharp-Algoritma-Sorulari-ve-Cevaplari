using System;

namespace Bilgi_Yarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             C# ile soruları ve cevapları kendinizin belirleyeceği 3 soruluk bir bilgi yarışması hazırlayın. 
             Yarışmacı yarışmayı kazanabilmesi için en az iki soruyu doğru cevaplaması gerekiyor.
             */


            Console.WriteLine("Soru 1) Kızınca tüküren hayvan hangisidir ? ");
            Console.WriteLine("a) lama");
            Console.WriteLine("b) deve");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Soru 2) Dünyaya en yakın olan gezegen hangisidir ? ");
            Console.WriteLine("a) venüs");
            Console.WriteLine("b) mars");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Soru 3) 5 * 2 + 8 / 2 - 2 ? ");
            Console.WriteLine("a) 7");
            Console.WriteLine("b) 12");
            char c3 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'a' && c2 == 'b' || c1 == 'a' && c3 == 'b' || c2 == 'b' && c3 == 'b')
            {
                Console.WriteLine("Tebrikler Yarışmayı kazandınız");
            }
            else
            {
                Console.WriteLine("Maalesef Yarışmayı kazanamadınız");
            }
        }
    }
}
