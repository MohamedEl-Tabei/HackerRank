using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solution
{
    internal partial class Solution
    {
        static int costOfConvertion(List<List<int>> from_, List<List<int>> to_)
        {
            int cost = 0;
            for (int i = 0; i < from_.Count; i++)
            {
                for (int j = 0; j < from_.Count; j++)
                {
                    if (from_[i][j] != to_[i][j])
                    {
                        double newCost = Math.Abs(Convert.ToDouble(from_[i][j] - to_[i][j]));
                        cost = cost + Convert.ToInt32(newCost);
                    }
                }
            }
            return cost;
        }
        public static int formingMagicSquare(List<List<int>> s)
        {
            var possibleMs = new Dictionary<int, List<List<int>>>()
            {
                [0] = new List<List<int>>
                {

                    new List<int> {6,1,8},
                    new List<int> {7,5,3},
                    new List<int> {2,9,4},
                },
                [1] = new List<List<int>>
                {

                    new List<int> {2,7,6},
                    new List<int> {9,5,1},
                    new List<int> {4,3,8},
                },
                [2] = new List<List<int>>
                {

                    new List<int> {4,9,2},
                    new List<int> {3,5,7},
                    new List<int> {8,1,6},
                },
                [3] = new List<List<int>>
                {

                    new List<int> {8,3,4},
                    new List<int> {1,5,9},
                    new List<int> {6,7,2},
                },
                [4] = new List<List<int>>
                {

                    new List<int> {2,9,4},
                    new List<int> {7,5,3},
                    new List<int> {6,1,8},
                },
                [5] = new List<List<int>>
                {

                    new List<int> {6,7,2},
                    new List<int> {1,5,9},
                    new List<int> {8,3,4},
                },
                [6] = new List<List<int>>
                {

                    new List<int> {8,1,6},
                    new List<int> {3,5,7},
                    new List<int> {4,9,2},
                },
                [7] = new List<List<int>>
                {

                    new List<int> {4,3,8},
                    new List<int> {9,5,1},
                    new List<int> {2,7,6},
                },

            };
            int min = costOfConvertion(s, possibleMs[0]);
            int count = 1;
            do
            {
                int cost = costOfConvertion(s, possibleMs[count]);
                min = cost < min ? cost : min;
                count = count + 1;
            } while (count <= 7);
            return min;
        }
    }
}
