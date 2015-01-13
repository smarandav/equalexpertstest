using System;
using System.Linq;
using FizzBuzzGenerator;

namespace FizzBuzzTest
{
    class Program
    {
        static readonly IGenerator SequenceGenerator = new SequenceGenerator();

        static void Main(string[] args)
        {
            int limit = 0;
            if (args.Any())
            {
                int.TryParse(args[0], out limit);
            }

            var sequence = SequenceGenerator.Generate(limit);

            foreach (var value in sequence)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
