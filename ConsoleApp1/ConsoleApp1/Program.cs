using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(Fib(i));
            //}
            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            if (n <= 1) {
                return n;
            }
            else
            {
                return (Fib(n - 1) + Fib(n - 2));
            }
        }
    }
}
