using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread[] threads = new Thread[3]; // Array to store worker threads

        // Create and start multiple worker threads with parameters
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(PrintMessage);
            threads[i].Start(i + 1);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        // Wait for all worker threads to finish
        foreach (Thread thread in threads)
        {
            thread.Join(); // Blocks the main thread until the worker thread finishes
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
