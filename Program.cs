using System;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class Program
    {
        public delegate void RunDelegate();

        public delegate Task RunDelegateAsync();

        private static async Task Main()
        {
            var runMethod = new Action(Example1.Run);
            runMethod();

            //var runMethodAsync = new Func<Task>(TestExampleFixed.RunAsync);
            //await runMethodAsync();
        }
    }
}
