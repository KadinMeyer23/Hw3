using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class Findingminmax
    {

        public int[] FindingMinMax(int[] arrayofNums)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int i in arrayofNums)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }

            int[] minmax = { min, max };
            return minmax;
        }



    }
}
