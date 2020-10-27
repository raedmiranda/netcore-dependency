using Autofac;
using Demo.DependencyInjection.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.DependencyInjection.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var IoCContainer = IoCConfiguration.GenerateContainer();
            //MultiplicatorExample(IoCContainer);
            CoinExchangerExample(IoCContainer);
            Console.ReadLine();
        }

        private static void MultiplicatorExample(IContainer IoCContainer)
        {
            Console.WriteLine("Multiplicator Example with Dependency Injection");
            int multiplicand = ReadSafeNumber("multiplicand");
            int multiplier = ReadSafeNumber("multiplier");
            int product = IoCContainer.Resolve<IMultiplicator>().MultiplyNumbers(multiplicand, multiplier);
            Console.WriteLine($"The product is: {product}");
        }
        
        private static void CoinExchangerExample(IContainer IoCContainer)
        {
            Console.WriteLine("CoinExchanger Example with Dependency Injection");
            int amount = ReadSafeNumber("Amount");
            Console.WriteLine("The exchange result is:");
            IoCContainer.Resolve<ICoinExchanger>().ExchangeCoins(amount);
        }

        private static int ReadSafeNumber(string type)
        {
            Console.WriteLine($"Enter the {type}:");
            var numberString = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(numberString, out number))
            {
                Console.WriteLine($"Must be an integer number.\nEnter the {type} again:");
                numberString = Console.ReadLine();
            }
            return number;
        }
    }
}
