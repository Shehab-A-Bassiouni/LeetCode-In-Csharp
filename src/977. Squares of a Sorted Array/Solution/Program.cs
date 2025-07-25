﻿namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { -4, -1, 0, 3, 10 };
            int[] expected1 = { 0, 1, 9, 16, 100 };
            int[] result1 = SortedSquares(input1);
            Console.WriteLine($"Result {string.Join(',', result1)} is {result1.SequenceEqual(expected1)}");


            int[] input2 = { -7, -3, 2, 3, 11 };
            int[] expected2 = [4, 9, 9, 49, 121];
            int[] result2 = SortedSquares(input2);
            Console.WriteLine($"Result {string.Join(',', result2)} is {result2.SequenceEqual(expected2)}");

        }

        static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];

            int right = nums.Length - 1;
            int left = 0;
            int current = nums.Length - 1;

            while (current >= 0)
            {
                var leftArrAbs = int.Abs(nums[left]);
                var rightArrAbs = int.Abs(nums[right]);

                if (leftArrAbs > rightArrAbs)
                {
                    result[current] = leftArrAbs * leftArrAbs;
                    left++;
                    current--;
                }

                else if (leftArrAbs < rightArrAbs)
                {
                    result[current] = rightArrAbs * rightArrAbs;
                    right--;
                    current--;
                }

                else if (leftArrAbs == rightArrAbs && left != right)
                {
                    result[current] = leftArrAbs * leftArrAbs;
                    current--;
                    result[current] = rightArrAbs * rightArrAbs;
                    left++;
                    right--;
                    current--;
                }

                else
                {
                    result[current] = leftArrAbs * leftArrAbs;
                    current--;
                }
            }

            return result;
        }
    }
}
