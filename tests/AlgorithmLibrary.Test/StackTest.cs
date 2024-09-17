
using System;
using Xunit;
using AlgorithmLibrary.Stacks;

namespace AlgorithmLibrary.Test
{
    public class StackTest
    {
        [Fact]
        public void Push_ShouldAddItemToStack()
        {
            var stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Equal(3, stack.Peek());
        }

        [Fact]
        public void Pop_ShouldRemoveAndReturnTopItem()
        {
            var stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var item = stack.Pop();

            Assert.Equal(3, item);
            Assert.Equal(2, stack.Peek());
        }

        [Fact]
        public void Peek_ShouldReturnTopItemWithoutRemovingIt()
        {
            var stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var item = stack.Peek();

            Assert.Equal(3, item);
            Assert.Equal(3, stack.Peek());
        }

        [Fact]
        public void IsFull_ShouldThrowExceptionWhenStackIsFull()
        {
            var stack = new Stack(2);
            stack.Push(1);
            stack.Push(2);

            Assert.Throws<IndexOutOfRangeException>(() => stack.Push(3));
        }

        [Fact]
        public void IsEmpty_ShouldThrowExceptionWhenStackIsEmpty()
        {
            var stack = new Stack(2);

            Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
        }

        [Fact]
        public void PrintStack_ShouldPrintAllItems()
        {
            var stack = new Stack(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                stack.PrintStack();
                var result = sw.ToString().Trim();

                Assert.Equal("1 2 3", result);
            }
        }
    }
}
