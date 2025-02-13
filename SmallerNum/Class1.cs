using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNum
{
    public class smallnum
    {
        public string find_smallernum(string[] listofnum)
        {

            int num = int.Parse(listofnum[0]);
            int num2 = int.Parse(listofnum[1]);

            if (num < num2) { return num.ToString(); }
            else { return num2.ToString(); }



        }


    }
}