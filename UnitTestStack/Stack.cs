using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStack
{
	public class Stack
	{
		private ArrayList elements = new ArrayList();

		public bool IsEmpty
		{
			get
			{
				return elements.Count==0;
			}
		}

		public void Push(object element)
		{
			elements.Insert(0, element);
		}

		//public object Pop()
		//{
		//	if(IsEmpty) throw new InvalidOperationException("cannot pop an empty stack");
		//	object top = elements[0];
		//	elements.RemoveAt(0);
		//	return top;
		//}

		//public object Top()
		//{
		//	if (IsEmpty) throw new InvalidOperationException("cannot Top an empty stack");
		//	return elements[0];
		//}

		public object Pop()
		{
			object top = Top();
			elements.RemoveAt(0);
			return top;
		}

		public object Top()
		{
			if (IsEmpty)
				throw new InvalidOperationException("Stack is Empty");
			return elements[0];
		}			

	}
}
