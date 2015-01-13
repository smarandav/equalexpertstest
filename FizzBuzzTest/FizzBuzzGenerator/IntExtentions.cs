using System.Globalization;

namespace FizzBuzzGenerator
{
    public static class IntExtentions
    {
        public static bool IsMultipleOf(this int number, int divisor)
        {
            if (divisor == 0)
            {
                return false;
            }

            return number % divisor == 0;
        }

        public static bool ContainsANumber(this int number, int subNumber)
        {
            return number.ToString(CultureInfo.InvariantCulture).Contains(subNumber.ToString(CultureInfo.InvariantCulture));
        }
    }
}
