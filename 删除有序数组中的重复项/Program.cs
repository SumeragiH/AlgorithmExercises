namespace 删除有序数组中的重复项
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
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int slow = 0;
            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[slow] != nums[fast])
                {
                    //如果slow和fast指向的元素不相等，那么就将slow指向的元素的值更新为fast指向的元素的值，并将slow指针向右移动一位
                    slow++;
                    nums[slow] = nums[fast];
                }

            }
            return slow + 1;//返回数组中不重复元素的个数,因为slow指针是从0开始的，但是肯定有一个元素，所以返回slow+1
        }
    }
}
