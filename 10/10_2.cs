using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba10_2
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
            int min = mass[0];
            List<int> list = new List<int>();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];  
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (min == mass[j])
                {
                    list.Add(j);
                }
            }
            Console.WriteLine("\nindexi min elementov: ");
            for (int k = 0; k < list.Count; k++)
            {
                Console.Write(list[k] + " ");
            }
        }

        static void zad2(int[] mass)
        {
            int max = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (max == mass[j])
                {
                    mass[j] = 0;
                }
            }
        }

        static void zad3(int[] mass)
        {
            int min = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                }
            }
            Console.WriteLine("min = {0}", min);
            for (int j = 0; j < mass.Length; j++)
            {
                if (min == mass[j])
                {
                    mass[j] = - mass[j];
                }
            }
        }

        static void zad4(int[] mass)
        {
            int max = mass[0];
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                    index = i;
                }
            }
            int zam = mass[0];
            mass[0] = max;
            mass[index] = zam;
        }

        static void zad5(int[] mass)
        {
            int max = mass[0];
            List<int> list = new List<int>();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (max != mass[j])
                {
                    list.Add(j);
                }
            }
            Console.WriteLine("\nindexi elementov, ne sovpadauwih s max: ");
            for (int k = 0; k < list.Count; k++)
            {
                Console.Write(list[k] + " ");
            }
        }

        static void zad6(int[] mass)
        {
            int min = mass[0];
            List<int> list = new List<int>();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] == min)
                {
                    list.Add(j);
                }
            }
            Console.Write("nomer pervogo min elementa: {0}", list[0]);
        }

        static void zad7(int[] mass)
        {
            int max = mass[0];
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                    index = i;
                }
            }
            Console.Write("nomer poslednego max elementa: {0}", index);
        }

        static void zad8(int[] mass)
        {
            int max = mass[0];
            int index1 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                    index1 = i;
                }
            }

            int min = mass[0];
            int index2 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                    index2 = i;
                }
            }

            Console.WriteLine("index_min = " + index2);
            Console.WriteLine("index_max - " + index1);

            int summ = 0;
            for (int k = 0; k < mass.Length; k++)
            {
                if (k > index2 && k < index1)
                {
                    summ += mass[k];
                    Console.WriteLine(mass[k]);
                }
            }
            if (index2 > index1)
            {
                Console.WriteLine("Index min elementa < indexa max elementa");
            }
            else if (index1 - index2 == 1)
            {
                Console.WriteLine("Net 4isel megdy max i min elementami");
            }
            else
            {
                Console.Write("summ = {0}", summ);
            }
        }

        static void zad9(int[] mass)
        {
            int max = mass[0];
            List<int> list = new List<int>();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] == max)
                {
                    list.Add(j);
                }
            }
            Console.Write("nomer pervogo max elementa: {0}", list[0]);
        }

        static void zad10(int[] mass)
        {
            int min = mass[0];
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                    index = i;
                }
            }
            Console.Write("nomer poslednego min elementa: {0}", index);
        }


        static void Main(string[] args)
        {
            Console.Write("Viberete razmernost massiva: ");
            int r = int.Parse(Console.ReadLine());
            int[] mass = new int[r];
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
                        PrintMassive("Izmenennii massiv: ", mass);
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
