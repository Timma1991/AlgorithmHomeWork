namespace MyLongHomeWork
{
    internal class EmptyLesson4 : ConsoleInterface
    {
        public string name => "3,4";

        public string description => "Выводит на экран задание 3 и 4";

        public void Run()
        {
            ITree tree = new Tree();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                tree.AddItem(random.Next(0, 10));
            }
            tree.PrintTree();
        }
    }
}
