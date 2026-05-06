namespace 找到字符串中所有字母异位词
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "cbaebabacd";
            string p = "abc";
            Solution solution = new Solution();
            IList<int> list = solution.FindAnagrams(s, p);

        }
    }

    public class Solution
    {
        //暴力解法(滑动窗口+排序)，时间复杂度O((n-m+1)*m*logm)，n是s的长度，m是p的长度
        public IList<int> FindAnagrams(string s, string p)
        {
            List<int> result = new List<int>();
            if (p.Length > s.Length)
            {
                return result;
            }
            char[] ps = p.ToCharArray();
            Array.Sort(ps);

            for (int left = 0; left < s.Length - p.Length + 1; left++)
            {
                string str = s.Substring(left, p.Length);
                char[] strs = str.ToCharArray();
                Array.Sort(strs);
                if (new string(strs) == new string(ps))
                {
                    result.Add(left);
                }
            }
            return result;
        }

        //滑动窗口+计数统计解法，时间复杂度O(n)，n是s的长度
        public IList<int> FindAnagrams2(string s, string p)
        {
            IList<int> result = new List<int>();
            if (p.Length > s.Length)
            {
                return result;
            }

            //统计个数的数组
            int[] pCount = new int[26];
            int[] sCount = new int[26];

            //初始化第一个窗口
            for (int i = 0; i < p.Length; i++)
            {
                pCount[p[i] - 'a']++;
                sCount[s[i] - 'a']++;
            }

            //比较第一个窗口
            if (Matches(pCount, sCount))
            {
                result.Add(0);
            }

            //滑动窗口
            for (int i = p.Length; i < s.Length; i++)
            {
                //加上右边的数值
                sCount[s[i] - 'a']++;
                //减去左边的数值
                sCount[s[i - p.Length] - 'a']--;

                if (Matches(pCount, sCount))
                {
                    result.Add(i - p.Length + 1);
                }
            }
            return result;

        }

        public bool Matches(int[] pCount, int[] sCount)
        {
            for (int i = 0; i < pCount.Length; i++)
            {
                if (pCount[i] != sCount[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
