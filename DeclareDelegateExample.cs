using System;

namespace DelegatesExample
{
    internal class DeclareDelegateExample
    {
        private delegate int Calculate(int x, int y);

        private static int Add(int x, int y) => x + y;

        private static int Subtract(int x, int y) => x - y;

        internal static void Run()
        {
            var addOperation = new Calculate(Add);
            Calculate subtractOperation = Subtract;
            Calculate multiplyOperation = (x, y) => x * y;

            Console.WriteLine("Sum of 5 and 3 is ", addOperation(5, 3));
            Console.WriteLine("Subtraction of 420 and 69 is ", subtractOperation(420, 69));
            Console.WriteLine("Multiplication of 2 and 2 is ", multiplyOperation(2, 2));
        }
    }
}
