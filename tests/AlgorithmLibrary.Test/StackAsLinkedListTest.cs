using System;
using Xunit;
using AlgorithmLibrary.Stacks;

namespace AlgorithmLibrary.Test
{
    public class StackAsLinkedListTest
    {
        [Fact]
        public void Push_ShouldAddElementToStack()
        {
            // Arrange
            var stack = new StackAsLinkedList();

            // Act
            stack.Push(10);

            // Assert
            Assert.False(stack.IsEmpty());
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Pop_ShouldRemoveAndReturnTopElement()
        {
            // Arrange
            var stack = new StackAsLinkedList();
            stack.Push(10);
            stack.Push(20);

            // Act
            int poppedElement = stack.Pop();

            // Assert
            Assert.Equal(20, poppedElement);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Pop_ShouldThrowException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new StackAsLinkedList();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Peek_ShouldReturnTopElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new StackAsLinkedList();
            stack.Push(10);
            stack.Push(20);

            // Act
            int topElement = stack.Peek();

            // Assert
            Assert.Equal(20, topElement);
            Assert.Equal(20, stack.Peek()); // Ensure the element is not removed
        }

        [Fact]
        public void Peek_ShouldThrowException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new StackAsLinkedList();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrue_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new StackAsLinkedList();

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalse_WhenStackIsNotEmpty()
        {
            // Arrange
            var stack = new StackAsLinkedList();
            stack.Push(10);

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }

        [Fact]
        public void PrintStack_ShouldPrintAllElements()
        {
            // Arrange
            var stack = new StackAsLinkedList();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Act & Assert
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            stack.PrintStack();

            var output = stringWriter.ToString().Trim();
            Assert.Equal("30 20 10", output);
        }

        [Fact]
        public void PrintStack_ShouldThrowException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new StackAsLinkedList();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.PrintStack());
        }
    }
}