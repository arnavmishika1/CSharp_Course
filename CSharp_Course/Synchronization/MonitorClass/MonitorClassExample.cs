namespace CSharp_Course.Synchronization.MonitorClass
{
    public class MonitorClassExample
    {
        private static readonly object lockPrintNumber = new object();
        public static void PrintNumbers()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is trying to enter into critical section");
            try
            {
                Monitor.Enter(lockPrintNumber);
                Console.WriteLine($"{Thread.CurrentThread.Name} Entered into critical section");
                for(int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write($"{i},");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(lockPrintNumber);
                Console.WriteLine($"{Thread.CurrentThread.Name} Exit from critical section");
            }
        }

        /*
        static void Main()
        {
            Thread[] threads = new Thread[3];
            for(int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(PrintNumbers)
                {
                    Name = "Child Thread " + i
                };
            }

            foreach(Thread t in threads)
            {
                t.Start();
            }

            Console.ReadKey();
        }
        */
    }
}
