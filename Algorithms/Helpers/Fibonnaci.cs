using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class Fibonnaci
    {
        static long[] fibCache = new long[200];
        public static long Run(int n)
        {
            if (n <= 1)
                fibCache[n] = 1;
            if (fibCache[n] == 0)
                fibCache[n] = Run(n - 1) + Run(n - 2);
            return fibCache[n];
        }
    }
}
