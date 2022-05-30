using GeekBrainsTests;
using MyLongHomeWork;

namespace MyLongHomework
{


    public class SerchingHomerWork
    {
        static List<string> commandHistory = new List<string>();


        public static void ParseCommandString(string command)
        {

            commandHistory.Add(command);


            string[] commandParams = command.ToLower().Split(' ');
            if (commandParams.Length > 0)
            {
                switch (commandParams[0])
                {

                    case "1":

                        FirstTask.Start();
                        //Дз1,п.2
                        Console.WriteLine("O(N^3),асимптотическая сложность данной функции");
                        //Дз1,п.3
                        Fibonachi.Start();


                        break;
                    case "2":
                        MyLinkedList linkedList = new MyLinkedList();
                        linkedList.AddNode(2);
                        linkedList.AddNode(4);
                        linkedList.AddNode(6);
                        linkedList.AddNode(24);
                        linkedList.AddNode(12);
                        linkedList.AddNode(36);

                        linkedList.FindNode(4);

                        Console.WriteLine($"count: {linkedList.GetCount()}");
                        Console.WriteLine("remove 3 element");
                        linkedList.RemoveNode(3);
                        Console.WriteLine($"count: {linkedList.GetCount()}");
                        Node newNode = new Node();
                        newNode.Value = 4;
                        linkedList.AddNodeAfter(newNode, 12);
                        Console.WriteLine("added node after");
                        Console.WriteLine($"count: {linkedList.GetCount()}");
                        Console.WriteLine($"shouldnt be null: {linkedList.FindNode(3)}");
                        break;

                    case "3":

                    default:
                        break;
                }

            }

        }

    }
}