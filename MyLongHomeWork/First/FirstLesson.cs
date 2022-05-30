using MyLongHomework;

namespace MyLongHomeWork.First
{
    internal class FirstLesson : ConsoleInterface
    {
        public string name => "1";

        public string description => "Задания 1 и 2";

        public void Run()
        {
            string input = string.Empty;
            SerchingHomerWork serchingHomerWork = new SerchingHomerWork();
            while (input != "q")
            {
                Console.WriteLine("Введите номер домашнего задания");
                Console.WriteLine("1-Функции вычесления Фибоначи,асимптотическая сложность,функция блок-схемы\r\n2-двухсвязный список\r\n3-Просчет разных методов дистанции");
                Console.WriteLine("Для выхода нажмите q");
                input = Console.ReadLine();
                SerchingHomerWork.ParseCommandString(input);
            }

            Console.WriteLine(serchingHomerWork);
        }
    }
}
