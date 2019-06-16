using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public class MyStack<T>
    {
        private int capacity;
        private T[] stack;
        private int top;

        public MyStack(int MaxElements)

        {
            capacity = MaxElements;
            stack = new T[capacity];
        }

        public bool Push(T Element)

        {
            if (top == capacity - 1)
            {
                return false;
            }
            else
            {
                top = top + 1;
                stack[top] = Element;
                return true;
            }
        }



        public T Pop()

        {
            if (!(top <= 0))
            {
                T RemovedElement = stack[top];
                top = top - 1;
                return RemovedElement;
            }
            throw new IndexOutOfRangeException();
        }


        public T Peep(int position)
        {
            if (position < capacity && position >= 0)
                return stack[position];

            throw new IndexOutOfRangeException();
        }

        public T[] GetAllStackElements()

        {

            T[] Elements = new T[top + 1];

            Array.Copy(stack, 0, Elements, 0, top + 1);

            return Elements;

        }

    }
}
