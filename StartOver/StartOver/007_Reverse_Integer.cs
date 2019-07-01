using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _7_Reverse_Integer
    {
        public int Reverse_Integer(int input) {
            bool isPositive = false;
            if (input >= 0) {
                isPositive = true;
            }
            Stack<char> s = new Stack<char>();
            foreach (char c in (System.Math.Abs(input)).ToString())
            {
                s.Push(c);
            }

            string result= "";
            while (s.Count > 0) {
                result += s.Pop().ToString();
            }
            

            return isPositive? int.Parse(result): 0- int.Parse(result);
        }
    }
}
