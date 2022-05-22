using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    internal class FloatMaximum
    {
        public static float MaxFloatNumber(float num1, float num2, float num3)
        {
            //Condition to Compare the num1 to num2 and num3
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            //Condition to Compare the num2 to num1 and num3
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            //Condition to Compare the num3 to num2 and num1
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            //return value if all the numbers are equal
            return num1;
        }
    }
}
