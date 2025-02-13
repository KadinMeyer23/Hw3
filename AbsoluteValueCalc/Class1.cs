using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValueCalc
{
    public class AbsCalc
    {

        public int Find_AbsCalc(int[] arrayofnums) {

            int total = 0;
            foreach (int i in arrayofnums) {
                if (i > 0) { total += i; }
                else if (i < 0) {
                    int j = i * -1;
                    total += j;
                }
            
            
            
            
            }


            return total;
        }


    }
}
