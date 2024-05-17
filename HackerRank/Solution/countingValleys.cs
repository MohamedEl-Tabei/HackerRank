using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static int countingValleys(int steps, string path)
        {
            int direction = 0;
            int countValleys = 0;
            path.ToList().ForEach(step =>
            {
                direction = step == 'D' ? direction - 1 : direction + 1;
                if (direction == 0 && step == 'U')
                {
                    countValleys++;
                }
            });
            return countValleys;
        }
    }
}
