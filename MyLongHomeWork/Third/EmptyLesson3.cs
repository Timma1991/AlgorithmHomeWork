using BenchmarkDotNet.Running;

namespace MyLongHomeWork
{
    internal class EmptyLesson3
    {
        public string name => "3";

        public string description => "Выводит на экран задание 3";
        public void Run()
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}