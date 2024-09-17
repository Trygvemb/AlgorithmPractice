using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AlgorithmLibrary.Queues;

namespace AlgorithmLibrary.Test
{
    public class ArrayQueueTest
    {
        [Fact]
        public void Enqueue_ShouldAddItemsToQueue()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Front());
            Assert.Equal(3, queue.Rear());
        }

        [Fact]
        public void Dequeue_ShouldRemoveItemsFromQueue()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
        }

        [Fact]
        public void IsFull_ShouldReturnTrueWhenQueueIsFull()
        {
            var queue = new ArrayQueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.True(queue.IsFull());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrueWhenQueueIsEmpty()
        {
            var queue = new ArrayQueue(3);

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void Front_ShouldReturnFrontItemWithoutRemovingIt()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.Equal(1, queue.Front());
            Assert.Equal(1, queue.Front()); // Ensure the item is not removed
        }

        [Fact]
        public void Rear_ShouldReturnRearItemWithoutRemovingIt()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.Equal(2, queue.Rear());
            Assert.Equal(2, queue.Rear()); // Ensure the item is not removed
        }

        [Fact]
        public void Dequeue_ShouldReturnMinValueWhenQueueIsEmpty()
        {
            var queue = new ArrayQueue(5);

            Assert.Equal(int.MinValue, queue.Dequeue());
        }

        [Fact]
        public void Front_ShouldReturnMinValueWhenQueueIsEmpty()
        {
            var queue = new ArrayQueue(5);

            Assert.Equal(int.MinValue, queue.Front());
        }

        [Fact]
        public void Rear_ShouldReturnMinValueWhenQueueIsEmpty()
        {
            var queue = new ArrayQueue(5);

            Assert.Equal(int.MinValue, queue.Rear());
        }

        [Fact]
        public void Enqueue_ShouldNotAddItemWhenQueueIsFull()
        {
            var queue = new ArrayQueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4); // This should not be added

            Assert.Equal(3, queue.Rear());
            Assert.Equal(3, queue.GetQueueElements().Count);
        }

        [Fact]
        public void GetQueueElements_ShouldReturnAllElementsInOrder()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var elements = queue.GetQueueElements();

            Assert.Equal(new List<int> { 1, 2, 3 }, elements);
        }

        [Fact]
        public void EnqueueDequeue_ShouldHandleMultipleOperations()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Enqueue(5);
            queue.Enqueue(6);

            Assert.Equal(new List<int> { 3, 4, 5, 6 }, queue.GetQueueElements());
        }
    }
}