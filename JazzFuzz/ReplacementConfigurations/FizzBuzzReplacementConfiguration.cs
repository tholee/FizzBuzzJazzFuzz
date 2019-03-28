using System.Collections.Generic;

namespace JazzFuzz.ReplacementConfigurations
{
    public class FizzBuzzReplacementConfiguration : IReplacementConfiguration
    {
        public IEnumerable<(int Number, string Text)> GetReplacements()
        {
            return new List<(int Number, string Text)>()
            {
                (Number: 3, Text: "Fizz"),
                (Number: 5, Text: "Buzz")
            };
        }
    }
}
