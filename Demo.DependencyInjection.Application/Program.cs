using Demo.DependencyInjection.Implementation1;
using Demo.DependencyInjection.Implementation2;
using System;

namespace Demo.DependencyInjection.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicator Example without Dependency Injection");
            Console.WriteLine("Enter the multiplicand:");
            var multiplicandString = Console.ReadLine();
            int multiplicand = 0;
            while (!int.TryParse(multiplicandString, out multiplicand))
            {
                Console.WriteLine("Must be a number. Enter the multiplicand again:");
                multiplicandString = Console.ReadLine();
            }
            Console.WriteLine("Enter the multiplier:");
            var multiplierString = Console.ReadLine();
            int multiplier = 0;
            while (!int.TryParse(multiplierString, out multiplier))
            {
                Console.WriteLine("Must be a number. Enter the multiplier again:");
                multiplierString = Console.ReadLine();
            }
            int product = new Multiplicator1().MultiplyNumbers(multiplicand, multiplier);
            Console.WriteLine($"The product is: {product}");
            Console.ReadLine();
        }
    }
}
