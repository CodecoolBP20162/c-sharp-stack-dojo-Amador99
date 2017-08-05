using Microsoft.VisualStudio.TestTools.UnitTesting;
using genericStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void StackTest()
        {
            Assert.IsNotNull(new Stack<int>(10));
        }

        [TestMethod()]
        public void StackTest_InvalidSize()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Stack<int>(-1));
        }

        [TestMethod()]
        public void PushTest()
        {
            var stack = new Stack<int>(12);
            stack.Push(3);
            stack.Push(4);
            Assert.AreEqual(10, stack.FreeSpacesLeft());
        }

        [TestMethod()]
        public void PushTest_Overflow()
        {
            var stack = new Stack<int>(2);
            stack.Push(3);
            stack.Push(4);
            Assert.ThrowsException<StackOverflowException>(() => stack.Push(5));
        }

        [TestMethod()]
        public void PopTest()
        {
            var stack = new Stack<string>(12);
            stack.Push("3");
            stack.Push("4");
            stack.Push("444");
            Assert.AreEqual("444", stack.Pop());
            Assert.AreEqual("4", stack.Pop());
            Assert.AreEqual("3", stack.Pop());
        }

        [TestMethod()]
        public void PopTest_Underflow()
        {
            var stack = new Stack<string>(12);
            Assert.ThrowsException<StackUnderflowException>(() => stack.Pop());

            stack.Push("444");
            Assert.AreEqual("444", stack.Pop());
            Assert.ThrowsException<StackUnderflowException>(() => stack.Pop());
        }

        [TestMethod()]
        public void PeekTest()
        {
            var stack = new Stack<long>(12);
            stack.Push(1000000000);
            Assert.AreEqual(1000000000, stack.Peek());
            Assert.AreEqual(1000000000, stack.Pop());
        }

        [TestMethod()]
        public void PeekTest_EmptyStack()
        {
            var stack = new Stack<long>(12);
            Assert.ThrowsException<StackEmptyException>(() => stack.Peek());
        }

        [TestMethod()]
        public void SizeTest()
        {
            var stack = new Stack<string>(101);
            Assert.AreEqual(101, stack.Size());
        }

    }
}