using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("SELAM");

            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");

            #endregion

            #region string Değişkenler

            //string name;
            //name = "ENDER";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, customerDistrict, customerCity;

            //customerName = "Ender";
            //customerSurname = "Aytekin";
            //customerEmail = "enderaytekin@gmail.com";
            //customerPhone = "+90 531 623 33 88";
            //customerDistrict = "Kartal";
            //customerCity = "İstanbul";

            //Console.WriteLine("**** REZERVASYON KARTI ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Email  : " + customerEmail);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Adres  : " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine();

            //customerName = "Berat";
            //customerSurname = "Tanrıöver";
            //customerEmail = "berattariover@gmail.com";
            //customerPhone = "+90 500 400 00 00";
            //customerDistrict = "Bağcılar";
            //customerCity = "İstanbul";

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Email  : " + customerEmail);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Adres  : " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("---------------------------------");

            #endregion

            #region int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cookPrice = 35;
            int waterPrice = 15;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger : " + hamburgerPrice + "TL");
            Console.WriteLine("---Kola      : " + cookPrice + "TL");
            Console.WriteLine("---Su        : " + waterPrice + "TL");
            Console.WriteLine("---Kızartma  : " + friesPrice + "TL");
            Console.WriteLine("---Pizza     : " + pizzaPrice + "TL");
            Console.WriteLine("---Limonata  : " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");

            int hamburgerCount;
            int cookCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCookPrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 4;
            cookCount = 4;
            waterCount = 2;
            friesCount = 2;
            pizzaCount = 1;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCookPrice = cookPrice * cookCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola      Tutarı: " + totalCookPrice + " TL");
            Console.WriteLine("Su        Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma  Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza     Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata  Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCookPrice + totalWaterPrice + totalFriesPrice
                            + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            Console.WriteLine("---------------------------");

            #endregion

            Console.Read();
        }
    }
}
