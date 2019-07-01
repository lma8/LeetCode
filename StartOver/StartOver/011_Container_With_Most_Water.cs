using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _11_Container_With_Most_Water
    {
        //public int MaxArea(int[] height)
        //{
        //    int length = height.Length;
        //    int maxArea=0;
        //    int ind;
        //    for (int i = 0; i < length; i++)
        //    {
        //        ind = longestlargerindex(height, height[i], i);
        //        Console.WriteLine("i :" + i + " ind : " + ind + " maxArea " + height[i] * ind);
        //        if (height[i] * ind > maxArea) {
        //            maxArea = height[i] * ind;
        //        }
        //    }
        //    return maxArea;
        //}

        //public int longestlargerindex(int[] source, int comparer,int comparerindex)
        //{
        //    List<int> result = new List<int>(); ;
        //    int maxLength = 0;
        //    int maxind = 0;
        //    int max = 0;
        //    int startind = 0;
        //    foreach (int i in source) {
        //        if (i >= comparer) {
        //            if (Math.Abs(comparerindex - i+1) >max || (Math.Abs(comparerindex - i + 1) ==max && source[startind]>source[maxind]))
        //            {
        //                maxind = startind;
        //                max = Math.Abs(comparerindex - i+1);
        //            }
        //        }
        //        startind++;
        //    }
        //    return maxind;

        //}
        public int MaxArea(int[] height) {
            int maxArea = 0;
            int shortboard;
            for (int i = 0; i < height.Length; i++) {
                for (int j = i+1; j < height.Length; j++)
                {
                    shortboard = height[i] > height[j] ? height[j] : height[i];
                    Console.WriteLine("distance" + (j - i + 1) + " shortboard " + " maxArea " + maxArea);
                    if (shortboard * (j - i) > maxArea) {
                        maxArea = shortboard * (j - i);
                    }
                }
            }
            return maxArea;
        }
    }
}
