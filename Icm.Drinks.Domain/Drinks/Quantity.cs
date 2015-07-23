using System;

namespace Icm.Drinks.Domain.Drinks
{
    public class Quantity
    {
        public Quantity(Unit unit, Fraction amount)
        {
            if (unit == null) throw new ArgumentNullException(nameof(unit));
            if (amount == null) throw new ArgumentNullException(nameof(amount));

            if (unit.RequiresIntegerAmount && !amount.IsInteger)
            {
                throw new ArgumentException($"Cannot have a fractionary amount of {unit.Name}", nameof(unit));    
            }

            Unit = unit;
            Amount = amount;
        }

        public Quantity(Unit unit, int fractionNumerator, int fractionDenominator = 1)
            : this(unit, new Fraction(fractionNumerator, fractionDenominator))
        {
        }

        public Unit Unit { get; }
        public Fraction Amount { get; }
    }
}