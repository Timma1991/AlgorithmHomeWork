using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLongHomeWork
{
    internal class EmptyLesson7 : ConsoleInterface
    {


        public string name => "7";

        public string description => "Выводит на экран все решения о 8-ми ферзях";

        public void Run()
        {
            FindAllPositionOfQueen x = new FindAllPositionOfQueen();
            x.TryQueen(0);
        }
    }
}    
        
    

