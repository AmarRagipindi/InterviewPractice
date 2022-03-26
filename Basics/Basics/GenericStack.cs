using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class MyStack<T> where T :class
    {
        public List<T> Items { get; set; } = new List<T>();

        private int index;
        public void Push(T item)
        {
            index++;
            Items.Add(item);
        }
        public T Pop()
        {
            index--;
            if (index < 0)
                throw new IndexOutOfRangeException("Stack is empty Amar");
            
            var returnitem = Items[index];
            Items.RemoveAt(index);
            return returnitem;
        }
    }
}
