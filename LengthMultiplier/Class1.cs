using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthMultiplier
{
    public class LengthMulti
    {

        public int[] lengthmultiplier(int[] Arrayofnums) {
            int[] NewArray = new int[Arrayofnums.Length];

            for(int i = 0; i<Arrayofnums.Length; i++) {
                NewArray[i] = Arrayofnums.Length * Arrayofnums[i];
            }
        
            return NewArray;
        }

    }
}
