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

            foreach (var value in sequence.SequenceNumbers)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();

            foreach (var value in sequence.SequenceCounts)
            {
                Console.WriteLine("{0}: {1}", value.Key, value.Value);
            }
        }
    }
}
