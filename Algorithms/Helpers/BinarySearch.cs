using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class BinarySearch
    {
        public static int? Search(List<int> haystack, int needle, int min, int max)
        {
            var midpoint = (max + min) / 2;
            if (haystack.Count > 0 && haystack[midpoint] == needle)
            {
                return midpoint;
            }

            if (min >= max)
            {
                return null;
            }

            if (haystack[midpoint] > needle)
                return Search(haystack, needle, min, midpoint - 1);
            return Search(haystack, needle, midpoint + 1, max);
        }
    }
}
