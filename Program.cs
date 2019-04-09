using System;
using static System.Console;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {

           // CallMethod(args);
           var generator = new FibonacciGenerator();
           foreach (var digit in generator.Generate(15))
           {
               WriteLine(digit);
           }
        }
        static void CallMethod(string[] args)
        {
            if (args.Length > 0)
            {
                System.Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello World!");

            }
            System.Console.WriteLine("Fibonacci Number 1-15");
            for (int i = 0; i < 15; i++)
            {
                System.Console.WriteLine($"{i + 1}:{FibonacciNumber(i)}");
            }
        }
        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;
            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }
}
