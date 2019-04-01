using System.Collections.Generic;

namespace JazzFuzz.ReplacementConfigurations
{
    public class JazzFuzzReplacementConfiguration : IReplacementConfiguration
    {
        public IEnumerable<(int Number, string Text)> GetReplacements()
        {
            return new List<(int Number, string Text)>()
            {
                (9, "Jazz"),
                (4, "Fuzz")
            };
        }
    }
}
