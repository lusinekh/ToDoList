using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryToDoList;


namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Taskitem item1 = new Taskitem("to make the homeWork");
            Taskitem item2 = new Taskitem("listen to music");
            Taskitem item3 = new Taskitem("read the book");

            ToDoList ToDo = new ToDoList { item1 };
            ToDo.Add(item2);
            ToDo.Add(item3);
            ToDo.All();

            Console.WriteLine("---------ChangeActive-------------");

            ToDo.ChangeActive(item1);
            ToDo.All();

            Console.WriteLine("---------Active-------------");

            ToDo.Active();

            Console.WriteLine("---------Completd-------------");
            ToDo.Completd();

            Console.WriteLine("---------Remove-------------");
            ToDo.Remove(item2);


            Console.WriteLine("---------RemoveAt-------------");
            ToDo.RemoveAt(0);

        }
    }
}
