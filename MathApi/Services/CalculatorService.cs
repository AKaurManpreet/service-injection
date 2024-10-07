using MathApi.Interfaces;

namespace MathApi.Services
{
    // Calculator Service implementing the ICalculatorService interface
    public class CalculatorService : ICalculatorService
    {
        // Implementation of the Add method
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Implementation of the Subtract method
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Implementation of the Multiply method
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Implementation of the Divide method
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}