using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba10_3
{
    class Program
    {


        static void CreateMassive(int[,] mass)
        {
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

        static void PrintMassive(string a, int[,] mass)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void zad1(int[,] mass)
        {
            int summ = 0;
            int kol = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (i > j && mass[i,j] % 2 == 0)
                    {
                        summ += mass[i, j];
                        kol++;
                    }
                }
            }
            double sr_ar = (double)summ / kol;
            Console.WriteLine("srednee arifmeti4eskoe = " + sr_ar);

        }

        static void zad2(int[,] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                sum += mass[i,mass.GetLength(0)-i-1];
            }
            Console.Write("Symma elementov pobo4noi diogonali = {0}", sum);
        }

        static void zad3(int[,] mass)
        {
            int temp = mass.GetLength(0) - 2;
            int summ = 0;
            int kol = 0;
            for (int i = 0; i <= mass.GetLength(0); i++)
            {
                for (int j = 0; j <= temp; j++)
                {
                    if (mass[i, j] != 0)
                    {
                        summ += mass[i, j];
                        kol++;
                    }
                }
                temp--;
            }
            double sr_ar = (double)summ / kol;
            Console.WriteLine("Srednee arifmeti4eskoe: {0}", sr_ar);
        }

        static void zad4(int[,] mass)
        {
            int summ = 0;
            int kol = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((i + j) >= mass.GetLength(1))
                    {
                        summ += mass[i, j];
                        kol++;
                    }
                }
            }
            double sr_ar = (double)summ / kol;
            Console.WriteLine("Srednee arifmeti4eskoe: {0}", sr_ar);
        }

        static int[,] zad5(int[,] mass)
        {
            int[,] mass1 = new int[mass.GetLength(0), mass.GetLength(1)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = mass.GetLength(1)-1; j >= 0; j--)
                {
                    mass1[i, mass.GetLength(1) - j-1] = mass[i, j];
                }
            }

            return mass1;
        }

        static int[,] zad6(int[,] mass)
        {
            int[,] mass1 = new int[mass.GetLength(0), mass.GetLength(1)];
            double num = (double)mass.GetLength(0) / 2;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass.GetLength(0) % 2 == 0)
                    {
                        mass1[(int)num - 1, j] = mass[(int)num, j];
                        mass1[(int)num, j] = mass[(int)num - 1, j];
                        mass1[i, j] = mass[i, j];
                    }
                    else
                    {
                        mass1[0, j] = mass[(int)num, j];
                        mass1[(int)num, j] = mass[0, j];
                        mass1[i, j] = mass[i, j];
                    }
                }

            }
            return mass1;
        }

        static int[,] zad7(int[,] mass)
        {
            int[,] mass1 = new int[mass.GetLength(0), mass.GetLength(1)];
            double num = (double)mass.GetLength(0) / 2;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass.GetLength(1) % 2 == 0)
                    {
                        mass1[i, (int)num - 1] = mass[i, (int)num];
                        mass1[i, (int)num] = mass[j, (int)num - 1];
                        mass1[i, j] = mass[i, j];
                    }
                    else
                    {
                        mass1[i, 0] = mass[i, (int)num];
                        mass1[i, (int)num] = mass[i, 0];
                        mass1[i, j] = mass[i, j];
                    }
                }

            }
            return mass1;
        }

        static int[,] zad8(int[,] mass)
        {
            int[,] mass1 = new int[mass.GetLength(0), mass.GetLength(1)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass.GetLength(0) % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            mass1[i, j] = mass[i + 1, j];
                        }
                        else
                        {
                            mass1[i, j] = mass[i - 1, j];
                        }
                    }
                    else
                    {
                        mass1[i, j] = mass[i, j];
                    }
                }
            }
                return mass1;
        }

        static int[,] zad9(int[,] mass)
        {
            int[,] mass1 = new int[mass.GetLength(0), mass.GetLength(1)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass.GetLength(1) % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            mass1[i, j] = mass[i, j + 1];
                        }
                        else
                        {
                            mass1[i, j] = mass[i, j - 1];
                        }
                    }
                    else
                    {
                        mass1[i, j] = mass[i, j];
                    }
                }
            }
            return mass1;
        }

        static int[,] zad10(int[,] mass)
        {
            int max;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                max = mass[i, 0];
                int ix = 0;
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                        ix = j;
                    }
                }
                mass[i, ix] = -max;
            }

           
            return mass;
        }

        static void Main(string[] args)
        {
            Console.Write("Viberete razmernost massiva: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mass = new int[n,n];
            CreateMassive(mass);
            PrintMassive("Ishodnii massiv: ", mass);
            Console.WriteLine();
            Console.Write("\nViberete zadanie(1-10): ");
            int r = int.Parse(Console.ReadLine());
            switch (r)
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
                case 3:
                    {
                        zad3(mass);
                    }
                    break;
                case 4:
                    {
                        zad4(mass);
                    }
                    break;
                case 5:
                    {
                        PrintMassive("Izmenennii massiv: ", zad5(mass));
                    }
                    break;
                case 6:
                    {
                        PrintMassive("Izmenennii massiv: ", zad6(mass));
                    }
                    break;
                case 7:
                    {
                        PrintMassive("Izmenennii massiv: ", zad7(mass));
                    }
                    break;
                case 8:
                    {
                        PrintMassive("Izmenennii massiv: ", zad8(mass));
                    }
                    break;
                case 9:
                    {
                        PrintMassive("Izmenennii massiv: ", zad9(mass));
                    }
                    break;
                case 10:
                    {
                        PrintMassive("Izmenennii massiv: ", zad10(mass));
                    }
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
