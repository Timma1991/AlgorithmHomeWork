using BenchmarkDotNet.Running;
using MyLongHomework;

namespace MyLongHomeWork
{
    public static class Program
    {
        public static void Main()
        {
            IList<ConsoleInterface> task = new List<ConsoleInterface>();
            {
                new FirstTask();
                new PointBenchmarksLesson();
                new EmptyLesson4();
            }
            foreach (ConsoleInterface lesson in task)
                Console.WriteLine($"Введите '{lesson.name}' для вызова задания {lesson.description}");
            string tasknumber = Console.ReadLine();
            foreach (ConsoleInterface lesson in task)
                if (lesson.name == tasknumber)
                    lesson.Run();
        }
    }
}