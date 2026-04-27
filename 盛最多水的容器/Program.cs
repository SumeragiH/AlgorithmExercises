namespace 盛最多水的容器
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
        //双指针，时间复杂度O(n)，空间复杂度O(1)
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxValue = Math.Min(height[left], height[right]) * (right - left);
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
                int currentValue = Math.Min(height[left], height[right]) * (right - left);
                maxValue = Math.Max(currentValue, maxValue);
            }
            return maxValue;
        }
    }
}
