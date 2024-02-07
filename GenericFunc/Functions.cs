using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc
{
    public class Functions
    {
        public static int FindLargest(List<int> listofint)
        {
            int tal = 0;
            foreach (int i in listofint)
            {
                if (i > tal)
                {
                    tal = i;
                }
            }
            return tal;
        }
    }
}
