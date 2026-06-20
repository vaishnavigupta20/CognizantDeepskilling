using System;

namespace FinancialForecasting
{
    public class FinancialForecast
    {
        // Recursive method to calculate future value
        public static double Forecast(double currentValue, double growthRate, int years)
        {
            // Base case: no more years to forecast
            if (years == 0)
            {
                return currentValue;
            }

            // Recursive case: apply growth rate and forecast for remaining years
            double nextValue = currentValue * (1 + growthRate);
            return Forecast(nextValue, growthRate, years - 1);
        }

        public static void Main(string[] args)
        {
            double initialValue = 1000.0;   // starting amount
            double growthRate = 0.05;       // 5% annual growth
            int years = 5;                  // forecast for 5 years

            double futureValue = Forecast(initialValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {futureValue}");
        }
    }
}
