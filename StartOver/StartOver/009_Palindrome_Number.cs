using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            bool result = true;
            if (Math.Abs(x) != x) { return false; }
            else {
                int length = x.ToString().Length;
                int startind = 0;
                while (startind < length/2)
                {
                    if (x.ToString()[startind] == x.ToString()[length - startind-1])
                    {
                        startind++;
                    }
                    else {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
