﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToDoList
{
    public class ToDoItem
    {
        #region propertis
        private static int _Id = -1;
        public int Id { get { return _Id; } }
        public string Discript { set; get; }
        public bool IsDone { set; get; }
        #endregion


        #region Constructor
        public ToDoItem(string _discript)
        {
            _Id = _Id + 1;
            Discript = _discript;
            IsDone = false;
        }
        public ToDoItem()
        {

        }

        #endregion

        #region Function
        public override string ToString()
        {
            return $"Id={Id}\t Discript={Discript}\t IsDone={IsDone} ";
        }
        #endregion
    }
}
