using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        public static string dayOfProgrammer(int year)
        {
            var date = (new DateTime(year, 1, 1)).AddDays(255);
            if (date.Year == 1918) return date.AddDays(13).ToString("dd.MM.yyyy");
            if ((year <= 1917 && year >= 1700) && year % 4 == 0) return date.ToString("12.MM.yyyy");
            return date.ToString("dd.MM.yyyy");

        }
    }
}
