using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Deque
{
	class DoublyLinkedList<T> : IEnumerable
	{
		private int size;
		private Node _head;
		private Node _tail;

		public Node Head
		{
			get { return _head; }
		}
		public Node Tail
		{
			get { return _tail; }
		}

		public Boolean IsEmpty()
		{
			return size == 0;
		}

		public void AddFirst(T Value)
		{
			Node NewNode = new Node(Value);
			if (_head == null)
			{
				_head = NewNode;
				_tail = NewNode;
			}
			else
			{
				NewNode.Next = _head;
				_head.Prev = NewNode;
				_head = NewNode;
			}
			size++;
		}

		public void AddLast(T Value)
		{
			Node NewNode = new Node(Value);
			if (_tail == null)
			{
				_tail = NewNode;
				_head = NewNode;
			}
			else
			{
				NewNode.Prev = _tail;
				_tail.Next = NewNode;
				_tail = NewNode;
			}
			size++;
		}

		public T RemoveFirst()
		{
			T temp = _head.Value;
			_head = _head.Next;
			_head.Prev = null;
			size--;

			return temp;
		}

		public T RemoveLast()
		{
			T temp = _tail.Value;
			_tail = _tail.Prev;
			_tail.Next = null;
			size--;

			return temp;
		}

		public IEnumerator GetEnumerator()
		{
			Node CurrentNode = _head;
			while (CurrentNode != null)
			{
				yield return CurrentNode.Value;
				CurrentNode = CurrentNode.Next;
			}
		}

		internal class Node 
		{
			public T Value;
			public Node Next;
			public Node Prev;
			public Node(T value)
			{
				Value = value;
				Next = null;
				Prev = null;
			}
		}
	}
}
