using System;

namespace DelegatesExample
{
    internal class MulticastDelegateExample
    {
        private delegate void Calculate(int x, int y);

        private static void Add(int x, int y) => Console.WriteLine($"The sum of {x} and {y} is {x + y}");

        private static void Subtract(int x, int y) => Console.WriteLine($"The subtraction of {x} and {y} is {x - y}");

        private static void Multiply(int x, int y) => Console.WriteLine($"The multiplication of {x} and {y} is {x * y}");

        internal static void Run()
        {
            Calculate operation1 = Add;
            Calculate operation2 = Subtract;
            Calculate operation3 = Multiply;

            Calculate calculate = operation1 + operation2 + operation3;
            calculate(6, 9);

            calculate -= operation2;
            calculate(4, 20);
        }
    }
}
