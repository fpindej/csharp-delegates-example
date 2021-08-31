using DelegatesExample.Examples;
using DelegatesExample.Test;
using System;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class Program
    {
        private static async Task Main()
        {
            var runMethod = new Action(DeclareDelegateExample.Run);
            runMethod();

            var runMethodAsync = new Func<Task>(TestExample.RunAsync);
            await runMethodAsync();
        }
    }
}
