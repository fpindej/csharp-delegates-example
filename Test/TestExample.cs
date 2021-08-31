using System;
using System.Threading.Tasks;

namespace DelegatesExample.Test
{
    public class TestExample
    {
        public static Task RunAsync()
        {
            return SomeMethodAsync(async () =>
            {
                await Task.Delay(1000);
                Console.WriteLine("Hello There!");
            });
        }

        private static async Task SomeMethodAsync(Action action)
        {
            await Task.Delay(1);
            action();
        }
    }
}
