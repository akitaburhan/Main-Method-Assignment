using System;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations operations = new MathOperations();

            // Request user input for an integer
            Console.WriteLine("Enter an integer for the first operation:");
            int intInput = int.Parse(Console.ReadLine());
            int intResult = operations.PerformOperation(intInput);
            Console.WriteLine("Result after integer operation: " + intResult);

            // Request user input for a decimal
            Console.WriteLine("Enter a decimal for the second operation:");
            decimal decimalInput = decimal.Parse(Console.ReadLine());
            int decimalResult = operations.PerformOperation(decimalInput);
            Console.WriteLine("Result after decimal operation: " + decimalResult);

            // Request user input for a string that represents an integer
            Console.WriteLine("Enter a number as a string for the third operation:");
            string stringInput = Console.ReadLine();
            int stringResult = operations.PerformOperation(stringInput);
            Console.WriteLine("Result after string operation: " + stringResult);
        }
    }
}