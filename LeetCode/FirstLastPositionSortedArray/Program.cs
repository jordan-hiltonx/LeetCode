// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/

using System.Diagnostics;

var sw = new Stopwatch();
List<int> res = new List<int>();
int[] SearchRange(int[] nums, int target)
{ 
    sw.Start();
    if (!nums.Contains(target))
    {
        res.Add(-1);
        res.Add(-1);
    }
    foreach (var num in nums)
    {
        if (num == target)
        {
            var first = Array.IndexOf(nums, target);
            var last = Array.LastIndexOf(nums, target);
            res.Add(first);
            res.Add(last);
            break;
        }
    }
    
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
    foreach (var num in res)
    {
        Console.WriteLine(num);
    }
    return res.ToArray();
}

SearchRange([5,7,7,8,8,10], 6);
