public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> complements = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        var complement = target - nums[i];
        if (complements.TryGetValue(complement, out var index))
            return [index, i];

        complements[nums[i]] = i;
    }
    return [];
    }
}
