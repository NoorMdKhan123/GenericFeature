using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFeatures
{
    class GenericMaximumWithClass<T> where T :IComparable
    {
        public T[] value;
       public GenericMaximumWithClass(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[^1];
         }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }

    }
}
