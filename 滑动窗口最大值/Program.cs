namespace 滑动窗口最大值
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
        //使用双端队列来维护当前窗口内的元素索引，保证队列头部始终是当前窗口的最大值索引
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0)
            {
                return new int[0];
            }
            int n = nums.Length;
            int[] result = new int[n - k + 1];
            // 使用双端队列存储窗口内元素的索引，队列头部始终是当前窗口的最大值索引
            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                // 移除窗口外的元素
                if (deque.Count > 0 && deque.First.Value < i - k + 1)
                {
                    deque.RemoveFirst();
                }
                // 移除比当前元素小的元素
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                // 添加当前元素索引
                deque.AddLast(i);
                // 当窗口大小达到k时，记录最大值
                if (i >= k - 1)
                {
                    result[i - k + 1] = nums[deque.First.Value];
                }
            }
            return result;
        }
    }
}
