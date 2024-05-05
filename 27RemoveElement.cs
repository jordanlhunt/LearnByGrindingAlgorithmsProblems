public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {

        int j = 0;
        /*
        * Loop through the input array
        * If the value at index i == val
        *   contiune
        * If value at index i does not equal val
        *   insert it at the position of i
        *  Return the number of value in the new updated array.
        *
        */
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            else
            {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}