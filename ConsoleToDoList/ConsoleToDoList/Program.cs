using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryToDoList;

namespace ConsoleToDoList
{
    class Program
    {
        static void Main(string[] args)
        {

            Taskitem b = new Taskitem("ergel");
            //Console.WriteLine(b.ToString());
            Taskitem e = new Taskitem("parel");
            //Console.WriteLine(e.ToString());

            Taskitem n = new Taskitem("parel");
            //Console.WriteLine(n.ToString());
            Taskitem[] jk = { b, e, n };
            ToDoList ToDo = new ToDoList(jk);

            ToDo.ShowToDoList();

            //Console.WriteLine("Adde item");


            //ToDo.Add(b);
            //ToDo.ShowToDoList();


            //Console.WriteLine("After delete");

            //ToDo.Remove(b);
            //ToDo.ShowToDoList();
            //Console.WriteLine("RemoveAt");
            //ToDo.RemoveAt(1);
            //ToDo.ShowToDoList();

            ////ToDoList e1 = new ToDoList();
            //Console.WriteLine("give index");
            //  Console.WriteLine(ToDo.EditeActive(true, e));

            //Console.WriteLine()

            //ToDo.ShowToDoList();

            //List<int> v = new List<int>();
            //v.Add(8);
            //v.Add(78);
            //v.Add(6);

            //Console.WriteLine(v.IndexOf(8));


            //Console.WriteLine("Avter done edite");

            //ToDo.ShowToDoList();
            Console.WriteLine("Avter done Activite");
            ToDo.ChangeActive(b);

            //ToDo.ShowToDoList();
            ToDo.Active();
            //ToDo.ShowToDoList();

            Console.WriteLine("Avter done Completed");
            ToDo.Completd();

            Console.WriteLine("Alll");
            ToDo.All();
        }
    }
}
