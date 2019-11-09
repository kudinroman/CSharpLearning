using System;

namespace CSharpLearning.Web.Models.DataStructures
{
    public class LinkedListItem<T>
    {
        public T Data { get; set; }

        public LinkedListItem<T> Next { get; set; }

        public LinkedListItem(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
