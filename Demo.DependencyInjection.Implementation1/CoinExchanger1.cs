using System;
using System.Collections.Generic;
using System.Linq;
using Demo.DependencyInjection.Abstractions;

namespace Demo.DependencyInjection.Implementation1
{
    public class CoinExchanger1 : ICoinExchanger
    {
        public void ExchangeCoins(int amount)
        {
            Console.WriteLine($"Exchanging with limited capacity ({nameof(CoinExchanger1)})...");
            List<int> coins = (new[] { 200, 100, 50, 20, 10, 5, 2, 1 }).ToList();
            List<int> quantity = Enumerable.Repeat(5, coins.Count).ToList();
            List<int> times = Enumerable.Repeat(0, coins.Count).ToList();
            int r;

            for (int i = 0; i < coins.Count; i++)
            {
                r = 0;
                while (amount >= coins[i] && r < quantity[i])
                {
                    times[i]++;
                    r++;
                    amount -= coins[i];
                }
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
