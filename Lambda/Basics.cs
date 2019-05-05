using System;
using System.Collections.Generic;

namespace Basics
{
    class Program
    {

        private delegate double MathOperation(double value, double value1);

        static void Main(string[] args)
        {
            MathOperation op = multiply;
            Console.WriteLine(op(2, 5));

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers
                .FindAll(num => num % 2 == 0)
                .ForEach(num => Console.Write(num + " "));

            Console.WriteLine();
            Console.WriteLine("something".Hide());

            Nullables.nullables();
        }
        private static double multiply(double value, double multiplier)
        {
            return value * multiplier;
        }

    }
}
