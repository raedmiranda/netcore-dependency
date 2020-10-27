using System;
using System.Collections.Generic;
using System.Linq;
using Demo.DependencyInjection.Abstractions;

namespace Demo.DependencyInjection.Implementation2
{
    public class CoinExchanger2 : ICoinExchanger
    {
        public void ExchangeCoins(int amount)
        {
            Console.WriteLine($"Exchanging with unlimited capacity ({nameof(CoinExchanger2)})...");
            List<int> coins = (new[] { 200, 100, 50, 20, 10, 5, 2, 1 }).ToList();
            List<int> times = (new[] { 0, 0, 0, 0, 0, 0, 0, 0 }).ToList(); //Enumerable.Repeat(0, 8).

            for (int i = 0; i < coins.Count; i++)
            {
                times[i] = amount / coins[i];
                amount = amount % coins[i];
            }
            if (amount > 0)
                Console.WriteLine("There's not exchange capacity");
            else
                for (int i = 0; i < coins.Count; i++)
                    //if (times[i] > 0)
                    Console.WriteLine($"{times[i]} banknote of {coins[i] } PEN.");
        }
    }
}
