using System;
using Demo.DependencyInjection.Abstractions;

namespace Demo.DependencyInjection.Implementation1
{
    public class Multiplicator1 : IMultiplicator
    {
        public int MultiplyNumbers(int multiplicand, int multiplier)
        {
            Console.WriteLine($"Using the {nameof(Multiplicator1)} component");
            return multiplicand * multiplier;
        }
    }
}
