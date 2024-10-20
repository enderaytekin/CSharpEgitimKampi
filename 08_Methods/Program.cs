using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ender Aytekin");
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ergin Diyar");
            //    Console.WriteLine("Lokman Hekim");
            //}

            //CustomerList();
            //Console.WriteLine("---------------");
            //CustomerList();

            //void Sum()
            //{
            //    int x = 4;
            //    int y = 5;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Ender");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müsteri: " + name + " " + surname);
            //}

            //CustomerCard("Selami", "Koç");
            //CustomerCard("Yasemin", "Kavak");

            #endregion

            #region Geriye değer döndüren metotlar

            //string StudentCard()
            //{
            //    string name = "Abdurrahman";
            //    string surname = "Çelik";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            //string CountryCard(string countryName, string countryCapital, string countryFlagColor)
            //{
            //    return "Ülke: " + countryName + "\nBaşkent: " + countryCapital + "\nBayrak: " + countryFlagColor;
            //}

            //string country, capital, flag;

            //Console.Write("Ülke Adı Giriniz: ");
            //country = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Bayrak Rengi Giriniz: ");
            //flag = Console.ReadLine();

            //Console.WriteLine(CountryCard(country, capital, flag));

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(12, 56));
            //Console.WriteLine(Sum(456, 156));
            //Console.WriteLine(Sum(634, 34));
            //Console.WriteLine(Sum(123, 89));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                int avarage = (exam1 + exam2 + exam3) / 3;
                if(avarage >= 70)
                {
                    return studentName + ": Dersi GEÇTİ. - " + "Ortalaması: " + avarage ;
                }
                else
                {
                    return studentName + ": Dersten KALDI. - " + "Ortalaması: " + avarage;
                }
            }

            Console.WriteLine(ExamResult("Ender Aytekin", 89, 98, 100));
            Console.WriteLine(ExamResult("Mehmet Erkenci", 19, 58, 80));
            Console.WriteLine(ExamResult("Ali Kardeş", 79, 68, 90));

            #endregion

            Console.Read();
        }
    }
}
