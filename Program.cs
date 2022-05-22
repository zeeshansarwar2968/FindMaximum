using System;

namespace FindMaximum 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tFind Maximum Problem using Generics");
            Console.WriteLine("");
            Console.WriteLine("1.Compare three integer numbers \n2.Compare three float numbers \n3.Compare three string values \n4.Compare three values using Generic Method");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t    Please enter 0 to exit");
            Console.WriteLine("");

            int flag = 0;

            while (flag == 0)
            {
                Console.Write("\nPlease choose the program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: flag = 1; break;
                    case 1:
                        Console.WriteLine("Executing three test cases for Finding Maximum Integer Value");
                        Console.WriteLine(IntegerMaximum.MaxIntegerNumber(20, 20, 20));
                        Console.WriteLine(IntegerMaximum.MaxIntegerNumber(65, 20, 10));
                        Console.WriteLine(IntegerMaximum.MaxIntegerNumber(5, 45, 98));
                        break;
                    case 2:
                        Console.WriteLine("Executing three test cases for Finding Maximum Float Value");
                        Console.WriteLine(FloatMaximum.MaxFloatNumber(10.2f, 20.5f, 20.5f));
                        Console.WriteLine(FloatMaximum.MaxFloatNumber(60f, 20.9f, 100.0f));
                        Console.WriteLine(FloatMaximum.MaxFloatNumber(55.5f, 45.5f, 1.1f));
                        break;
                    case 3:
                        Console.WriteLine("Executing three test cases for Finding Maximum String Value");
                        Console.WriteLine(StringMaximum.MaxStringValue("Abc", "Abc1", "Abcc"));
                        Console.WriteLine(StringMaximum.MaxStringValue("Aabbcc", "Abc123", "Abcc"));
                        Console.WriteLine(StringMaximum.MaxStringValue("Abbc", "Abc", "AAbc"));
                        break;
                    case 4:
                        Console.WriteLine("Executing three test cases for Finding Maximum Value");
                        Console.WriteLine(RefactoredMethod.MaximumValue(65, 20, 10));
                        Console.WriteLine(RefactoredMethod.MaximumValue(10.2f, 20.5f, 20.5f));
                        Console.WriteLine(RefactoredMethod.MaximumValue("Abbc", "Abc", "AAbc"));
                        break;
                    default:
                        Console.WriteLine("Invalid option/entry, please choose again.");
                        break;
                }
            }
              
            
        }   
    }
}