using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc
{
    public class Functions
    {
        public static int FindLargest(List<int> list)
        {
            int result = 0;
            foreach(int i in list)
            {
                if(i > result)
                    result = i;
            }
            return result;
        }
    }
}
