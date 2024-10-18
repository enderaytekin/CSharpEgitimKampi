using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach dögüsü

            //string[] cities = { "istanbul", "viyana", "mekke", "trabzon", "venedik" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 12, 45, 87, 908, 54, 2341, 56, 33, 10564, 78, 173, 9012 };

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 12, 45, 87, 908, 54, 2341, 56, 33, 10564, 78, 173, 9012 };

            //Console.WriteLine("Çift Sayılar");
            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 12, 45, 87, 908, 54, 2341, 56, 33, 10564, 78, 173, 9012 };

            //int toplam = 0;

            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        toplam += x;    
            //    }
            //}

            //Console.WriteLine("Dizideki Çift Sayıların Toplamı: " + toplam);

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi

            Console.Write("***** C# Eğitim Kampı Sınav Uygulamsı *****");
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 not girişi olacak
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;  //notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamalarını yazdırma
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması " + studentExamAvg[i].ToString("0.00"));

                //Öğrencilerin geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
