using System;

public class Program
{
    private const double BASE_RATE = 200.00;
    private const double HOURLY_RATE = 150.00;
    private const double PER_MILE_RATE = 2.00;

    public static double CalculateFee(double hours, double miles)
    {
        return BASE_RATE + (hours * HOURLY_RATE) + (miles * PER_MILE_RATE);
    }

    public static void Main(string[] args)
    {
        // Running simulated tests
        Console.WriteLine("Running Tests...");
        SimulateTest(10, 600, 2900.00);
        SimulateTest(6.77, 15, 1245.50);
        SimulateTest(56.25, 325, 9387.50);
        SimulateTest(103, 3000, 21650.00);
        Console.WriteLine("Tests Completed!\n");

        // Actual user interaction
        Console.Write("Enter the estimated number of hours for the job: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the estimated number of miles involved in the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        double fee = CalculateFee(hours, miles);
        Console.WriteLine($"\nTotal moving fee: ${fee:.2f}");
    }

    public static void SimulateTest(double hours, double miles, double expected)
    {
        double result = CalculateFee(hours, miles);
        if (Math.Abs(result - expected) < 0.01)
        {
            Console.WriteLine($"Test for {hours} hours and {miles} miles: PASSED (Expected ${expected}, Got ${result:.2f})");
        }
        else
        {
            Console.WriteLine($"Test for {hours} hours and {miles} miles: FAILED (Expected ${expected}, Got ${result:.2f})");
        }
    }
}
