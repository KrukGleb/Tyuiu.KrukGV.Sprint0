using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KrukGV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int SubstractionArray(int[] numbers)
        {
            var sum = 0;
            var i = 0;
            while (i < numbers.Length)
            {
                sum -= numbers[i];
                i++;
            }
            return sum;
        }

        public static int MultiplicationArray(int[] numbers)
        {
            var mult = 1;
            var i = 0;
            do
            {
                mult *= numbers[i];
                i++;
            }
            while (i < numbers.Length);
            return mult;
        }
    }
}
