using System.Collections.Generic;

namespace 无重复字符的最长子串
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
        //滑动窗口，时间复杂度O(n)，空间复杂度O(min(m,n))，m是字符集的大小，n是字符串的长度
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int right = 0;
            int result = 0;
            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;
                    result = Math.Max(result, right - left);
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }
            return result;
        }
    } 

}
