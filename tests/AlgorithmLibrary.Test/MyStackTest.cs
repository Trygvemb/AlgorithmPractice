using System;
using Xunit;
using AlgorithmLibrary.Arrays;

namespace AlgorithmLibrary.Test
{
    public class MyStackTest
    {
        [Fact]
        public void Push_ShouldAddElementToStack()
        {
            // Arrange
            MyStack stack = new MyStack();

            // Act
            stack.Push(10);

            // Assert
            Assert.Equal(10, stack.Pop());
        }

        [Fact]
        public void Pop_ShouldRemoveAndReturnTopElement()
        {
            // Arrange
            MyStack stack = new MyStack();
            stack.Push(20);
            stack.Push(30);

            // Act
            int result = stack.Pop();

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Pop_ShouldThrowException_WhenStackIsEmpty()
        {
            // Arrange
            MyStack stack = new MyStack();

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
        }
    }
}