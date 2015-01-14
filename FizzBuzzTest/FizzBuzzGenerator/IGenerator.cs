using System.Collections.Generic;

namespace FizzBuzzGenerator
{
    public interface IGenerator
    {
        FizzBuzzResult Generate(int limit);
    }
}