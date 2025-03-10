using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create and start multiple worker threads with parameters
        for (int i = 0; i< 3; i++)
        {
            Thread thread = new Thread(PrintMessage);
            thread.Start(i); // Pass "i" as ana argument
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        //thread.Join(); // Wait for the thread to finish
        Console.WriteLine("All Done!");
    }

    static void PrintMessage(object threadId)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Thread {threadId}: {i}");
            Thread.Sleep(700);
        }
    }
}
