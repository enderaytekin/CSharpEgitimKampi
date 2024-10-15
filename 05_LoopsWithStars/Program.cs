using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Dik üçgen oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik üçgen oluşturma

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik üçgen ve Ters dik üçgen oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region baklava dilimi oluşturma

            int satir = 5;

            for (int j = 1; j <= 5; j++)
            {
                for (int i = satir; i <= 5; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                satir--; 
            }

            satir = 4;

            for (int j = 0; j <= 4; j++)
            {
                for (int i = 1; i <= satir; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                satir--; 
            }
            
            #endregion

            #region piramit oluşturma

            //int satir = 7;  //baklava dilimi için en az 3 satır olmalı ve tek sayılardan olmalı
            //int ustTaraf = satir;
            //int altTaraf = satir - 1;
            //int yildiz = 1;
            //int altYildiz = (satir * 2) - 3;

            //for (int j = 1; j <= ustTaraf; j++)
            //{
            //    for (int k = 1; k <= (satir - 1); k++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int i = 1; i <= yildiz; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    yildiz += 2;
            //    satir--;
            //}

            //satir = 1;

            //for (int i = 1; i <= altTaraf; i++)
            //{
            //    for (int j = 1; j <= satir; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= altYildiz; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    altYildiz -= 2;
            //    satir++;
            //}

            #endregion

            Console.Read();
        }
    }
}
