using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KrukGV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        {
            int[] resultArray = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; i++)
            {
                resultArray[i] = nums1[i] + nums2[i];
                
            }
            return resultArray;
        }
    }
}
