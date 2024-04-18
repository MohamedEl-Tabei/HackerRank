using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static int migratoryBirds(List<int> arr)
        {
            var dictionary = new Dictionary<int, int>();
            arr.Sort();
            foreach (var item in arr)
            {
                if ( dictionary.Keys.Contains(item))
                {
                    dictionary[item] = dictionary[item] + 1;
                }   
                else { dictionary.Add(item, 1); }
                
            }
            var numOfFreq = dictionary.Max(i => i.Value);
            return dictionary.FirstOrDefault(i=>i.Value==numOfFreq).Key;
        }

    }
}
