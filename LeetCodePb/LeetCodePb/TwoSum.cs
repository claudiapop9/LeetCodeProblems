namespace LeetCodePb
{
	internal class TwoSum
	{
		internal void PrintTwoSumSolution()
		{
			Console.WriteLine("---------- Two Sum ------------\n");
			var nums = new[] { 2, 7, 11, 15 };
			var target = 9;
			var solution = TwoSumSolution(nums, target);
			Console.WriteLine("example 1:[" + solution[0] + "," + solution[1] + "]");

			var nums2 = new[] { 3, 2, 4 };
			var target2 = 6;
			int[]? solution2 = TwoSumSolution(nums2, target2);
			Console.WriteLine("example 2:[" + solution2[0] + "," + solution2[1] + "]");

			var nums3 = new[] { 3, 3 };
			var target3 = 6;
			int[]? solution3 = TwoSumSolution(nums3, target3);
			Console.WriteLine("example 3:[" + solution3[0] + "," + solution3[1] + "]");

			var nums4 = new[] { 2, 5, 5, 11 };
			var target4 = 10;
			int[]? solution4 = TwoSumSolution(nums4, target4);
			Console.WriteLine("example 4:[" + solution4[0] + "," + solution4[1] + "]");

		}

		private int[] TwoSumSolution(int[] nums, int target)
		{
			if (nums.Length < 2 || nums.Length > 10000) return Array.Empty<int>();
			for (int i = 0; i < nums.Length - 1; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new[] { i, j };
					}
				}
			}
			return Array.Empty<int>();
		}
	}
}

