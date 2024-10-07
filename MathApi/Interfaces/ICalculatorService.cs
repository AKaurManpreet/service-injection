namespace MathApi.Interfaces
{
    // Interface for the Calculator Service
    public interface ICalculatorService
    {
        // Method for Addition
        double Add(double a, double b);

        // Method for Subtraction
        double Subtract(double a, double b);

        // Method for Multiplication
        double Multiply(double a, double b);

        // Method for Division
        double Divide(double a, double b);
    }
}