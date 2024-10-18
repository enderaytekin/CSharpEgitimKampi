using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "siyah";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "istanbul";
            //cities[1] = "milano";
            //cities[2] = "kahire";
            //cities[3] = "üsküp";
            //cities[4] = "lyon";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 56;
            //numbers[2] = 546;
            //numbers[7] = 32;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "istanbul", "ankara", "ardahan" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 54, 78, 654, 2348, 987, 658, 432, 56, 22349, 2347 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '%', '!' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 12, 543, 65, 897, 3456, 22, 34, 70, 241, 2223, 52245, 763 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "veli", "ayşe", "hakkı", "ender", "mehmet", "ahmet" };
            //Console.WriteLine(persons.Length);

            #endregion

            #region Dizi Metotlar

            //Array.Sort(persons);
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i]);
            //}

            //string[] persons = { "ali", "veli", "ayşe", "hakkı", "ender", "mehmet", "ahmet" };

            //Array.Reverse(persons);
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i]);
            //}

            //string[] persons = { "ali", "veli", "ayşe", "hakkı", "ender", "mehmet", "ahmet" };
            //int indeks = Array.IndexOf(persons, "ayşe");
            //Console.WriteLine(indeks);

            //int[] numbers = { 12, 543, 65, 897, 3456, 22, 34, 70, 241, 2223, 52245, 763 };
            //Console.WriteLine("Dizi en büyük eleman: " + numbers.Max());
            //Console.WriteLine("Dizi en küçük eleman: " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numbers = { 12, 387, 64, 97, 56, 3, 2, 346, 702, 857, 93, 62, 11, 394, 9604 };

            Console.WriteLine("Dizideki Tek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Dizideki Çift Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
