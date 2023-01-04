public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement))
            {
                return new int[] { dic[complement], i };
            }
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] ans = TwoSum(nums, target);
        foreach (var item in ans)
        {
            Console.WriteLine(item.ToString());
        }
        Console.ReadLine();
    }
}