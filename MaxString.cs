using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFeatures
{
    class MaxString
    {
        public static string stringMax(string value1, string value2, string value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;

            }
            else if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }
    }
}
