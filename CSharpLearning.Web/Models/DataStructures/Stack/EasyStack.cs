using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearning.Web.Models.DataStructures
{
    public class EasyStack<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack with {Count} elements";
        }

        public object Clone()
        {
            var easyStack = new EasyStack<T>
            {
                items = new List<T>(items)
            };

            return easyStack;
        }
    }
}
