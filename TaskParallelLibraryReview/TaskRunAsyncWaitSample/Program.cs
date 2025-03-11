using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunAsyncWaitSample
{
    class Program
    {
        static async Task Main()
        {
            Task task = PrintMessageAsync();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                await Task.Delay(500);
            }

            await task;
            Console.WriteLine("All done!--");
        }

        static async Task PrintMessageAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Worker Task: {i}");
                await Task.Delay(700);
            }
            
        }
    }
}