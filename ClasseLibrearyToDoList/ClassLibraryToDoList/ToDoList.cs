using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToDoList
{
    public class ToDoList : IEnumerable<ToDoItem>
    {
        #region Variables
        private List<ToDoItem> _Taskitem;
        #endregion

        #region Constructors
        public ToDoList(IEnumerable<ToDoItem> Taskitem)
        {
            _Taskitem = Taskitem.ToList();

        }
        public ToDoList()
        {
            _Taskitem = new List<ToDoItem>();

        }
        #endregion


        #region  Functions
        public void Add(ToDoItem item)
        {
            if (_Taskitem != null)

                _Taskitem.Add(item);
            else
                throw new NullReferenceException();
        }

        public bool IsConteynt(ToDoItem item)
        {
            return _Taskitem.Contains(item);
        }
        public void All()
        {
            for (int i = 0; i < _Taskitem.Count; i++)
            {
                Console.WriteLine(_Taskitem[i].ToString());
            }
        }
        public IEnumerable<ToDoItem> ShowCompletd()
        {
            var e = from s in _Taskitem
                    where s.IsDone == true
                    select s;

            return e;
        }

        public void ReceiveCompletd()
        {
            var e = from s in _Taskitem
                    where s.IsDone == true
                    select s;

            foreach (var i in e)
            {
                Console.WriteLine(i.ToString());
            }

        }

        public int ReturnItm(ToDoItem item)
        {
            if (_Taskitem.Contains(item))
            {
                var itemindex = _Taskitem.IndexOf(item);

                return itemindex;
            }
            else
            {
                throw new ArgumentException("Argument not found");
            }
        }
        public void ChangeActive(ToDoItem item)
        {
            if (_Taskitem.Contains(item))
            {                

                if (item.IsDone == true)
                {
                    item.IsDone = false;
                }
                else

                if (item.IsDone == false)
                {
                    item.IsDone = true;
                }
            }
            else
            {
                throw new ArgumentException("Argument not found");
            }
        }
        public void ShowActive()
        {
            var e = from s in _Taskitem
                    where s.IsDone == false
                    select s;

            foreach (var i in e)
            {
                Console.WriteLine(i.ToString());
            }
        }


        public IEnumerable<ToDoItem> ReceiveActive()
        {
            var e = from s in _Taskitem
                    where s.IsDone == false
                    select s;
            return e;
           
        }

        public void Remove(ToDoItem item)
        {
            _Taskitem.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _Taskitem.RemoveAt(index);

        }

        public IEnumerator<ToDoItem> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Taskitem.GetEnumerator();
        }
        #endregion
    }
}
