using CSharpLearning.Web.Models.DataStructures;
using LinkedList.Model;
using System.Linq;
using Xunit;

namespace CSharpLearning.Tests.DataStructuresTests
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedListItem()
        {
            // Arrange
            var item = new LinkedListItem<int>(5);

            // Act
            var result = item.Data;
            var next = item.Next;

            // Assert
            Assert.Equal(typeof(int), result.GetType());
            Assert.Equal(5, result);
            Assert.Null(next);
        }

        [Fact]
        public void LinkedList()
        {
            // Arrange
            var linkedList = new LinkedList<int>();

            // Act
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            var count1 = linkedList.Count;
            linkedList.Delete(3);
            var count2 = linkedList.Count;
            linkedList.Clear();
            var count3 = linkedList.Count;

            // Assert
            Assert.Equal(4, count1);
            Assert.Equal(3, count2);
            Assert.Equal(0, count3);
        }

        [Fact]
        public void DuplexLinkedList()
        {
            // Arrange
            var duplexLinkedList = new DuplexLinkedList<int>();

            // Act
            duplexLinkedList.Add(1);
            duplexLinkedList.Add(2);
            duplexLinkedList.Add(3);
            duplexLinkedList.Add(4);
            var count1 = duplexLinkedList.Count;
            duplexLinkedList.Delete(3);
            var count2 = duplexLinkedList.Count;
            var head = duplexLinkedList.Head;
            var reversed = duplexLinkedList.Reverse();

            // Assert
            Assert.Equal(4, count1);
            Assert.Equal(3, count2);
            Assert.Equal(head.Data, reversed.Tail.Data);
        }

        [Fact]
        public void CircularLinkedList()
        {
            // Arrange
            var circularLinkedList = new CircularLinkedList<int>();

            // Act
            circularLinkedList.Add(1);
            circularLinkedList.Add(2);
            circularLinkedList.Add(3);
            circularLinkedList.Add(4);
            var count1 = circularLinkedList.Count;
            circularLinkedList.Delete(3);
            var count2 = circularLinkedList.Count;

            var count = 0;
            for (var i = 0; i < circularLinkedList.Count * 2; i++)
                count++;

            // Assert
            Assert.Equal(4, count1);
            Assert.Equal(3, count2);
            Assert.Equal(circularLinkedList.Count * 2, count);
        }
    }
}
