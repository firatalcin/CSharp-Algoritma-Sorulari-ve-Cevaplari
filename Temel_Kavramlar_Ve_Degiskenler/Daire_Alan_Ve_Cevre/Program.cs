using System;

namespace Daire_Alan_Ve_Cevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Dairenin Alanını ve Çevresini Hesaplayan Program
            C# ile yarı çapını kullanıcıdan aldığınız dairenin alanını ve çevresini hesaplayan programı yazın.

            Alan Formülü : π* r *r;

            Çevre Formülü : 2 * π * r;

            Ödev
            Yarıçapı r, merkez açısının ölçüsü 𝛼 olan daire diliminin alanı bulan programı yazınız.

            𝜋 sayısını = 3.14 alınız.

            Formül : (𝜋 *(r * r) * 𝛼) / 360

            */

            double pi = 3.14;

            Console.WriteLine("Yarıçap giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alfa açısı giriniz: ");
            double alfa = Convert.ToDouble(Console.ReadLine());

            double alan = pi * r * r;

            double cevre = 2 * pi * r;

            double dilimAlan = (pi * (r * r) * alfa) / 360;




            Console.WriteLine("Dairenin Alanı: " + alan);
            Console.WriteLine("Dairenin Çevresi: " + cevre);
            Console.WriteLine("Dairenin Dilim Alanı: " + dilimAlan);
        }
    }
}
