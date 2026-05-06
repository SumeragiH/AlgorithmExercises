namespace 接雨水
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
        //双指针优化前，时间复杂度O(n^2)，空间复杂度O(1)
        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int volume = 0;
            int waterHeight = 0;
            while (left < right)
            {
                waterHeight = Math.Min(height[left], height[right]);
                for (int p = left + 1; p < right; p++)
                {
                    if (height[p] < waterHeight)
                    {
                        volume += waterHeight - height[p];
                        height[p] = waterHeight;
                    }
                }
                while (left < right && height[left] <= waterHeight)
                    left++;
                while (left < right && height[right] <= waterHeight)
                    right--;

            }
            return volume;
        }
        //双指针优化后，时间复杂度O(n)，空间复杂度O(1)
        public int Trap2(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int volume = 0;
            int rightHeight = 0;
            int leftHeight = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > leftHeight)
                    {
                        leftHeight = height[left];
                    }
                    else
                    {
                        volume += leftHeight - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] > rightHeight)
                    {
                        rightHeight = height[right];
                    }
                    else
                    {
                        volume += rightHeight - height[right];
                    }
                    right--;
                }
            }
            return volume;
        }
    }
}
