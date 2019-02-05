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

        public static int[] TwoSum(int[] nums, int target)
        {
            // Brute force approach
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    var firstNumber = nums[i];
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        var secondNumber = nums[j];
            //        if (firstNumber + secondNumber == target)
            //        {
            //            int[] indices = { i, j };
            //            return indices;
            //        }
            //    }
            //}
            // Hash table approach
            var numbersMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numbersMap.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                
                if(numbersMap.ContainsKey(complement) && numbersMap[complement] != i)
                {
                    return new int[] { i, numbersMap[complement] };
                }
            }
            throw new ArgumentException("Please provide an array and a target to complete the calculation");
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
