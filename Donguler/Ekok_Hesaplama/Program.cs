using System;

namespace Ekok_Hesaplama
{
    internal class Program
    {
        // C# ile EKOK Hesaplama
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());          
            int i = 2, ekok = 1;
            while (i>1)
            {                              
                if (number1 % i == 0 && number2 % i == 0)
                {
                    number1 /= i;
                    number2 /= i;
                    ekok *= i;
                    i--;
                }else if(number1 % i == 0)
                {
                    number1 /= i;
                    ekok *= i;
                    if (number1 % i == 0)
                    {                        
                        i--;
                    }
                }
                else if(number2 % i == 0)
                {
                    number2 /= i;
                    ekok *= i;
                    if (number2 % i == 0)
                    {
                        i--;
                    }
                }                
                i++;

                if(number1 == 1 && number2 == 1)
                {
                    break;
                }
            }
            Console.WriteLine("----------------");
            Console.WriteLine("EKOK sonucu: " + ekok);
        }
    }
}
