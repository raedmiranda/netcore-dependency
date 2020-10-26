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
            int @adition = 0, multiplicandAux = 0, multiplierAux = 0;
            multiplicandAux = (multiplicand < 0) ? -multiplicand : multiplicand;
            multiplierAux = (multiplier < 0) ? -multiplier : multiplier;
            for (int repetition = multiplierAux; repetition > 0; repetition--)
                @adition += multiplicandAux;
            return ((multiplicand < 0 && multiplier < 0) || (multiplicand > 0 && multiplier > 0)) ? @adition : -@adition;
        }
    }
}
