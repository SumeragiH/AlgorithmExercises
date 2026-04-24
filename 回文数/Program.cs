namespace 回文数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            return x.ToString() == new string(x.ToString().Reverse().ToArray());
        }
    }
}
