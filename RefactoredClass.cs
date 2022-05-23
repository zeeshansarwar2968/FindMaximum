﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    //The IComparable interface defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
    internal class RefactoredClass<T> where T : IComparable
    {
        T value1, value2, value3;

        public RefactoredClass(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public static T MaximumValue(T value1, T value2, T value3)
        {
            //dynamic value1 = valueI1;
            //dynamic value2 = valueI2;
            //dynamic value3 = valueI3;
            //Condition to Compare the value1 to value2 and value3
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0 || value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) > 0 || value1.CompareTo(value2) > 0 && value1.CompareTo(value3) >= 0)
            {
                return value1;
            }
            //Condition to Compare the value2 to value1 and value3
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0 || value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) > 0 || value2.CompareTo(value1) > 0 && value2.CompareTo(value3) >= 0)
            {
                return value2;
            }
            //Condition to Compare the value3 to value2 and value1
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0 || value3.CompareTo(value1) >= 0 && value3.CompareTo(value2) > 0 || value3.CompareTo(value1) > 0 && value3.CompareTo(value2) >= 0)
            {
                return value3;
            }
            //return value if all the input values are equal
            return value1;
        }
    }
}
