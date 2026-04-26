namespace 最长连续序列
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
        //哈希表，时间复杂度O(n)，空间复杂度O(n)
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                set.Add(num);
            }

            int result = 0;

            foreach (int i in set)
            {
                if (!set.Contains(i - 1))
                {
                    int currentNum = i;
                    int currentLength = 1;
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }
                    result = Math.Max(currentLength, result);
                }
            }

            return result;
        }
    }
}
