using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _3_Long_SubString_Without_Repeating_Characters
    {
        public int Long_SubString_Without_Repeating_Characters(string input) {
            List<string> result=new List<string>(){ };
            int maxLength = 0;

            foreach (var i in input) {
                if (result.Contains(i.ToString())) {
                    if ((result.Count) > maxLength) {
                        maxLength = result.Count;
                    }
                    result = new List<string>() { }; ;
                }
                result.Add(i.ToString());
            }


            return maxLength;
        }
    }
}
