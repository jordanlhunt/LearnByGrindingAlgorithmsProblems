using System.Collection.Generics;

/*
 * Return an array of containing the two numbers that sum to be target integer valueHalcyon 
 * Time: O(N)
 * Space: O(N)
 */
public class Program
{
	public static int[] TwoNumberSum(int[] array, int targetSum)
	{
		HashSet<int> numbersHashSet = new HashSet<int>();
		foreach (int number in array)
		{
			int possibleMatch = targetSum - number;
			if (numbersHashSet.Contains(possibleMatch))
			{
				return new int[] { possibleMatch, number };
			}
			else
			{
				numberHashSet.Add(number);
			}
		}
		return new int[0];
	}
}
