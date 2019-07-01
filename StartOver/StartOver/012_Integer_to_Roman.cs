using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _12_Integer_to_Roman
    {
        public string IntToRoman(int num)
        {
            int thousandNumber = num / 1000;
            int hundredNumber = num / 100 - thousandNumber * 10;
            int tyNumber = num / 10 - thousandNumber * 100 - hundredNumber * 10;
            int integer = num - thousandNumber * 1000 - hundredNumber * 100 - tyNumber*10;
            
            int number, level;
            string s = "";
            List<int> l = new List<int>();
            l.Add(thousandNumber);
            l.Add(hundredNumber);
            l.Add(tyNumber);
            l.Add(integer);
            for (int i = 0; i < l.Count; i++)
            {
                s += getLetter(l[i], 3- i);
            }
            return s;
        }
        public string getLetter(int number, int level)
        {
            string result = "";
            if (number == 0) {
                result = "";
            }
            else if (number <= 3)
            {
                while (number > 0)
                {
                    result += "a";
                    number--;
                }
            }
            else if (number == 4 )
            {
                result = ("a" + "b");
            }
            else if (number == 5)
            {
                result = "b";
            }
            else if (number > 5 && number < 9)
            {
                result = "b";
                while ((number - 5) > 0)
                {
                    result += "a";
                    number--;
                }
            }
            else if (number == 9)
            {
                result = ("a" + "c");
            }
            else
            {
                result = "c";
            }

            switch(level){
                case (3):
                    result= result.Replace('a', 'M');
                    break;
                case (2):
                    result = result.Replace('a', 'C').Replace('b','D').Replace('c','M');
                    break;
                case (1):
                    result = result.Replace('a', 'X').Replace('b', 'L').Replace('c', 'C');
                    break;
                case (0):
                    result = result.Replace('a', 'I').Replace('b', 'V').Replace('c', 'X');
                    break;
            }
            Console.WriteLine("level : " + level + " result " + result);


            return result;
        }
    }
}
