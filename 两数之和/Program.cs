namespace 两数之和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;
            Solution solution = new Solution();
            int[] result = solution.TwoSum2(nums, target);
            Console.WriteLine(string.Join(", ", result));
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result;
            for (int slow = 0; slow < nums.Length; slow++)
            {
                for (int fast = slow + 1; fast < nums.Length; fast++)
                {
                    if (nums[slow] + nums[fast] == target)
                    {
                         result = new int[] { slow, fast };
                        return result;
                    }
                   
                }
            } 
            result = new int[] { -1, -1 };
            return result;
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int need = target - nums[i];
                if (dict.ContainsKey(need))
                {
                    return new int[] { dict[need], i };
                }
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
