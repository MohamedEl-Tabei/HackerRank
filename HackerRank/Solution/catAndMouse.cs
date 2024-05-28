using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static string catAndMouse(int x, int y, int z)
        {
            

            return Math.Abs(x - z)==Math.Abs(y - z) ? "Mouse C" : Math.Abs(x - z) > Math.Abs(y - z) ? "Cat B" : "Cat A";
        }

    }
}
