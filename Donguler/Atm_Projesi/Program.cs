using System;

namespace Atm_Projesi
{
    //C# ile ATM Projesi yapalım. 
    /*
    Kullanıcıdan username ve password alalım. Kullanıcının doğru verileri girmesi için 3 hak verilecektir.
    1-Para yatırma
    2-Para Çekme
    3-Bakiye Sorgula
    4-Çıkış Yap

    işlemleri içereçektir.

    Projeyi Switch-Case ile yapalım.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int passwordCheck = 1234;
            string userNameCheck = "firatalcin";
            int right = 3;
            while (right > 0)
            {
                Console.Write("Kullanıcı adınızı giriniz: ");
                string userName = Console.ReadLine();
                Console.Write("Şifrenizi giriniz: ");
                int password = Convert.ToInt32(Console.ReadLine());
                int select = 0, balance = 0, price = 0;


                if (userName == userNameCheck & password == passwordCheck)
                {
                    Console.WriteLine("Bankamıza Hoşgeldiniz.");
                    while (select != 4)
                    {
                        Console.WriteLine("1-Para Yatırma\n2-Para Çekme\n3-Bakiye Sorgula\n4-Çıkış yap");
                        System.Console.WriteLine("");
                        Console.Write("Bir seçim yapınız: ");
                        select = Convert.ToInt32(Console.ReadLine());

                        switch (select)
                        {
                            case 1:
                                Console.Write("Yatırılacak miktarı giriniz: ");
                                price = Convert.ToInt32(Console.ReadLine());
                                balance += price;
                                break;
                            case 2:
                                Console.Write("Çekilecek miktar: ");
                                price = Convert.ToInt32(Console.ReadLine());
                                if (price > balance)
                                {
                                    Console.WriteLine("Bakiyeniz yetersizdir.");
                                }
                                else
                                {
                                    balance -= price;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Bakiyeniz: " + balance);
                                break;
                            case 4:
                                Console.WriteLine("Çıkış yapılıyor...");
                                break;
                            default:
                                Console.WriteLine("Geçersiz giriş");
                                break;
                        }
                    }
                }
                else
                {
                    right--;
                    if (right > 0)
                    {
                        Console.WriteLine("Girdiğiniz bilgiler yanlış, tekrar deneyiniz. Kalan giriş hakkınız: " + right);
                    }
                    else
                    {
                        Console.WriteLine("Giriş hakkınız kalmamıştır\nSistemden çıkarılıyorsunuz.");
                    }
                }
            }

        }
    }
}
