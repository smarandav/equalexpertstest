using System.Collections.Generic;

namespace FizzBuzzGenerator
{
    public class FizzBuzzResult
    {
        public FizzBuzzResult()
        {
            SequenceCounts = new Dictionary<string, int>();
            SequenceNumbers = new List<string>();
        }

        public IList<string> SequenceNumbers { get; set; }

        public IDictionary<string, int> SequenceCounts { get; set; }
    }
}
