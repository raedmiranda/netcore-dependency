using System;
using Demo.DependencyInjection.Abstractions;

namespace Demo.DependencyInjection.Implementation2
{
    public class Multiplicator2 : IMultiplicator
    {
        public int MultiplyNumbers(int multiplicand, int multiplier)
        {
            Console.WriteLine($"Using the {nameof(Multiplicator2)} component");

            if (multiplicand == 0 || multiplier == 0) return 0;
            var @adition = 0;
            var multiplicandAux = 0;
            var multiplierAux = 0;
            multiplicandAux = (multiplicand < 0) ? -multiplicand : multiplicand;
            multiplierAux = (multiplier < 0) ? -multiplier : multiplier;
            for (int repetition = multiplierAux; repetition > 0; repetition--)
                @adition += multiplicandAux;
            if ((multiplicand < 0 && multiplier < 0) ||
                (multiplicand > 0 && multiplier > 0))
                return @adition;

            return -@adition;
        }

    }
}
