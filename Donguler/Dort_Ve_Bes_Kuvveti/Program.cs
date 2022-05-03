using System;

namespace Dort_Ve_Bes_Kuvveti
{
    public class Program
    {
        //C# döngüler ile girilen sayıya kadar olan 4 ve 5'in kuvvetlerini ekrana yazdıran programı yazıyoruz.

        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());         

            int toplam = 1;

            while (toplam < sayi)
            {
                toplam *= 4;
                if (sayi >= toplam)
                {
                    Console.Write(toplam + ", ");
                }
            }

            Console.WriteLine();

            toplam = 1;
            while (toplam < sayi)
            {
                toplam *= 5;
                if(sayi >= toplam)
                {
                    Console.Write(toplam + ", ");
                }
               
            }




        }
    }
}
