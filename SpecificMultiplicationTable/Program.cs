using System;

namespace SpecificMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, result;

            Console.Write("Enter any number: ");
            number = int.Parse(Console.ReadLine());

            for (int multiplier = 0; multiplier <= 10; multiplier++)
            {
                result = number * multiplier;
                Console.WriteLine(number + " * " + multiplier + " = " + result);
            }
        }
    }
}
