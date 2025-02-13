namespace Fractional
{
    public class RationalNumber
    {
        int numerator;
        int denominator;

        public RationalNumber(int num, int denom)
        {
            numerator = num;
            denominator = denom;

            var gcd = GreatestCommonDenominator(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        // (from Adam Fall 2020)
        static int GreatestCommonDenominator(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return GreatestCommonDenominator(b, a % b);
            }
        }

        public interface IEquatable<RationalNumber>
        {
            public bool Equals(RationalNumber? other)
            {
                throw new NotImplementedException();
            }
        }

        public interface IComparable<RationalNumber>
        {
            public int CompareTo(RationalNumber? other)
            {
                throw new NotImplementedException();
            }
        }
    }
}
