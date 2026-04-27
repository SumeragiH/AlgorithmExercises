namespace 移动零
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
        public void MoveZeroes(int[] nums)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)//说明找到了下一个要交换的元素
                {
                    int temp = nums[slow];
                    nums[slow] = nums[fast];
                    nums[fast] = temp;
                    slow++;//移动边界
                }

            }
        }
    }   
}
