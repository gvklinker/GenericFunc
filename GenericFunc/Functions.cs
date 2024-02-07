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
        public static T FindLargest<T>(List<T> listOfTypes) where T : IComparable<T>
        {
            T? type = listOfTypes.FirstOrDefault();
            foreach (T t in listOfTypes)
            {
                if (type.CompareTo(t) < 0)
                    type = t;
            }
            return type;
        }
    }
}
