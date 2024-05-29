using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static int pickingNumbers(List<int> a)
        {
            var mostRepated = -1;
            var maxRepate = 0;
            var count = 0;
            a.Sort();
            foreach (var item in a)
            {
                if (item == mostRepated)
                    continue;
                var c = a.FindAll(a => a == item).Count;
                var x_ = a.FindAll(a => a == item - 1).Count;
                var x = a.FindAll(a => a == item + 1).Count;
                var xc = x > x_ ? x : x_;
                var y_ = a.FindAll(a => a == mostRepated - 1).Count;
                var y = a.FindAll(a => a == mostRepated + 1).Count;
                var yc = y > y_ ? y : y_;

                if (yc + maxRepate < xc + c)
                {
                    mostRepated = item;
                    maxRepate = c;
                    count = xc + c;
                }
            }
            return count;
        }
    }
}
