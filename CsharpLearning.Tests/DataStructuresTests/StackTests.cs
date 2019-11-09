using CodeBlogStack.Model;
using CSharpLearning.Web.Models.DataStructures;
using CSharpLearning.Web.Models.DataStructures.Stack;
using Xunit;

namespace CSharpLearning.Tests.DataStructuresTests
{
    public class StackTests
    {
        [Fact]
        public void EasyStack()
        {
            // Arrange
            var stack = new EasyStack<int>();

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            var removed = stack.Pop();
            var last = stack.Peek();

            // Assert
            Assert.Equal(4, stack.Count);
            Assert.Equal(5, removed);
            Assert.Equal(4, last);
        }

        [Fact]
        public void LinkedStack()
        {
            // Arrange
            var stack = new LinkedStack<int>();

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var head1 = stack.Peek();
            var removed1 = stack.Pop();
            var removed2 = stack.Pop();
            var head2 = stack.Peek();

            // Assert
            Assert.Equal(5, head1.Data);
            Assert.Equal(5, removed1.Data);
            Assert.Equal(4, removed2.Data);
            Assert.Equal(3, head2.Data);
            Assert.Equal(3, stack.Count);
        }

        [Fact]
        public void ArrayStack()
        {
            // Arrange
            var stack = new ArrayStack<int>();

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var head1 = stack.Peek();
            var removed1 = stack.Pop();
            var removed2 = stack.Pop();
            var head2 = stack.Peek();

            // Assert
            Assert.Equal(5, head1);
            Assert.Equal(5, removed1);
            Assert.Equal(4, removed2);
            Assert.Equal(3, head2);
            Assert.Equal(3, stack.Count);
        }
    }
}
