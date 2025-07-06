namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int k1 = 4;
        int[] nums1 = [1, 12, -5, -6, 50, 3];
        var sol1 = FindMaxAverage(nums1, k1);
        Console.WriteLine($"For Test Case 1 Answer Is {sol1}");

        int k2 = 1;
        int[] nums2 = [-1];
        var sol2 = FindMaxAverage(nums2, k2);
        Console.WriteLine(value: $"For Test Case 2 Answer Is {sol2}");

    }

    public static double FindMaxAverage(int[] nums, int k)
    {
        double res = double.MinValue;
        double sum = 0;

        int ctr = k;
        int leftPtr = 0;
        int rightPtr = 0;

        while(rightPtr < nums.Length)
        {
            if (ctr > 0)
            {
                sum += nums[rightPtr++];
                ctr--;
            }
            if (ctr == 0) 
            {
                double tempRes = sum / k;
                if (tempRes > res)
                    res = tempRes;

                sum -= nums[leftPtr++];
                ctr++;
            }
        }

        return res;
    }
}
