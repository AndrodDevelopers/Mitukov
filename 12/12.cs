using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba12
{
    class Program
    {

        static void Create (int[,] mass)
        {
            Console.WriteLine();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write("mass[{0},{1}] = ", i, j);
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        static void Print(int[,] mass)
        {
            Console.WriteLine("Ishodna9 matrica: ");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void zad1(int[,] mass)
        {
            int summ = 0;
            int kol = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((i <= j && i + j <= mass.GetLength(0) - 1) || (i >= j && i + j >= mass.GetLength(0) - 1))
                    {
                        summ += mass[i, j];
                    }
                }
            }
            Console.WriteLine("Summa = {0}", summ);
        }

        static void zad2(int[,] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((j <= i && i + j <= mass.GetLength(0) - 1) || (j >= i && i + j >= mass.GetLength(0) - 1))
                    {
                        summ += mass[i, j];
                    }
                }
            }
            Console.WriteLine("Summa = {0}", summ);
        }

        static void Main(string[] args)
        {
            Console.Write("Razmernost matrici: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mass = new int[n, n];
            Create(mass);
            Print(mass);
            Console.Write("Viberete zadanie (1 ili 2): ");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    {
                        zad1(mass);
                    }
                    break;
                case 2:
                    {
                        zad2(mass);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
