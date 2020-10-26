using Autofac;
using Demo.DependencyInjection.Abstractions;
using System;

namespace Demo.DependencyInjection.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var IoCContainer = IoCConfiguration.GenerateContainer();

            Console.WriteLine("Multiplicator Example with Dependency Injection");
            int multiplicand = ReadSafeNumber("multiplicand");
            int multiplier = ReadSafeNumber("multiplier");
            int product = IoCContainer.Resolve<IMultiplicator>().MultiplyNumbers(multiplicand, multiplier);
            Console.WriteLine($"The product is: {product}");
            Console.ReadLine();
        }

        private static int ReadSafeNumber(string type)
        {
            Console.WriteLine($"Enter the {type}:");
            var numberString = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(numberString, out number))
            {
                Console.WriteLine($"Must be a number.\nEnter the {type} again:");
                numberString = Console.ReadLine();
            }
            return number;
        }
    }
}
