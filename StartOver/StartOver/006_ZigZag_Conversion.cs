using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _6_ZigZag_Conversion
    {
        public string ZigZag_Conversion(string s, int numRows) {
            string result = "";
            int groupNumber;
            int index =0;
            groupNumber = (int)Math.Ceiling((double)(s.Length/(numRows*2-2)));

            Queue<string> q = new Queue<string>();
            foreach (char c in s) {
                q.Enqueue(c.ToString());
            }

            string[,] m = new string[numRows,(numRows*2 -1 )*groupNumber];
            
            


            return result;
        }
    }
}
