using System;

namespace DelegatesExample.Examples
{
    internal class AnonymousMethodExample
    {
        private delegate void NumberOperation(int n);

        internal static void Run()
        {
            NumberOperation printPow = delegate (int x)
            {
                Console.WriteLine($"The pow of {x} is {x * x}");
            };

            printPow(5);
        }
    }
}
