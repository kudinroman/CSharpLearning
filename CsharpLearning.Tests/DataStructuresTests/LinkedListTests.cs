using CSharpLearning.Web.Models.DataStructures;
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

            // Assert
            Assert.Equal(4, linkedList.Count);

            // Act
            linkedList.Delete(3);

            // Assert
            Assert.Equal(3, linkedList.Count);

            // Act
            linkedList.Clear();

            // Assert
            Assert.Equal(0, linkedList.Count);
        }
    }
}
