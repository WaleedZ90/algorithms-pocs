using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ArrayUtilities
    {
        // Reference: https://www.geeksforgeeks.org/print-distinct-elements-given-integer-array/
        public static List<int> GetDistinctValues(List<int> arr)
        {
            var distinctValues = new List<int>();

            //int i;

            //// Traverse the sorted array 
            //for (i = 0; i < arr.Count; i++)
            //{
            //    // Move the index ahead while  
            //    // there are duplicates 
            //    while (i < arr.Count - 1 && arr[i] == arr[i + 1])
            //        i++;

            //    // add last occurrence of  
            //    // the current element 
            //    distinctValues.Add(arr[i]);
            //}

            var set = new HashSet<int>();
            foreach (int number in arr)
            {
                if (!set.Contains(number))
                {
                    set.Add(number);
                    distinctValues.Add(number);
                }
            }

            return distinctValues;
        }
        public static List<int> SortAscending(List<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    var min = arr[min_index];
                    var current = arr[j];
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }

                    int tempValue = arr[min_index];
                    arr[min_index] = arr[i];
                    arr[i] = tempValue;
                }
            }
            return arr;
        }

        public static List<decimal> BucketSort(List<decimal> arr)
        {
            var bucketsDictionary = new Dictionary<int, List<decimal>>();
            for (int i = 0; i < arr.Count; i++)
            {
                bucketsDictionary.Add(i, new List<decimal>());
            }

            for (int i = 0; i < arr.Count; i++)
            {
                var bucketNumber = _getBucketNumber(arr[i]);
                bucketsDictionary[bucketNumber].Add(arr[i]);
            }

            return arr;
        }

        #region Helpers
        private static int _getBucketNumber(decimal value)
        {
            var result = value - Math.Truncate(value);
            return (int)Math.Floor(result * 10);
        }
        #endregion
    }


}
