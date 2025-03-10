using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(PrintMessage);
        thread.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500);
        }

        thread.Join(); // Wait for the thread to finish
        Console.WriteLine("All Done!");
    }

    static void PrintMessage()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Thread: {i}");
            Thread.Sleep(700);
        }
    }
}
