using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba9
{
    class Program
    {
        static int min(int a, int b)
        {
            return (a > b) ? b : a;
        }

        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static double fx(int x)
        {
            double f = Math.Pow(x,3) - Math.Sin(x);
            return f;
        }

        static double fy(int x)
        {
            double f = Math.Cos(2 * x) + Math.Sin(x-3);
            return f;
        }

        static double func(int a, int x)
        {
            
            if (a == x)
            {
                return  1;
            }
            else if (a > x)
            {
                return  0;
            }
            else 
            {
                double t = (double)(x - a) / (x + a);
                return t;
            }

        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 11:
                    {
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("c = ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("d = ");
                        int d = int.Parse(Console.ReadLine());
                        int minimum = min(min(a,b), min(c,d));
                        Console.WriteLine("min({0},{1},{2},{3}) = {4}",a,b,c,d,minimum);
                    }
                    break;
                case 12:
                    {
                        Console.Write("x = ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("y = ");
                        int y = int.Parse(Console.ReadLine());
                        int z = max(x,2*y-x) + max(5*x + 3*y,y);
                        Console.WriteLine("z = {0}",z);
                    }
                    break;
                case 13:
                    {
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("f({0}) = {1}", a, fx(a));
                        Console.WriteLine("f({0}) = {1}", b, fx(b));

                        if (fx(a) > fx(b))
                        {
                            Console.WriteLine("f({0}) > f({1})",a,b);
                        }
                        else
                        {
                            Console.WriteLine("f({0}) < f({1})",a,b);
                        }
                    }
                    break;
                case 14:
                    {
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("f({0}) = {1}", a, fy(a));
                        Console.WriteLine("f({0}) = {1}", b, fy(b));

                        if (fy(a) > fy(b))
                        {
                            Console.WriteLine("f({0}) > f({1})", a, b);
                        }
                        else
                        {
                            Console.WriteLine("f({0}) < f({1})", a, b);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("x = ");
                        int x = int.Parse(Console.ReadLine());
                        double z = func(a,x);
                        Console.WriteLine("f({0},{1}) = {2}", a,x,z);
                    }
                    break;
                    
            }
            Console.ReadLine();



        }
    }
}
