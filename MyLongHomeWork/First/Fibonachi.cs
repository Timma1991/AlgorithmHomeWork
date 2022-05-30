using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLongHomeWork
{
    /*
     * ��������� ����������� ����������� ������ � ������ ��� �������� (����� ����).
     */
    public static class Fibonachi
    {
        internal static void Start()
        {
            Console.WriteLine("�� ������ ����� ������� ��� ���������?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Recursive: {CalculateRecursive(number)}");
            Console.WriteLine($"Cycle: {Calculate(number)}");
        }
        static int CalculateRecursive(int n)
        {
            if (n == 0 || n == 1) return n;

            return CalculateRecursive(n - 1) + CalculateRecursive(n - 2);
        }

        static int Calculate(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result;
        }
    }
}