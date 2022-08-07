namespace LeetCodePb.BuySellStock
{
	internal class IntervalComparer : IComparer<Interval>
	{
		public int Compare(Interval x, Interval y)
		{
			if (x.start.Equals(y.start))
			{
				return x.end.CompareTo(y.end);
			}

			return x.start.CompareTo(y.start);
		}
	}
}
