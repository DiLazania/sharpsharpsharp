using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class StackElement<T>
    {
        public StackElement<T> _nextElement;
        public T data { get; }
        public StackElement(T data) => this.data = data;
    }

    public class StackT<T>
    {
        private StackElement<T> top;

        public int ElemCount { get; private set; }
        public bool IsEmpty()
        {
            if (ElemCount == 0) return true;
            return false;
        }
        public void Push(T obj)
        {
            var newElem = new StackElement<T>(obj) { _nextElement = this.top };
            this.top = newElem;
            ElemCount++;
        }

        public T Pop()
        {
            var popped = top;
            top = top._nextElement;
            ElemCount--;
            return popped.data;
        }

        public T Peek() => top.data;

        public void PrintStack()
        {
            var temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp._nextElement;
            }
        }

        public void PurgeStack()
        {
            while (top != null) Pop();
        }
        

    }


}
