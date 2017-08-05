using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    public class Stack<T>
    {
        T[] stack;
        int stackPointer;

        public Stack(int size)
        {
            if (size >= 0 )
            {
                stack = new T[size];
                stackPointer = 0;
                return;
            }
            throw new ArgumentOutOfRangeException();
        }

        public void Push(T data)
        {
            if (stackPointer < stack.Length)
            {
                stack[stackPointer++] = data;
                return;
            }
            throw new StackOverflowException();
        }

        public T Pop()
        {
            if (stackPointer > 0)
            {
                return stack[--stackPointer];
            }
            throw new StackUnderflowException();
        }

        public T Peek()
        {
            if (stackPointer > 0)
            {
                return stack[stackPointer - 1];
            }
            throw new StackEmptyException();
        }

        public int Size()
        {
            return stack.Length;
        }

        public int FreeSpacesLeft()
        {
            return stack.Length - stackPointer;
        }

    }

    
}
