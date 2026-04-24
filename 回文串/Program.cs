namespace 回文串
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string s = "A man, a plan, a canal: Panama";
            Solution solution = new Solution();
            bool result = solution.IsPalindrome(s);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }
            char p1;
            char p2;
            for (int left = 0, right = s.Length - 1; left < right; left++, right--)
            {
                p1 = s[left];
                p2 = s[right];
                while (left < right && ((s[left] < 97 || s[left] > 122) && (s[left] < 65 || s[left] > 90) && (s[left] < 48 || s[left] > 57)))//跳过非字母的字符
                {
                    left++;
                    p1 = s[left];
                }
                while (left<right && ((s[right] < 97 || s[right] > 122) && (s[right] < 65 || s[right] > 90) && (s[right] < 48 || s[right] > 57)))//跳过非字母的字符
                {
                    right--;
                    p2 = s[right];
                }

                //统一转成小写字母进行比较
                if (s[left] < 97)//如果是大写字母
                {
                    p1 = (char)(s[left] + 32);//将大写字母转换为小写字母
                }
                if (s[right] < 97)//如果是大写字母
                {
                    p2 = (char)(s[right] + 32);//变成小写字母
                }


                if (p1 != p2||right<left)//说明不是回文
                {
                    return false;
                }
            }
            return true;
        }
    }
}
