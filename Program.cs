using System;

namespace FindMaximum 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tFind Maximum Problem using Generics");
            Console.WriteLine("");
            //Printing three test cases
            Console.WriteLine(IntegerMaximum.MaxIntegerNumber(20, 20, 20));
            Console.WriteLine(IntegerMaximum.MaxIntegerNumber(65, 20, 10));
            Console.WriteLine(IntegerMaximum.MaxIntegerNumber(5, 45, 98));
        }   
    }
}