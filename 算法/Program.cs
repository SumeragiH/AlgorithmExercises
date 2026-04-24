namespace 算法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "MCMXCIV";
            Solution solution = new Solution();
            int result = solution.RomanToInt(s);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            s = s + "E";//在字符串的末尾添加一个字符，防止越界，作为结束标志
            //第一步，将字符串变成字节数组
            char[] str = s.ToCharArray();
            //第二步。将前后两个字符的值比较
            int index = 0;
            int result = 0;
            while (index < str.Length-1)
            {
                char front = str[index];
                char back = str[index + 1];

                if(CharToInt(front) < CharToInt(back))//如果前面一个字符小于后面一个字符，那么就减去前面的字符的值
                {
                    result -= CharToInt(front);
                }
                else//否则就加上前面的字符的值
                {
                    result += CharToInt(front);
                }
                index++;
            }
            return result;
        }

        public int CharToInt(char c)
        {
            switch(c)
            {
            case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
                }
            }
        }
    }
