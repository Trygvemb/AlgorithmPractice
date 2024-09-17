using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmLibrary.Test
{
    public class LinkekListTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void AddElementToLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            Assert.Contains(1, linkedList);
        }

        [Fact]
        public void RemoveElementFromLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.Remove(1);
            Assert.DoesNotContain(1, linkedList);
        }

        [Fact]
        public void FindElementInLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            var node = linkedList.Find(1);
            Assert.NotNull(node);
            Assert.Equal(1, node.Value);
        }

        [Fact]
        public void LinkedListIsEmptyAfterInitialization()
        {
            var linkedList = new LinkedList<int>();
            Assert.Empty(linkedList);
        }

        [Fact]
        public void LinkedListCountIncreasesAfterAddingElement()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            Assert.Equal(1, linkedList.Count);
        }

        [Fact]
        public void LinkedListCountDecreasesAfterRemovingElement()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.Remove(1);
            Assert.Equal(0, linkedList.Count);
        }
    }
}