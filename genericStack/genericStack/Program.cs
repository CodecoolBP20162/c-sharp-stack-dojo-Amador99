using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    class customStack<T>
    {
        private T[] array;
        private int size;
        private int top;
        public int Size 
        {
            get { return size; }
            set { size = value; }
        }


        public customStack(int size)
        {
            this.size = size;
            array = new T[size];
        }

        public void Push(T data)
        {
            top = top + 1;
            array[top] = data;
        }

        public T Pop()
        {
            T RemovedElement;
            RemovedElement = array[top];
            top = top - 1;
            return RemovedElement;
        }

        public T peep()
        {
           return array[top];
        }


    }
}
