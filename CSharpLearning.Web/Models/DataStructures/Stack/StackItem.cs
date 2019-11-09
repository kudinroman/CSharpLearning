namespace CSharpLearning.Web.Models.DataStructures
{
    public class StackItem<T>
    {
        public T Data { get; set; }
        public StackItem<T> Previous { get; set; }

        public StackItem(T data)
        {
            Data = data;
        }
    }
}
