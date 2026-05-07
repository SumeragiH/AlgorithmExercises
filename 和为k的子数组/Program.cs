namespace 和为k的子数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1};
            int k = 1;
            Solution solution = new Solution();
            int count = solution.SubarraySum(nums, k);
            Console.WriteLine(count);
        }
    }
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int pre = 0;
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1; // 初始化前缀和为0的情况
            //首先求解前缀和
            for (int i = 0; i < nums.Length; i++)
            {
                pre += nums[i];
                //再通过哈希表来查找
                if (map.ContainsKey(pre - k))//如果存在pre[i-1]
                {
                    count += map[pre - k];
                }

                //更新哈希表
                if (map.ContainsKey(pre))
                { 
                    map[pre]++;
                }
                else//如果没有
                {
                    map.Add(pre, 1);
                }
            }
            return count;

        }
    }
}
