using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Distinct values
            var arr = new List<int>() { 1, 1, 2, 2, 3, 4 };
            List<int> distinctValues = ArrayUtilities.GetDistinctValues(arr);

            var unsortedArray = new List<int> { 3, 2, 6, 4, 7, 1 };
            var sortedArray = ArrayUtilities.SortAscending(unsortedArray);

            var decimalUnsortedArray = new List<decimal>() { 0.897M, 0.565M, 0.656M, 0.1234M, 0.665M, 0.3434M };
            var decimalSortedArray = ArrayUtilities.BucketSort(decimalUnsortedArray);
        }
    }
}
