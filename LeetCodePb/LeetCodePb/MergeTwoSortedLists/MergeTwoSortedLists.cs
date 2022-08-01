namespace LeetCodePb.MergeTwoSortedLists
{
	internal class MergeTwoSortedLists
	{
		public void PrintMergeTwoSortedListsSolution()
		{

			//Example 1
			LinkedList list11 = new LinkedList();
			LinkedList list12 = new LinkedList();

			list11.AddToTheLast(new ListNode(1));
			list11.AddToTheLast(new ListNode(2));
			list11.AddToTheLast(new ListNode(4));

			// ListNode head2 = new ListNode(2); 
			list12.AddToTheLast(new ListNode(1));
			list12.AddToTheLast(new ListNode(3));
			list12.AddToTheLast(new ListNode(4));

			Console.WriteLine("====== Example 1 =======");
			var headResult = MergeTwoLists(list11.Head, list12.Head);
			var resultLinkedList = new LinkedList(headResult);
			Console.WriteLine(resultLinkedList);

			//Example 2
			LinkedList list21 = new LinkedList();
			LinkedList list22 = new LinkedList();

			Console.WriteLine("====== Example 2 =======");
			var headResult2 = MergeTwoLists(list21.Head, list22.Head);
			var resultLinkedList2 = new LinkedList(headResult2);
			Console.WriteLine(resultLinkedList2);

			//Example 3
			LinkedList list31 = new LinkedList();
			LinkedList list32 = new LinkedList();
			list32.AddToTheLast(new ListNode(0));

			Console.WriteLine("====== Example 3 =======");
			var headResult3 = MergeTwoLists(list31.Head, list32.Head);
			var resultLinkedList3 = new LinkedList(headResult3);
			Console.WriteLine(resultLinkedList3);

		}

		private ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			ListNode auxNode = new ListNode(0);
			ListNode tail = auxNode;

			while (true)
			{
				if (list1 == null)
				{
					tail.next = list2;
					break;
				}

				if (list2 == null)
				{
					tail.next = list1;
					break;
				}

				if (list1.val <= list2.val)
				{
					tail.next = list1;
					list1 = list1.next;
				}
				else
				{
					tail.next = list2;
					list2 = list2.next;
				}
				tail = tail.next;
			}
			return auxNode.next;
		}
	}
}
