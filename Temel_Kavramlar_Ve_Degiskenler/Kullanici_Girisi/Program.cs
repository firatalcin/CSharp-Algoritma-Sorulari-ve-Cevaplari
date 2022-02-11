using System;

namespace Kullanici_Girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             C# ile basit kullanıcı girişi
             */


            string userName = "qwerty";
            string UserPassword = "1234";

            Console.WriteLine("Kullanıcı Adı Giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Kullanıcı Şifresini Giriniz: ");
            string password = Console.ReadLine();

            string sonuc = (name == userName && password == UserPassword) ? "Giriş Başarılı" : "Yanlış Giriş Yaptınız";

            Console.WriteLine(sonuc);
        }
    }
}
