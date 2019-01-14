using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class Fibonnaci
    {
        public static int Counter { get; set; }
        public static int Run(int n)
        {
            Counter++;
            if (n <= 1)
                return 1;
            var result = Run(n - 1) + Run(n - 2);
            return result;
        }
    }
}
