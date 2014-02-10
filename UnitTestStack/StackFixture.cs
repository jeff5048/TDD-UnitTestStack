using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Should;

namespace UnitTestStack
{
	[TestFixture]
	public class StackFixture
	{
		private Stack stack;
		
		[SetUp]
		public void Init()
		{
			stack = new Stack();
		}

		[Test]
		//Test 1: Create a Stack and verify that IsEmpty is true.
		public void Empty()
		{
			Assert.IsTrue(stack.IsEmpty);
		}

		//[Test]
		//public void FailEmpty()
		//{
		//	Stack stack = new Stack();
		//	Assert.IsFalse(stack.IsEmpty);
		//}

		//Test 2: Push a single object on the Stack and verify that IsEmpty is false.
		[Test]
		public void PushOne()
		{
			stack.Push("first element");
			Assert.IsFalse(stack.IsEmpty, "After Push, IsEmpty should be false");
		}

		//Test 3: Push a single object, Pop the object, and verify that IsEmpty is true.
		[Test]
		public void Pop()
		{
			stack.Push("first element");
			stack.Pop();
			Assert.IsTrue(stack.IsEmpty, "After Push - Pop, IsEmpty should be true");
		}

		//Test 4: Push a single object, remembering what it is; Pop the object,
		//and verify that the two objects are equal.
		[Test]
		public void PushPopContentCheck()
		{
			int expected = 1234;
			stack.Push(expected);
			int actual = (int)stack.Pop();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		//Test 5: Push three objects, remembering what they are; Pop each one,
		//and verify that they are correct.
		public void PushPopMultipleElements()
		{
			string pushed1 = "1";
			stack.Push(pushed1);
			string pushed2 = "2";
			stack.Push(pushed2);
			string pushed3 = "3";
			stack.Push(pushed3);

			string popped = (string)stack.Pop();
			Assert.AreEqual(pushed3, popped);
			popped = (string)stack.Pop();
			Assert.AreEqual(pushed2, popped);
			popped = (string)stack.Pop();
			Assert.AreEqual(pushed1, popped);
		}

		[Test]
		//Test 6: Pop a Stack that has no elements.
		[ExpectedException(typeof(InvalidOperationException))]
		public void PopEmptyStack()
		{
			stack.Pop();
		}

		[Test]
		//Test 7: Push a single object and then call Top. Verify that IsEmpty
		//returns false.
		public void PushTop()
		{
			stack.Push("42");
			stack.Top();
			Assert.IsFalse(stack.IsEmpty);
		}

		[Test]
		//Test 8: Push a single object, remembering what it is; and then call Top.
		//Verify that the object that is returned is equal to the one that was
		//pushed.
		public void PushTopContentCheckOneElement()
		{
			string pushed = "42";
			stack.Push(pushed);
			string topped = (string)stack.Top();
			Assert.AreEqual(pushed, topped);
		}

		[Test]
		//Test 9: Push multiple objects, remembering what they are; call Top, and
		//verify that the last item pushed is equal to the one returned by Top.
		public void PushTopContentCheckMultiples()
		{
			string pushed3 = "3";
			stack.Push(pushed3);
			string pushed4 = "4";
			stack.Push(pushed4);
			string pushed5 = "5";
			stack.Push(pushed5);
			string topped = (string)stack.Top();
			Assert.AreEqual(pushed5, topped);
		}

		[Test]
		//Test 10: Push one object and call Top repeatedly, comparing what is
		//returned to what was pushed.
		public void PushTopNoStackStateChange()
		{
			string pushed = "44";
			stack.Push(pushed);
			for (int index = 0; index < 10; index++)
			{
				string topped = (string)stack.Top();
				Assert.AreEqual(pushed, topped);
			}
		}

		[Test]
		//Test 11: Call Top on a Stack that has no elements.
		[ExpectedException(typeof(InvalidOperationException))]
		public void TopEmptyStack()
		{
			stack.Top();
		}

		[Test]
		//Test 12: Push null onto the Stack and verify that IsEmpty is false.
		public void PushNull()
		{
			stack.Push(null);
			Assert.AreEqual(stack.IsEmpty, false);
		}

		[Test]
		//Test 13: Push null onto the Stack, Pop the Stack, and verify that the
		//value returned is null.
		public void PushNullCheckPop()
		{
			stack.Push(null);
			Assert.IsNull(stack.Pop());
			Assert.IsTrue(stack.IsEmpty);
		}

		[Test]
		//Test 14: Push null onto the Stack, call Top, and verify that the value
		//returned is null.
		public void PushNullCheckTop()
		{
			stack.Push(null);
			Assert.IsNull(stack.Top());
			Assert.IsFalse(stack.IsEmpty);
		}





	}
}
