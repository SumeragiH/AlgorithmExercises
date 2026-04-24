namespace 找出字符串中第一个匹配项的下标
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
        //暴力解法，时间复杂度为O((n-m)*m)，空间复杂度为O(1)，m是needle的长度，n是haystack的长度,不考虑剪枝则是O(n*m)
        public int StrStr(string haystack, string needle)
        {
            if (needle == "")
                return 0;
            if(haystack.Length < needle.Length)
                return -1;  
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j;
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                }
                if (j == needle.Length)
                    return i;
            }
            return -1;
        }

        //KMP算法，时间复杂度为O(n+m)，空间复杂度为O(m)，m是needle的长度，n是haystack的长度
         public int StrStr2(string haystack, string needle)
         {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            if (needle == "")
            {
                return 0;
            }

            int[] next = GetNext(needle);

            int j = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                while (j > 0 && needle[j] != haystack[i])
                {
                    j = next[j - 1];
                }
                if (needle[j] == haystack[i])
                {
                    j++;
                }
                if (j == needle.Length)
                {
                    return i - j + 1;
                }
            }
            return -1;
        }

        //得到next数组
        //其中i用来给next每一个空位赋值，因为i遍历next
        //其中j用来统计前缀表的值。当相同的时候，累积，这里可以得到前缀的长度。不同的时候，向前回溯，回溯到相同的时候，这里可以得到后缀的长度。
        //这样以来，就可以得到最长相等前后缀的长度
        public int[] GetNext(string needle)
        {
            int[] next = new int[needle.Length];//创建一个和needle长度相同next数组
            next[0] = 0;//第一个位置的值为0，因为没有前缀和后缀
            int j = 0;
            for (int i = 1; i < needle.Length; i++)//从第二个位置开始遍历needle，i和j要分开
            {
                while (j > 0 && needle[j] != needle[i])//不匹配的情况
                {
                    j = next[j - 1];//向前回退，直到j==0或者needle[j]==needle[i]
                }
                if (needle[j] == needle[i])
                {
                    j++;
                }
                next[i] = j;

            }
            return next;
        }
    }
}
