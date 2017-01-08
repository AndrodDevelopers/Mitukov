using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba10_1
{
    class Program
    {
        static void CreateMassive(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("mass[{0}] = ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintMassive(string a, int[] mass)
        {
            Console.Write(a);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }

        static void zad1(int[] mass)
        {
            Console.Write("Vvedite a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vvedite b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= a && mass[i] <= b)
                {
                    mass[i] = 0;
                }
            }
        }

        static void zad2(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0 && mass[i] % 3 != 0)
                {
                    mass[i] = mass[i] * (-1);
                }
            }
        }

        static void zad3(int[] mass)
        {
            Console.Write("Vvedite 4islo: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < a)
                {
                    mass[i] = mass[i] * 2;
                }
            }
        }

        static void zad4(int[] mass)
        {
            int kol = 0;
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
                kol++;
            }
            double sr_ar = (double)summ / kol;
            Console.Write("Srednee arifmeti4eskoe = {0}", sr_ar);
        }

        static void zad5(int[] mass)
        {
            int kol = 0;
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    summ += mass[i];
                    kol++;
                }
            }
            double sr_ar = (double)summ / kol;
            Console.Write("Srednee arifmeti4eskoe otricatelnih elementov = {0}", sr_ar);
        }

        static void zad6(int[] mass)
        {
            int kol = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 != 0)
                {
                    kol++;
                }
            }
            Console.Write("Koli4estvo ne4etnih elementov = {0}", kol);
        }

        static void zad7(int[] mass)
        {
            int summ = 0;
            Console.Write("Vvedite a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vvedite b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= a && mass[i] <= b)
                {
                    summ += mass[i];
                }
            }
            Console.Write("Summa elementov iz intervala [{0},{1}] = {2}", a, b, summ);
        }

        static void zad8(int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 9 == 0)
                {
                    summ += mass[i];
                }
            }
            Console.Write("Summa 4isel, kratnih 9 = {0}", summ);
        }

        static void zad9(int[] mass)
        {
            int summ = 0;
            Console.Write("Vvedite a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vvedite b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= a || mass[i] >= b)
                {
                    summ += mass[i];
                }
            }
            Console.Write("Summa elementov ne iz intervala [{0},{1}] = {2}", a, b, summ);
        }

        static void zad10(int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    summ += mass[i] * mass[i];
                }
            }
            Console.Write("Summa kvadratov 4etnih 4isel = {0}", summ);
        }


        static void Main(string[] args)
        {
            Console.Write("Viberete razmernost massiva: ");
            int r = int.Parse(Console.ReadLine());
            int[] mass = new int [r];
            CreateMassive(mass);
            PrintMassive("Ishodnii massiv: ", mass);
            Console.WriteLine();
            Console.Write("\nViberete zadanie(1-10): ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        zad1(mass);
                        PrintMassive("Izmenennii massiv: ", mass); 
                    }
                    break;
                case 2:
                    {
                        zad2(mass);
                        PrintMassive("Izmenennii massiv: ", mass);
                    } 
                    break;
                case 3:
                    {
                        zad3(mass);
                        PrintMassive("Izmenennii massiv: ", mass);
                    }
                    break;
                case 4:
                    {
                        zad4(mass);
                    }
                    break;
                case 5:
                    {
                        zad5(mass);
                    }
                    break;
                case 6:
                    {
                        zad6(mass);
                    }
                    break;
                case 7:
                    {
                        zad7(mass);
                    } 
                    break;
                case 8:
                    {
                        zad8(mass);
                    }
                    break;
                case 9:
                    {
                        zad9(mass);
                    }
                    break;
                case 10:
                    {
                        zad10(mass);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
