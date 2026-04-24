namespace 合并两个有序数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;
            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            Console.WriteLine(string.Join(", ", nums1));
        }
    }
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1 == null || nums2 == null) return;
            int slow = 0;
            for (int fast = 0; fast < m+n; fast++)
            {
                if (nums2[slow] < nums1[fast] || fast > m)
                {
                    for (int i = m + n - 1; i > fast; i--)
                    {
                        nums1[i] = nums1[i - 1];
                    }
                    nums1[fast] = nums2[slow];
                    slow++;
                }
            }
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            //三指针
            int p1 = m - 1; //指向nums1的最后一个有效元素
            int p2 = n - 1; //指向nums2的最后一个有效元素
            int p = m + n - 1;  //指向nums1的最后一个位置

            //从后往前比较，当两个指针还有数字时
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])//如果nums1的元素大于nums2的元素，那么就将nums1的元素放到nums1的最后一个位置
                {
                    nums1[p] = nums1[p1];
                    p1--;
                    p--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                    p--;
                }
            }
            //如果nums2还有剩余的元素，那么就将nums2的元素放到nums1的前面
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p2--;
                p--;
            }
        }
    }
}
