namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
        int k = 3;

        Console.WriteLine($"Answer Is {LongestOnes(nums, k)}");
    }

    public static int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int right = 0;
        int res = 0;
        int ctr = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
                ctr++;

            while (ctr > k)
            {
                if (nums[left] == 0)
                    ctr--;

                left++;
            }

            right++;

            int tempRes = right - left;     
            
            if (tempRes > res)
                res = tempRes;
        }

        return res;
    }
}
