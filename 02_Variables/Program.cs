using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı    : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı   : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates  Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 2.456;
            //orangeGram = 3.231;
            //strawberryGram = 0.876;
            //potatoGram = 5.432;
            //tomatoGram = 3.456;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Elma Toplam Fiyatı    : " + appleTotalPrice.ToString("0.00") + " TL");
            //Console.WriteLine("Portakal Toplam Fiyatı: " + orangeTotalPrice.ToString("0.00") + " TL");
            //Console.WriteLine("Çilek Toplam Fiyatı   : " + strawberryTotalPrice.ToString("0.00") + " TL");
            //Console.WriteLine("Patates Toplam Fiyatı : " + potatoTotalPrice.ToString("0.00") + " TL");
            //Console.WriteLine("Domates Toplam Fiyatı : " + tomatoTotalPrice.ToString("0.00") + " TL");

            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice.ToString("0.00"));

            #endregion

            #region Char Değişkenler

            //char symbol = 'E';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("CSharp Havayolları Yolcu Bilgileri");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı   : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İl Bilgisi  : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yaşı  : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //Console.WriteLine("Yolcu Ad Soyad: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu TC No   : " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu Adres   : " + passengerDistrict + " / " + passengerCity);
            //Console.WriteLine("Yolcu Yaşı    : " + passengerAge);

            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Ayakkabı Adedini Giriniz  : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Bilgisayar Adedini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Sandalye Adedini Giriniz  : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Televizyon Adedini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount
            //                + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek TUTAR: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişi İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+ exam2+ exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result.ToString("0.00"));

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyetinizi Giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçilen Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
