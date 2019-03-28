using System.Collections.Generic;

namespace JazzFuzz.RangeConfigurations
{
    public interface IRangeConfiguration
    {
        IEnumerable<int> GetRange();
    }
}