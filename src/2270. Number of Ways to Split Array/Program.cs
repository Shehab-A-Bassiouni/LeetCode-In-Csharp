namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = [10, 4, -8, 7];
        int output1 = WaysToSplitArray(nums1);

        Console.WriteLine($"The result of first test is {output1}");

        int[] nums2 = [6, -1, 9];
        int output2 = WaysToSplitArray(nums2);
        Console.WriteLine($"The result of second test is {output2}");
    }

    public static int WaysToSplitArray(int[] nums)
    {
        var result = 0;
        var length = nums.Length;
        int[] numsSums = new int[length];
        numsSums[0] = nums[0];

        for (int i = 1; i < length; i++)
            numsSums [i] = nums [i] + nums[i - 1];

        for (int i = 0; i < length - 1; i++)
        { 
            if ((numsSums[i+1] >= numsSums[length - i-1]))
                result++;
        }
        return result;    
    }
}
