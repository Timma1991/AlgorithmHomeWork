namespace MyLongHomeWork
{

    internal class FirstTask
    {
        const string simple = "Простое число";
        const string complex = "Не простое число";
        internal static void Start()
        {
            string testCase1 = Summari(5);
            string testCase2 = Summari(6);
            Console.WriteLine($"case1: {testCase1.Equals(simple)}");
            Console.WriteLine($"case2: {testCase2.Equals(complex)}");
        }

        static string Summari(int value1)
        {
            int d = 0;
            int i = 2;
            while (i < value1)
            {
                if (value1 % i == 0)
                {
                    d++;
                }
                i++;

            }
            if (d == 0)
            {
                return simple;
            }
            else
            {
                return complex;
            }
        }
    }
}
