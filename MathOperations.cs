using System;

namespace MathAssignment
{
    // Define a class to contain various math operations
    public class MathOperations
    {
        // Method that takes an integer, adds 10 to it, and returns the result as an integer
        public int PerformOperation(int number)
        {
            return number + 10;
        }

        // Overloaded method that takes a decimal, multiplies it by 2, and returns the result as an integer
        public int PerformOperation(decimal number)
        {
            return (int)(number * 2);
        }

        // Overloaded method that takes a string, converts it to an integer, subtracts 5, and returns the result as an integer
        public int PerformOperation(string number)
        {
            int parsedNumber = int.Parse(number); // Convert string to integer
            return parsedNumber - 5;
        }
    }
}