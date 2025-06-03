namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = [2, 7, 11, 15];
            int target1 = 9;
            var solution1 = TwoSum(input1, target1);
            Console.WriteLine($"Input: {string.Join(", ", input1)}, Target: {target1}, Output: {string.Join(", ", solution1)}");

            int[] input2 = [2, 3, 4];
            int target2 = 6;
            var solution2 = TwoSum(input2, target2);
            Console.WriteLine($"Input: {string.Join(", ", input2)}, Target: {target2}, Output: {string.Join(", ", solution2)}");

            int[] input3 = [-1, 0];
            int target3 = -1;
            var solution3 = TwoSum(input3, target3);
            Console.WriteLine($"Input: {string.Join(", ", input3)}, Target: {target3}, Output: {string.Join(", ", solution3)}");
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            // Solve here
            return []; // replace with the actual logic
        }
    }
}
