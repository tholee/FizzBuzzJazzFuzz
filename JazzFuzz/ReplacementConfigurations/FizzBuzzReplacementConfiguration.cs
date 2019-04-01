using System.Collections.Generic;

namespace JazzFuzz.ReplacementConfigurations
{
    public class FizzBuzzReplacementConfiguration : IReplacementConfiguration
    {
        public IEnumerable<(int Number, string Text)> GetReplacements()
        {
            return new List<(int Number, string Text)>()
            {
                (3, "Fizz"),
                (5, "Buzz")
            };
        }
    }
}
