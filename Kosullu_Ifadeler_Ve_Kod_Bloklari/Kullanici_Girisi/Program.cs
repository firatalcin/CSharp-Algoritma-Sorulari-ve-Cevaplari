using System;

namespace Kullanici_Girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              C# ile Eğer şifre yanlış ise kullanıcıya Şifreniz hatalı, değiştirmek ister misiniz,
              eğer kullanıcı değiştirmek isterse yeni girdiği şifrenin hatalı girdiği ve unuttuğu
              şifre ile aynı olmaması gerektiğini kontrol edip , şifreler aynı ise ekrana "Şifre oluşturulamadı,
              lütfen başka şifre giriniz." sorun yoksa "Şifre oluşturuldu" yazan programı yazınız.
            */

            string user = "Fırat";
            string password = "1234";

            Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            string userLogin = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz: ");
            string passwordLogin = Console.ReadLine();

            if (password != passwordLogin)
            {
                Console.WriteLine("Şifreniz hatalı, değiştirmek ister misiniz ? (y/n)");
                char secim = Convert.ToChar(Console.ReadLine());
                if (secim == 'y')
                {
                    Console.WriteLine("Yeni Şifrenizi giriniz: ");
                    string newPassword = Console.ReadLine();
                    if(newPassword == password)
                    {
                        Console.WriteLine("Girdiğiniz şifre önceki şifrenizle aynı.");
                    }
                    else
                    {
                        Console.WriteLine("Yeni şifreniz oluşturuldu.");
                    }
                }
                else if (secim == 'n')
                {
                    Console.WriteLine("Şifreniz oluşturulmadı.");
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                }
            }
            else
            {
                Console.WriteLine("Giriş başarılı");
            }

            //döngü ve methodlar öğrenildiğinde tekrar girişler sağlanabilir.
        }
    }
}
