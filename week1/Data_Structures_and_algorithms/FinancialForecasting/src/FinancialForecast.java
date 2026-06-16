public class FinancialForecast {

    // Recursive method to calculate future value
    public static double forecast(double currentValue, double growthRate, int years) {
        // Base case: no more years to forecast
        if (years == 0) {
            return currentValue;
        }
        // Recursive case: apply growth rate and forecast for remaining years
        double nextValue = currentValue * (1 + growthRate);
        return forecast(nextValue, growthRate, years - 1);
    }

    public static void main(String[] args) {
        double initialValue = 1000.0;   // starting amount
        double growthRate = 0.05;       // 5% annual growth
        int years = 5;                  // forecast for 5 years

        double futureValue = forecast(initialValue, growthRate, years);
        System.out.println("Future Value after " + years + " years: " + futureValue);
    }
}
