using System;

namespace Deque
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new DoublyLinkedList<int>();
			a.AddFirst(1);
			a.AddFirst(2);
			a.AddFirst(3);
			a.AddFirst(3);
			a.AddFirst(3);
			a.AddFirst(3);
			a.AddLast(1);
			a.AddLast(1);
			a.AddLast(1);
			a.AddLast(1);
			a.AddFirst(4);
			Console.WriteLine("----> " + a.RemoveFirst());

			foreach (var c in a)
			{
				Console.WriteLine(c);
			}
		
		}
	}
}
