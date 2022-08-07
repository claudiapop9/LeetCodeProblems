namespace LeetCodePb.BuySellStock
{
	internal class BuySellStock : ISolution
	{
		public void PrintSolution()
		{
			//Console.WriteLine("===== Example 1 ======");
			//Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
			//Console.WriteLine("===== Example 2 ======");
			//Console.WriteLine(MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
			//Console.WriteLine("===== Example 3 ======");
			//Console.WriteLine(MaxProfit(new int[] { 1, 4, 2 }));
			//Console.WriteLine("===== Example 4 ======");
			//Console.WriteLine(MaxProfit(new int[] { 3, 2, 6, 5, 0, 3 }));
			//Console.WriteLine("===== Example 5 ======");
			//Console.WriteLine(MaxProfit(new int[] { 1 }));
			Console.WriteLine("===== Example 6 ======");
			Console.WriteLine(MaxProfit(new int[] { 2, 1, 2, 0, 1 }));
		}

		private int MaxProfit(int[] prices)
		{
			var len = prices.Length;
			if (prices.Length <= 1 || prices.Length > 100000)
			{
				return 0;
			}

			var mergedInterval = MergeIntervals(ConvertToInterval(prices));
			var maxProfit = mergedInterval.end - mergedInterval.start;

			return maxProfit > 0 ? maxProfit : 0;
		}

		private IList<Interval> ConvertToInterval(int[] array)
		{
			var intervalsList = new List<Interval>();
			for (int i = 0; i < array.Length - 1; i++)
			{
				intervalsList.Add(new Interval(array[i], array[i + 1]));
			}
			return intervalsList;
		}

		private Interval MergeIntervals(IList<Interval> intervals)
		{
			var sortedIntervals = new SortedSet<Interval>(intervals, new IntervalComparer());

			for (int i = 0; i < sortedIntervals.Count - 1; i++)
			{

				Interval current = sortedIntervals.ElementAt(i);
				Interval next = sortedIntervals.ElementAt(i + 1);

				// two intervals are overlapped
				if (next.start - current.end < 1)
				{
					// set current interval's end, and then remove next interval
					current.end = Math.Max(current.end, next.end);
					sortedIntervals.Remove(next);

					i--; // go back to old index, continue
				}
			}
			return sortedIntervals.First();
		}
	}
}
