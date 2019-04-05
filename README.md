# ToDoList
<h2>
This is a library.This library keeps our work done.
<h3>
The library contains the following functions:
<h6>
1.Add
<h6>
2.IsConteynt
<h6>
3.All
<h6>
4.Completd
<h6>
5.ReturnItm
<h6>
6.ChangeActive
<h6>
7.Remove
<h6>
8.RemoveAt

<h3>
Here is also the ConsoleApplication that is used in ClassLibraryToDoList

```C#
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

```
