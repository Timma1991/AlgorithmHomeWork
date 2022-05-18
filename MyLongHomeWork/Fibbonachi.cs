using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLongHomeWork
{
    /*
     * Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
     */
    public static class Fibonachi
    {
        internal static void Start()
        {
            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine());
            int FirstNumber = 0;
            Console.Write("{0} ", FirstNumber);
            int SecondNumber = 1;
            Console.Write("{0} ", SecondNumber);
            int summa = 0;
            while (number >= summa)
            {
                summa = FirstNumber + SecondNumber;

                Console.Write("{0} ", summa);

                FirstNumber = SecondNumber;
                SecondNumber = summa;
            }
        }
        static int Fib(int n, int p1 = 0, int p2 = 1)
        {
            if (n <= 1) return p1;
            int p;
            for (int j = 2; j < n; j++)
            {
                p = p1;
                p1 = p2;
                p2 = p2 + p;
            }
            return p2;
        }
        private static int[] Fi = new int[100];
        private static void MainCheckRecurthion(string[] args)
        {
            Console.WriteLine(Fib(10));
        }

        private static int Fib(int n)
        {
            if (n <= 1) return n;

            if (Fi[n] != 0) return Fi[n];

            Fi[n] = Fib(n - 2) + Fib(n - 1);
            return Fi[n];
        }
    }
}
