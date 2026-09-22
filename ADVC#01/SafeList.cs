using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_01
{
    internal class SafeList<T>
    {
        private List<T> values = new List<T>();


        public void Add(T item)
        {
            values.Add(item);
        }
        public T GetValue(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index];
            }
            return default;
        }


    }
}
