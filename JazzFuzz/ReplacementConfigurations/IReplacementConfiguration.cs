using System.Collections.Generic;

namespace JazzFuzz.ReplacementConfigurations
{
    public interface IReplacementConfiguration
    {
        IEnumerable<(int Number, string Text)> GetReplacements();
    }
}