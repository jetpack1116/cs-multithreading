using System;
using System.Threading;
using System.Threading.Tasks;

class TaskRunSample
{
    static void Main()
    {
        Task task = Task.Run(PrintMessage); // Start the task

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        task.Wait(); // Wait for the task to finish
        Console.WriteLine("All done!");
    }

    static void PrintMessage()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Task: {i}");
            Thread.Sleep(700);
        }

    }
}