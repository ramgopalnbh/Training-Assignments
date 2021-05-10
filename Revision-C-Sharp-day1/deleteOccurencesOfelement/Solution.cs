using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteOccurencesOfelement
{
    public class Solution
    {
        public static int[] DeleteNthElement(int[] arr, int x)
        {
            Dictionary<int, int> itemCount = new Dictionary<int, int>();
            return arr.Where((val, idx) =>
            {
                if (itemCount.ContainsKey(val))
                {
                    itemCount[val]++;
                }
                else
                {
                    itemCount.Add(val, 1);
                }
                return itemCount[val] <= x;
            }).ToArray();
        }
    }
}
