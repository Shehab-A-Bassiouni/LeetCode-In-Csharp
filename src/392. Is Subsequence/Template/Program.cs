namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc", t1 = "ahbgdc";
            var result1 = IsSubsequence(s1, t1);
            Console.WriteLine($"Is '{s1}' a subsequence of '{t1}'? {result1}");

            string s2 = "axc", t2 = "ahbgdc";
            var result2 = IsSubsequence(s2, t2);
            Console.WriteLine($"Is '{s2}' a subsequence of '{t2}'? {result2}");
        }

        static bool IsSubsequence(string s, string t)
        {
            // Solve Here
            return false; // replace with the actual logic
        }
    }
}
