using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd") {
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz  : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Veri");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav-1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav-2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav-3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ders Ortalaması: " + average);

            //if (average >= 0 && average <=50)
            //{
            //    result = "Vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Orta";
            //}
            //if(average > 70 && average <= 84)
            //{
            //    result = "İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" || city == "istanbul" || city == "ardahan" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Bilgisi MEVCUT");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Bilgisi MEVCUT DEĞİL");
            //}

            //Console.Write("Kullanıcı Adı Giriniz: ");
            //string userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı HATALI!!!");
            //}
            //else
            //{
            //    Console.WriteLine("HOŞ GELDİNİZ");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2. Sayıya bölümünden kalan: " + result);

            //Console.Write("Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("ÇİFT SAYI");
            //}
            //else
            //{
            //    Console.WriteLine("TEK SAYI");
            //}

            #endregion

            #region char değişkenler ile Karar Yapıları

            //Console.Write("Takım Sembolünü Giriniz: ");
            //char team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Lütfen Menü Seçimi Yapınız: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Kuru Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------- Ana Yemekler ----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezo Gelin Çorbası");
            //    Console.WriteLine("---------- Çorbalar ----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("---------- Pizzalar ----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("---------- İçecekler ----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("---------- Tatlılar ----------");

            //    Console.WriteLine();
            //}


            #endregion

            #region switch case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("OCAK"); break;
            //    case 2: Console.WriteLine("ŞUBAT"); break;
            //    case 3: Console.WriteLine("MART"); break;
            //    case 4: Console.WriteLine("NİSAN"); break;
            //    case 5: Console.WriteLine("MAYIS"); break;
            //    case 6: Console.WriteLine("HAZİRAN"); break;
            //    case 7: Console.WriteLine("TEMMUZ"); break;
            //    case 8: Console.WriteLine("AĞUSTOS"); break;
            //    case 9: Console.WriteLine("EYLÜL"); break;
            //    case 10: Console.WriteLine("EKİM"); break;
            //    case 11: Console.WriteLine("KASIM"); break;
            //    case 12: Console.WriteLine("ARALIK"); break;
            //    default: Console.WriteLine("HATALI GİRİŞ"); break;
            //}

            #endregion

            #region switch case ile Hesap Makinesi

            //char symbol;
            //int numer1, numer2, result;

            //Console.Write("1.Sayıyı Giriniz: ");
            //numer1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz: ");
            //numer2 = int.Parse(Console.ReadLine());

            //Console.Write("İşleminizi Seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = numer1 + numer2;
            //        Console.WriteLine("İşlem Sonucu: " + result);
            //        break;
            //    case '-':
            //        result = numer1 - numer2;
            //        Console.WriteLine("İşlem Sonucu: " + result);
            //        break;
            //    case '*':
            //        result = numer1 * numer2;
            //        Console.WriteLine("İşlem Sonucu: " + result);
            //        break;
            //    case '/':
            //        result = numer1 / numer2;
            //        Console.WriteLine("İşlem Sonucu: " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
