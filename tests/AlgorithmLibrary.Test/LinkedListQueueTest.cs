using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AlgorithmLibrary.Queues;

namespace AlgorithmLibrary.Test
{
    public class LinkedListQueueTest
    {
        [Fact]
        public void Enqueue_ShouldAddElementToQueue()
        {
            var queue = new LinkedListQueue();
            queue.Enqueue(10);
            Assert.Equal(10, queue.Front());
            Assert.Equal(10, queue.Rear());
        }

        [Fact]
        public void Dequeue_ShouldRemoveElementFromQueue()
        {
            var queue = new LinkedListQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            int dequeued = queue.Dequeue();
            Assert.Equal(10, dequeued);
            Assert.Equal(20, queue.Front());
        }

        [Fact]
        public void Dequeue_ShouldReturnMinValue_WhenQueueIsEmpty()
        {
            var queue = new LinkedListQueue();
            int dequeued = queue.Dequeue();
            Assert.Equal(int.MinValue, dequeued);
        }

        [Fact]
        public void Front_ShouldReturnMinValue_WhenQueueIsEmpty()
        {
            var queue = new LinkedListQueue();
            Assert.Equal(int.MinValue, queue.Front());
        }

        [Fact]
        public void Rear_ShouldReturnMinValue_WhenQueueIsEmpty()
        {
            var queue = new LinkedListQueue();
            Assert.Equal(int.MinValue, queue.Rear());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrue_WhenQueueIsEmpty()
        {
            var queue = new LinkedListQueue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalse_WhenQueueIsNotEmpty()
        {
            var queue = new LinkedListQueue();
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }

        [Fact]
        public void IsFull_ShouldAlwaysReturnFalse()
        {
            var queue = new LinkedListQueue();
            Assert.False(queue.IsFull());
        }

        [Fact]
        public void GetQueueElements_ShouldReturnAllElementsInQueue()
        {
            var queue = new LinkedListQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var elements = queue.GetQueueElements();

            Assert.Equal(new List<int> { 10, 20, 30 }, elements);
        }

        [Fact]
        public void GetQueueElements_ShouldReturnEmptyList_WhenQueueIsEmpty()
        {
            var queue = new LinkedListQueue();

            var elements = queue.GetQueueElements();

            Assert.Empty(elements);
        }
    }
}