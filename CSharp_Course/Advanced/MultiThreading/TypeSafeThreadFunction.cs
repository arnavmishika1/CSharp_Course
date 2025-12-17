namespace CSharp_Course.Advanced.NewMultiThreading
{
    // When we are saying type-safe, it means we should not use the object data type
    // Step1: You need to encapsulate the thread function and the data it requires in a helper class.
    public class NumberHelper
    {
        int _Number;

        public NumberHelper(int Number)
        {
            _Number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine("value : " + i);
            }
        }
    }

    // Step 2: we need to create an instance of NumberHelper class and to its constructor, we need to pass the integer value. Then create the ThreadStart delegate instance and pass the DisplayNumbers function as a parameter to its constructor.
    public class TypeSafeThreadFunction
    {
        /*
        static void Main(string[] args)
        {
            int Max = 10;
            NumberHelper obj = new NumberHelper(Max);

            Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));

            T1.Start();
            Console.Read();
        }
        */
    }
}
