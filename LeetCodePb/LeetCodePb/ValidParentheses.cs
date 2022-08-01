using System.Text.RegularExpressions;

namespace LeetCodePb
{
	internal class ValidParentheses
	{
		internal void PrintValidParenthesesSolution()
		{
			Console.WriteLine("---------- ValidParentheses ------------\n");
			var s = "()";
			Console.WriteLine($"Example 1 is {IsValid(s)}");

			var s2 = "()[]{}";
			Console.WriteLine($"Example 2 is {IsValid(s2)}");

			var s3 = "(]";
			Console.WriteLine($"Example 3 is {IsValid(s3)}");

		}
		private bool IsValid(string s)
		{
			Regex rgx = new(@"(\(*\)*\[*\]*\{*\}*)");
			if (!rgx.IsMatch(s)) return false;
			var parenthesesStack = new Stack<char>();
			parenthesesStack.Push(s[0]);
			for (int i = 1; i < s.Length; i++)
			{
				char onTopELement;
				parenthesesStack.TryPeek(out onTopELement);
				if (onTopELement != new char() && isPair(parenthesesStack.Peek(), s[i]))
				{
					parenthesesStack.Pop();
				}
				else
				{
					parenthesesStack.Push(s[i]);
				}
			}

			if (parenthesesStack.Count == 0) return true;
			return false;
		}
		private bool isPair(char x, char y)
		{
			if (x == '(' && y == ')') return true;
			if (x == '[' && y == ']') return true;
			if (x == '{' && y == '}') return true;
			return false;

		}
	}
}
