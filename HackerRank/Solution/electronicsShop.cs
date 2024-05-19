using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static int electronicsShop(int[] keyboards, int[] drives, int b)
        {
            int maxCost = -1;
            foreach (var k in keyboards)
            {
                foreach (var d in drives)
                {
                    maxCost = d + k > maxCost && d + k <= b ? d + k : maxCost;
                }
            }
            return maxCost;
        }
    }
}
