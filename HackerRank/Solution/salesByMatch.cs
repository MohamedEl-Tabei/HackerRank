using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
       public static int salesByMatch(int n, List<int> ar)
        {
            int numberOfPairs = 0;
            List<int> list = new List<int>();
            foreach (var i in ar) {
                if(list.Contains(i))
                {
                    continue;
                }
                numberOfPairs=numberOfPairs+(ar.FindAll(x=>x==i).Count()/2);
                list.Add(i);
            }
            return numberOfPairs;
        }
    }
}
