using System.Collections.Generic;

namespace JazzFuzz.ReplacementConfigurations
{
    public class JazzFuzzReplacementConfiguration : IReplacementConfiguration
    {
        public IEnumerable<(int Number, string Text)> GetReplacements()
        {
            return new List<(int Number, string Text)>()
            {
                (Number: 9, Text: "Jazz"),
                (Number: 4, Text: "Fuzz")
            };
        }
    }
}
