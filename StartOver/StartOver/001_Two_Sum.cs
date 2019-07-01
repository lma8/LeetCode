using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _1_Two_Sum
    {
        public List<int> Two_Sum(List<int> list,int target) {
            foreach(int i in list){
                var index = list.FindIndex(x => x == (target - i));
                if (index != -1) {
                    return new List<int> { i, list[index] };
                }
            }
            return new List<int>() { 1,2,3,4,5};
        }
    }
}
