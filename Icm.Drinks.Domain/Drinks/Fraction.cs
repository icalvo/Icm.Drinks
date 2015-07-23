using System;

namespace Icm.Drinks.Domain.Drinks
{
    public class Fraction
    {
        public Fraction(int numerator, int denominator = 1)
        {
            if (denominator == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(denominator));
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; }
        public int Denominator { get; }
        public double Value => (double)Numerator / Denominator;
    }
}