using System;
using System.Threading;

namespace Singleton
{
    public static class Program
    {
        private static void Main()
        {
            Thread process1 = new Thread(() => Console.WriteLine(Guitar.GetGuitar.PlayTheGuitar("A")));
            Thread process2 = new Thread(() => Console.WriteLine(Guitar.GetGuitar.PlayTheGuitar("B")));

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }
    }
}