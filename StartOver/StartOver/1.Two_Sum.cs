using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5/30/2019
namespace StartOver
{
    class Two_Sum
    {
        public List<int> twoSum(List<int> input, int target) {
            List<int> result = new List<int>();
            foreach (var ele in input) {
                if(input.FindIndex(x => x == (target - ele)) != -1)
                {
                    result.Add(ele);
                    result.Add(target - ele);
                    break;
                };
            }
            return result;
        }
    }
}
