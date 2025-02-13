using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Ds
{
    public class DCounter
    {

        public int Counting_Ds(string sentence) {

            int count = 0;
            foreach (var i in sentence) {
                if (i == 'd') { count++; }
            }

            return count;
        }




    }
}
