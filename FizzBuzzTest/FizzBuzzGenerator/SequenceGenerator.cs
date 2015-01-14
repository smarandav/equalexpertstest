using System.Globalization;

namespace FizzBuzzGenerator
{
    public class SequenceGenerator : IGenerator
    {
        private const string Fizz = "fizz";
        private const string Buzz = "buzz";
        private const string FizzBuzz = "fizzbuzz";
        private const string Lucky = "lucky";
        private const string Integer = "integer";

        public FizzBuzzResult Generate(int limit)
        {
            var result = InitFizBuzzResult();
           
            if (limit > 0)
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (i.ContainsANumber(3))
                    {
                        result.SequenceNumbers.Add(Lucky);
                        result.SequenceCounts[Lucky]++;
                    }
                    else
                    {
                        bool isMultipleOfThree = i.IsMultipleOf(3);
                        bool isMultipleOfFive = i.IsMultipleOf(5);
                        bool isMultipleOfFifteen = isMultipleOfFive && isMultipleOfThree;

                        if (isMultipleOfFifteen)
                        {
                            result.SequenceNumbers.Add(FizzBuzz);
                            result.SequenceCounts[FizzBuzz]++;
                        }
                        else
                        {
                            if (isMultipleOfThree)
                            {
                                result.SequenceNumbers.Add(Fizz);
                                result.SequenceCounts[Fizz]++;
                            }
                            else
                            {
                                if (isMultipleOfFive)
                                {
                                    result.SequenceNumbers.Add(Buzz);
                                    result.SequenceCounts[Buzz]++;
                                }
                                else
                                {
                                    result.SequenceNumbers.Add(i.ToString(CultureInfo.InvariantCulture));
                                    result.SequenceCounts[Integer]++;
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
        
        private FizzBuzzResult InitFizBuzzResult()
        {
            var result = new FizzBuzzResult();
            result.SequenceCounts.Add(Fizz, 0);
            result.SequenceCounts.Add(Buzz, 0);
            result.SequenceCounts.Add(FizzBuzz, 0);
            result.SequenceCounts.Add(Lucky, 0);
            result.SequenceCounts.Add(Integer, 0);

            return result;
        }
    }
}
