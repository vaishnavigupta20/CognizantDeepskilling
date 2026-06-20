using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Step 1: Private static instance
        private static Logger _instance;

        // Step 2: Private constructor
        private Logger()
        {
            Console.WriteLine("Logger initialized...");
        }

        // Step 3: Public static method to get the instance
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();  // Lazy initialization
            }
            return _instance;
        }

        // Example logging method
        public void Log(string message)
        {
            Console.WriteLine("[LOG]: " + message);
        }
    }
}
