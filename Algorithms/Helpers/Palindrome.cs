using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var numberReversed = ReverseInteger.Reverse(x);
            return x == numberReversed;
        }
    }
}
