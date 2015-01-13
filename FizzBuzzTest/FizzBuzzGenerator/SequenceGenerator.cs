using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzzGenerator
{
    public class SequenceGenerator : IGenerator
    {
        private const string Fizz = "fizz";
        private const string Buzz = "buzz";
        private const string FizzBuzz = "fizzbuzz";
        private const string Lucky = "lucky";

        public IList<string> Generate(int limit)
        {
            var list = new List<string>();

            if (limit > 0)
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (i.ContainsANumber(3))
                    {
                        list.Add(Lucky);
                    }
                    else
                    {
                        bool isMultipleOfThree = i.IsMultipleOf(3);
                        bool isMultipleOfFive = i.IsMultipleOf(5);
                        bool isMultipleOfFifteen = isMultipleOfFive && isMultipleOfThree;

                        if (isMultipleOfFifteen)
                        {
                            list.Add(FizzBuzz);
                        }
                        else
                        {
                            if (isMultipleOfThree)
                            {
                                list.Add(Fizz);
                            }
                            else
                            {
                                if (isMultipleOfFive)
                                {
                                    list.Add(Buzz);
                                }
                                else
                                {
                                    list.Add(i.ToString(CultureInfo.InvariantCulture));
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }
    }
}
