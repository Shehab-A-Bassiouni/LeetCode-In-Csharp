namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] example1 = ['h', 'e', 'l', 'l', 'o'];
            char[] input1 = ['h', 'e', 'l', 'l', 'o'];
            char[] target1 = ['o', 'l', 'l', 'e',  'h'];
            ReverseString(input1);
            Console.WriteLine($"Is {string.Join(',', input1)}  valid reverse of {string.Join(',', example1)} ? {input1.SequenceEqual(target1)}");

            char[] example2 = ['H', 'a', 'n', 'n', 'a', 'h'];
            char[] input2 = ['H', 'a', 'n', 'n', 'a', 'h'];
            char[] target2 = ['h', 'a', 'n', 'n', 'a', 'H'];
            ReverseString(input2);
            Console.WriteLine($"Is {string.Join(',', input2)}  valid reverse of {string.Join(',', example2)} ? {input2.SequenceEqual(target2)}");

        }

        static void ReverseString(char[] s)
        {
            int r = s.Length - 1;
            int l = 0;

            while (l < r)
            { 
                var temp = s[r];
                s[r] = s[l];
                s[l] = temp;
                l++;
                r--;
            }
        }
    }
}
