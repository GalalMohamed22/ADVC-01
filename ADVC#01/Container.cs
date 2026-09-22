using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_01
{
    public class Container<T>
    {
        private static List<T> values = new List<T>();
        public static List<T> GetValues()
        {
            return values;
        }
        public static void AddValue(T? Item)
        {
            values.Add(Item);
        }


    }
}
