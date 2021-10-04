using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFeatures
{
    class MaxWithGenerics
    {
        public static T MaxGenerics <T> (T var1, T var2, T var3) where T : IComparable<T>
        {
            if (var1.CompareTo(var2) > 0 && var1.CompareTo(var3) > 0)
            {
                return var1;

            }
            else if (var2.CompareTo(var1) > 0 && var2.CompareTo(var3) > 0)
            {
                return var2;
            }
            else
            {
                return var3;
            }
        }
    }
}
