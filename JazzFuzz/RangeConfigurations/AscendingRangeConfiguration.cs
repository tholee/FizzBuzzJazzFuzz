using System.Collections.Generic;
using System.Linq;

namespace JazzFuzz.RangeConfigurations
{
    public class AscendingRangeConfiguration : IRangeConfiguration
    {
        public IEnumerable<int> GetRange()
        {
            return Enumerable.Range(1, 100);
        }
    }
}
