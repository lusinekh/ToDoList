using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToDoList
{
    public class ToDoList : IEnumerable<Taskitem>
    {
        #region Variables
        private List<Taskitem> _Taskitem;
        #endregion

        #region Constructors
        public ToDoList(IEnumerable<Taskitem> Taskitem)
        {
            _Taskitem = Taskitem.ToList();

        }
        public ToDoList()
        {
            _Taskitem = new List<Taskitem>();

        }
        #endregion


        #region  Functions
        public void Add(Taskitem item)
        {
            if (_Taskitem != null)

                _Taskitem.Add(item);
            else
                throw new NullReferenceException();
        }

        public bool IsConteynt(Taskitem item)
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
        public void Completd()
        {
            var e = from s in _Taskitem
                    where s.IsDone == true
                    select s;

            foreach (var i in e)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public int ReturnItm(Taskitem item)
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
        public void ChangeActive(Taskitem item)
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
        public void Active()
        {
            var e = from s in _Taskitem
                    where s.IsDone == false
                    select s;

            foreach (var i in e)
            {
                Console.WriteLine(i.ToString());
            }
        }
        public void Remove(Taskitem item)
        {
            _Taskitem.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _Taskitem.RemoveAt(index);

        }

        public IEnumerator<Taskitem> GetEnumerator()
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
