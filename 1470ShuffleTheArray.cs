public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        /* 
        * Given the array nums consisting of 2n elements in the form [x1, x2...,xn, y1, y2....yn]
        * Return the array in the form [x1, y1, x2, y2, .... xn, yn]
        * Create a new array
        * n is the limiter. All values up to 0 to n are X and values from n to array.Length are y
        * Loop through the list, and insert x at 0 and y and n + 1 and loop through while i is less than n
        * If i is even insert an X else insert a Y.
        */
        int j = 0;
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = nums[j];
                j++;
            }
            else
            {
                result[i] = nums[n];
                n++;
            }
        }
        return result;
    }
}