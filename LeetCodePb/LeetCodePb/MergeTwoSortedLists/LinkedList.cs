namespace LeetCodePb.MergeTwoSortedLists
{
	internal class LinkedList
	{
		internal ListNode Head { get; set; }
		public LinkedList()
		{

		}
		public LinkedList(ListNode head)
		{
			Head = head;
		}
		public void AddToTheLast(ListNode node)
		{
			if (Head == null)
			{
				Head = node;
			}
			else
			{
				ListNode temp = Head;
				while (temp.next != null)
					temp = temp.next;
				temp.next = node;
			}
		}
		public override string ToString()
		{
			string result = "[";
			ListNode temp = Head;
			while (temp != null)
			{
				result += temp + ",";
				temp = temp.next;
			}
			return result + "]";
		}
	}
}
