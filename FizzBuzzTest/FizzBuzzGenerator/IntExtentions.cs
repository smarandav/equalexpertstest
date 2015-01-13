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
    }
}
