using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _8_String_to_Integer__atoi_
    {
        public int String_to_Integer__atoi(string str) {

            try {
                int a = Convert.ToInt32(str);
                return 0;
            }
            catch(Exception e){
                if (e is FormatException) {
                    List<char> l = str.ToList<char>();
                    int startInd, endInd;
                    startInd = l.FindIndex(x => Char.IsDigit(x));
                    Console.Write("startInd: " +startInd+" ");
                    if (startInd == -1)
                    {
                        return 0;
                    }
                    else
                    {
                        endInd = l.GetRange(startInd + 1, l.Count - startInd - 1).FindIndex(x => !Char.IsDigit(x));
                    }
                    Console.Write(" endInd: " +endInd + "  result  ");
                    string result = "";
                    foreach (char i in l.GetRange(startInd, endInd - startInd+1))
                    {
                        result += i.ToString();
                    }
                    return int.Parse(result);
                } else if (e is OverflowException) {
                    return 0;
                }              
                return 0;
            };



        }
    }
}
