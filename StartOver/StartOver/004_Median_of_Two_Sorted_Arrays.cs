using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _4_Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 =(nums1.Concat(nums2).ToArray());
            Array.Sort(nums3);
            foreach (var i in nums1) {
                Console.Write(i + " ");
                Console.WriteLine();
            }
            return nums3.Length % 2 == 0 ? getEvenIndexMedian(nums3) : getOddIndexMedian(nums3);
        }
        public double getOddIndexMedian(int[] oddArray) {
            Console.WriteLine("odd " + (double)oddArray[(int)(oddArray.Length - 1) / 2]);
            return (double)oddArray[(int)(oddArray.Length-1)/2];

        }
        public double getEvenIndexMedian(int[] evenArray)
        {
            Console.WriteLine("odd " + (double)(evenArray[(int)(evenArray.Length / 2)] + evenArray[(int)(evenArray.Length / 2) - 1])/2);
            return (double)(evenArray[(int)(evenArray.Length/ 2)]+ evenArray[(int)(evenArray.Length / 2)-1])/2;
        }

    }
}
