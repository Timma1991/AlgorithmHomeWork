using BenchmarkDotNet.Running;
using MyLongHomework;

namespace MyLongHomeWork
{
    public class PointBenchmarksLesson : ConsoleInterface
    {
        public string name => "3";

        public string description => "Задание 3";

        public void Run()
        {
            BenchmarkRunner.Run(typeof(PointBenchmarks).Assembly);
        }
    }
}
