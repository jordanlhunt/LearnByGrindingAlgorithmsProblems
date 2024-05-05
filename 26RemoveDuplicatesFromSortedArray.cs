public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int uniqueElements = 0;
        /*
        * Loop through the array and check if index i and index i+1 are equal. 
        * If index i == index i + 1 continue through the loop 
        * Replace the element at i with uniqueElements and then increment uniqueElements
        */

        for (int i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                continue;
            }
            nums[uniqueElements] = nums[i];
            uniqueElements++;
        }
        return uniqueElements;
    }
}