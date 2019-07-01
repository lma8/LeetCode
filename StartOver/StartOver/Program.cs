using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StartOver._2_Add_Two_Numbers;

namespace StartOver
{
    class Program
    {
        static void Main(string[] args)
        {

            _013_Roman_to_Integer test = new _013_Roman_to_Integer();
            Console.WriteLine(test.Roman_to_Integer("MCMXCIV"));
            Console.WriteLine(test.Roman_to_Integer("LVIII"));
            Console.WriteLine(test.Roman_to_Integer("IX"));

            Console.WriteLine(test.Roman_to_Integer("IV"));
            Console.WriteLine(test.Roman_to_Integer("III"));





            Console.Read();

        }
    }
}
