using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFeatures
{
    class GenericClassTkng3Prmtrs<E> where E : IComparable
    {
        public E firstValue, secondValue, thirdValue;

        public GenericClassTkng3Prmtrs(E firstValue, E secondValue, E thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static E MaxValue(E var1, E var2, E var3)
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
            return default;
        }
        public E MaxMethod()
        {
        
            E max = GenericClassTkng3Prmtrs<E>.MaxValue(this.firstValue, this.secondValue, this.thirdValue)
;             return max;
        }

    }
}
