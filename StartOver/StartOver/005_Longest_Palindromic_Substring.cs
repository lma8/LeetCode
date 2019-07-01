using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _5_Longest_Palindromic_Substring
    {
        public string Longest_Palindromic_Substring(string s) {
            int index = 0;
            string maxString = "";
            foreach (char c in s) {
                string temp= isPalindromic(c, index, s);
                if(temp.Length > maxString.Length)
                {
                    maxString = temp;
                }
                if ((s.Length - index) < maxString.Length) {
                    break;
                }
                Console.Write(index);
                index++;
            }

            return maxString;
        }
        public string isPalindromic(char c,int index, string s) {
            string substring = c.ToString();
            int start = 1;
            while (index - start >= 0 && (index +start)<= s.Length - 1)
            {
                if (s[index - start] == s[index + start])
                {
                    substring = s.Substring(index - start, start * 2 + 1);
                    start++;
                }
                else {
                    break;
                }
            }
            return substring;
        }
    }
}
