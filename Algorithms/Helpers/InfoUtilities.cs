using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class InfoUtilities
    {
        public static List<int[]> FindPairsOfNumbers(List<int> arr, int total)
        {
            var setsOfNumbers = new List<int[]>();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                var currentNumber = arr[i];
                for (int j = i + 1; j < arr.Count; j++)
                {
                    var nextNumber = arr[j];
                    if (currentNumber + nextNumber == total)
                        setsOfNumbers.Add(new int[2] { currentNumber, nextNumber });
                }
            }

            return setsOfNumbers;
        }

        public static List<List<int>> FindAllSumCombinations(List<int> arr, int total)
        {
            var setsOfNumbers = new List<List<int>>();



            return setsOfNumbers;
        }

        private void _subsetSum(List<int> numbers, int target, List<int> partial)
        {
            var s = partial.Aggregate(0, (a, b) => { return a + b; });

            if (s == target)
            {
                var lol = 0;
            }
        }
    }
}
