using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Logger instances
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            // Test logging
            logger1.Log("First log message");
            logger2.Log("Second log message");

            // Verify both references point to the same object
            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger1 and logger2 are the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances exist (Singleton failed).");
            }
        }
    }
}
