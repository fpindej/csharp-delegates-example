using System;

namespace DelegatesExample
{
    internal class Example3
    {
        private static void DoSomething(int i) => Console.WriteLine(i);

        private static double CalculateSomething(int i) => (double)i / 2;

        internal static void Run()
        {
            var myAction = new Action<int>(DoSomething);
            myAction(123);
            myAction.Invoke(456);

            var myFunc = new Func<int, double>(CalculateSomething);
            Console.WriteLine(myFunc(5));
        }
    }
}
