using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            List<int> newNums = nums.ToList();
            newNums.Remove(newNums.Min());
            return newNums.ToArray();
        }
    }
}
