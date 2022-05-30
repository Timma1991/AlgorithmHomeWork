using BenchmarkDotNet.Attributes;
using System.Text;

namespace MyLongHomeWork
{
    public class Benchmarks

    {

        string[] exampleStrings = new string[10000];
        static Random rand = new Random();
        string[] benchArr;
        HashSet<string> benchSet;



        public Benchmarks()
        {
            for (int i = 0; i < exampleStrings.Length; i++)
            {
                exampleStrings[i] = getRandomString(rand.Next(10));
            }
            benchArr = new string[exampleStrings.Length];
            benchSet = new HashSet<string>(exampleStrings.Length);
        }

        [Benchmark]
        public void benchmarkAddToArray()
        {
            for (int i = 0; i < exampleStrings.Length; i++)
            {
                benchArr[i] = exampleStrings[i];
            }
        }

        [Benchmark]
        public void benchmarkAddToHashSet()
        {
            for (int i = 0; i < exampleStrings.Length; i++)
            {
                benchSet.Add(exampleStrings[i]);
            }
        }

        [Benchmark]
        public void benchmarkSearchHashSet()
        {
            for (int i = 0; i < exampleStrings.Length; i++)
            {
                benchSet.Contains(exampleStrings[i]);
            }
        }

        [Benchmark]
        public void benchmarkSearchArray()
        {
            for (int i = 0; i < exampleStrings.Length; i++)
            {
                benchArr.Contains(exampleStrings[i]);
            }
        }

        public static string getRandomString(int len)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append(((char)rand.Next('a', 'z' + 1)));
            }
            return sb.ToString();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}