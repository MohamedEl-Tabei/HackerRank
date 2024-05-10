using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static void billDivision(List<int> bill, int k, int b)
        {
            int sum = 0;
            foreach (int i in bill)
            {
                sum += i;
            }
            int annPay = (sum - bill[k]) / 2;
            if(b<=annPay)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b-annPay);
            }
        }
    }
}
