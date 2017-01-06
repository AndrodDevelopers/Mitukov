using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba6
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
                        Console.Write("b = ");
                        int b = int.Parse(Console.ReadLine());
                        double z1 = Math.Sqrt(2*b + 2*Math.Sqrt(b*b - 4)) / (Math.Sqrt(b*b - 4) + b + 2);
                        double z2 = 1 / Math.Sqrt(b+2);
                        Console.WriteLine("z1 = {0}, z2 = {1}", z1, z2);
                    } 
                    break;
                case 2:
                    {
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 6: Console.WriteLine("шесть"); break;
                            case 7: Console.WriteLine("семь"); break;
                            case 8: Console.WriteLine("восемь"); break;
                            case 9: Console.WriteLine("девять"); break;
                            case 10: Console.WriteLine("десять"); break;
                            case 11: Console.WriteLine("валет"); break;
                            case 12: Console.WriteLine("дама"); break;
                            case 13: Console.WriteLine("король"); break;
                            case 14: Console.WriteLine("туз"); break;
                            default: Console.WriteLine("6-14"); break;
                        }
                    } 
                    break;
                default: Console.WriteLine("1 или 2 надо вводить"); break;
            }
            Console.ReadKey(true);
        }
    }
}
