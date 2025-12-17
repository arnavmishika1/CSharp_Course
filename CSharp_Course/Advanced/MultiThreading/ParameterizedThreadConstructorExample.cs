namespace CSharp_Course.Advanced.MultiThreading
{
    public class ParameterizedThreadConstructorExample
    {
        public void DisplayNumber(object max)
        {
            int num = Convert.ToInt32(max);
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Number {i}");
            }
        }

        /*
        public static void Main()
        {
            ParameterizedThreadConstructorExample obj = new();
            // Short form:
            //Thread t1 = new Thread(obj.DisplayNumber);

            // Actual form:
            ParameterizedThreadStart paraT = new ParameterizedThreadStart(obj.DisplayNumber);
            Thread t1 = new Thread(paraT);

            t1.Start(5);
            Console.ReadKey();
        }
        */
    }

    public class ParameterlessThread
    {
        public void DisplayNumber()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number {i}");
            }
        }
        /*
        public static void Main()
        {
            ParameterlessThread obj = new();
            // Short form:
            //Thread t1 = new Thread(obj.DisplayNumber);

            // Actual form:
            ThreadStart tStart = new ThreadStart(obj.DisplayNumber);
            Thread t1 = new Thread(tStart);

            t1.Start();
            Console.ReadKey();
        }
        */
    }
}
