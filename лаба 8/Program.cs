using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 2:
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = -10; j <= 12; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 4:
                    {
                        int k = 41;
                        for (int i = 0; i <= 3; i++)
                        {
                            for (int j = k; j <= k + 9; j++)
                            {
                                Console.Write(j + " ");
                            }
                            k += 10;
                            Console.WriteLine();
                        }
                    }
                    break;
                case 5:
                    {
                        for (int i = 0; i <= 4; i++)
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (i >= j)
                                {
                                    Console.Write(5 + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 6:
                    {
                        int nn = 5;
                        int temp = nn-1;
                        for (int i = 0; i <= nn; i++)
                        {
                            for (int j = 0; j <=temp; j++)
                            {
                                    Console.Write(1 + " ");
                            }
                            temp--;
                            Console.WriteLine();
                        }
                    }
                    break;
                case 7:
                    {
                        for (int i = 0; i <= 4;i++ )
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (i >= j)
                                {
                                    Console.Write(i + 1 + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 11:
                    {
                        for (int i = 0; i <= 4; i++)
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (i >= j)
                                {
                                    Console.Write(j + 1 + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("razmernost = ");
                        int raz = int.Parse(Console.ReadLine());
                        int kol = 0;
                        for (int i = 1; i <= raz; i++)
                        {
                            for (int j = 1; j <= raz; j++)
                            {
                                if ((i + j) % 2 == 0)
                                {
                                    kol++;
                                }
                            }
                        }
                            Console.WriteLine("koli4estvo 4ernih 94eek: " + kol);
                    }
                    break;
                case 22:
                    {
                        Console.Write("k = ");
                        int k = int.Parse(Console.ReadLine());
                        Console.Write("m = ");
                        int m = int.Parse(Console.ReadLine());
                        if ((k + m) % 2 == 0)
                        {
                           Console.WriteLine("black");
                        }
                           else
                        {
                           Console.WriteLine("white");
                        }
                    }
                    break;
                case 23:
                    {
                        Console.Write("k1 = ");
                        int k1 = int.Parse(Console.ReadLine());
                        Console.Write("m1 = ");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.Write("k2 = ");
                        int k2 = int.Parse(Console.ReadLine());
                        Console.Write("m2 = ");
                        int m2 = int.Parse(Console.ReadLine());
                        if ((((k1 + m1) % 2 == 0) && ((k2 + m2) % 2 == 0)) || (((k1 + m1) % 2 != 0) && ((k1 + m2) % 2 != 0)))
                        {
                            Console.WriteLine("odnogo cveta");
                        }
                        else
                        {
                            Console.WriteLine("raznie cveta");
                        }
                    }
                    break;    
            }
            Console.ReadLine();
        }
    }
}
