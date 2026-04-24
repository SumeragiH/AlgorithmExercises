namespace 移除元素
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
        //双指针法，时间复杂度为O(n)，空间复杂度为O(1)，n是数组的长度
        public int RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }
            return slow;//返回数组中不等于val的元素的个数
        }
    }
}
