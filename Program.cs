using System;

namespace Console_App__division_by_zero_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double numerator = 0, denominator = 0, result = 0;

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter the numerator: ");
                    numerator = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the denominator: ");
                    denominator = Convert.ToDouble(Console.ReadLine());

                    result = Divide(numerator, denominator);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Please enter valid numbers.");
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation attempt completed.");
                    Console.ReadLine(); // Затримка для натискання Enter перед наступним обчисленням
                }
            }
        }

        static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return numerator / denominator;
        }
    }
}
