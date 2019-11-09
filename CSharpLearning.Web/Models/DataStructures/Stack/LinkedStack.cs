using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLearning.Web.Models.DataStructures.Stack
{
    public class LinkedStack<T>
    {
        public StackItem<T> Head { get; set; }
        public int Count = 0;

        public LinkedStack() { }
        public LinkedStack(T data)
        {
            Head = new StackItem<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new StackItem<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public StackItem<T> Pop()
        {
            if (Count != 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item;
            }
            else
                throw new NullReferenceException("Stack is empty");
        }

        public StackItem<T> Peek()
        {
            if (Count != 0)
                return Head;
            else
                throw new NullReferenceException("Stack is empty");
        }

        public override string ToString()
        {
            return $"Stack with {Count} elements";
        }
    }
}
