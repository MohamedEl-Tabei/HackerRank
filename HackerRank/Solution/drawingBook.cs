using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static int drawingBook(int n, int page)
        {
            int min = 0;
            int p = 1;
            var book = new List<List<int>>();
            while (p <= n)
            {
                if (p % 2 == 0)
                {
                    book.Add([p, p + 1]);
                    p = p + 2;
                }
                else
                {
                    book.Add([p]);
                    p = p + 1;
                }
            }
            foreach (var item in book)
            {
                if (item.Contains(page)) break;
                min = min + 1;
            }
            book.Reverse();
            int min2 = 0;
            foreach (var item in book)
            {
                if (item.Contains(page)) break;
                min2 = min2 + 1;
            }
            return min < min2 ? min : min2;
        }
    }
}
