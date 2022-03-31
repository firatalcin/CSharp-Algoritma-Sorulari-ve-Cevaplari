using System;

namespace Yildiz_Sekilleri
{
    /*
     *
    ***
   *****
  *******
 *********
  *******
   *****
    ***
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int line = Convert.ToInt32(Console.ReadLine());
            int space = line, star = 1;


            for (int i = 1; i <= line; i++)
            {
                for (int j = space; j > 1; j--)
                {
                    Console.Write(" ");
                }
                space--;
                for (int k = 1; k <= star; k++)
                {
                    Console.Write("*");
                }
                star += 2;
                Console.WriteLine();
            }

            star -= 3; 
            space = 1;
            
            for (int i = 1; i < line; i++)
            {
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                space++;
                for (int k = star; k > 1; k--)
                {
                    Console.Write("*");
                }
                star -= 2;
                Console.WriteLine();
            }
        }
    }
}
