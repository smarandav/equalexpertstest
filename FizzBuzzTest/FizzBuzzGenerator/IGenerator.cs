using System.Collections.Generic;

namespace FizzBuzzGenerator
{
    public interface IGenerator
    {
        IList<string> Generate(int limit);
    }
}