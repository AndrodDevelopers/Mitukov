using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                        {
                            Console.WriteLine("while");
                            int i = 60;
                            while (i >= 10)
                            {
                                Console.WriteLine(i);
                                i -= 2;
                            }

                            Console.WriteLine();

                            Console.WriteLine("do while");
                            int k = 60; 
                            do
                            {
                                Console.WriteLine(k);
                                k -= 2;
                            }
                            while (k >= 10);

                            Console.WriteLine();

                            Console.WriteLine("for");
                            for (int j = 60; j >= 10;)
                            {
                                Console.WriteLine(j);
                                j -= 2;
                            }
                        } 
                        break;
                case 2:
                        {
                            Console.WriteLine("while");
                            double i = 25;
                            while (i <= 35)
                            {
                                Console.WriteLine("{0}   {1}    {2}", i, i+0.5, i-0.2);
                                i++;
                            }

                            Console.WriteLine();

                            Console.WriteLine("do while");
                            double k = 25;
                            do
                            {
                                Console.WriteLine("{0}   {1}   {2}", k, k+0.5, k-0.2);
                                k++;
                            }
                            while (k <= 35);

                            Console.WriteLine();

                            Console.WriteLine("for");
                            for (int j = 25; j <= 35;)
                            {
                                Console.WriteLine("{0}   {1}    {2}", j, j+0.5, j-0.2);
                                j++;
                            }
                        }
                        break;
                case 3:
                        {
                            Console.Write("A = ");
                            int A = int.Parse(Console.ReadLine());
                            Console.Write("B = ");
                            int B = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("while");
                            int i = B;
                            while(i >= A)
                            {
                                Console.Write(i + "^3 = " + Math.Pow(i,3) + " ");
                                Console.WriteLine();
                                i--;
                            }

                            Console.WriteLine();

                            Console.WriteLine("do while");
                            int k = B;
                            do
                            {
                                Console.Write(k + "^3 = " + Math.Pow(k,3) + " ");
                                Console.WriteLine();
                                k--;
                            }
                            while(k >= A);

                            Console.WriteLine();

                            Console.WriteLine("for");
                            for (int j = B; j >= A; )
                            {
                                Console.Write(j + "^3 = " + Math.Pow(j, 3) + " ");
                                Console.WriteLine();
                                j--;
                            }
                        }
                        break;
                case 4:
                        {
                            Console.Write("A = ");
                            int A = int.Parse(Console.ReadLine());
                            Console.Write("B = ");
                            int B = int.Parse(Console.ReadLine());
                            Console.Write("X = ");
                            int X = int.Parse(Console.ReadLine());
                            Console.Write("Y = ");
                            int Y = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("while");
                            int i = A;
                            while (i <= B)
                            {
                                if (i % 10 == X || i % 10 == Y)
                                {
                                    Console.Write(i + " ");
                                }
                                i++;
                            }

                            Console.WriteLine();

                            Console.WriteLine("\ndo while");
                            int k = A;
                            do
                            {
                                if (k % 10 == X || k % 10 == Y)
                                {
                                    Console.Write(k + " ");
                                }
                                k++;
                            }
                            while (k <= B);

                            Console.WriteLine();
                            
                            Console.WriteLine("\nfor");
                            for (int j = A; j <= B; )
                            {
                                if (j % 10 == X || j % 10 == Y)
                                {
                                    Console.Write(j + " ");
                                }
                                j++;
                            }

                        }
                        break;
                case 5:
                        {
                            Console.WriteLine("while");
                            int i = 100;
                            while (i <= 999)
                            {
                                if (i / 100 == i % 10)
                                {
                                    Console.WriteLine(i + " ");
                                }
                                i++;
                            }

                            Console.WriteLine();

                            Console.WriteLine("\ndo while");
                            int k = 100;
                            do
                            {
                                if (k / 100 == k % 10)
                                {
                                    Console.WriteLine(k + " ");
                                }
                                k++;
                            }
                            while (k <= 999);

                            Console.WriteLine();

                            Console.WriteLine("\nfor");
                            for (int j = 100; j <= 999;)
                            {
                                if (j / 100 == j % 10)
                                {
                                    Console.WriteLine(j + " ");
                                }
                                j++;
                            }
                        }
                        break;
            }
            Console.ReadLine();
            Console.ReadKey(true);
        }
    }
}
