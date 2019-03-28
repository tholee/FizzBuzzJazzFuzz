using System.Collections.Generic;
using System.Linq;

namespace JazzFuzz.RangeConfigurations
{
    public class FizzBuzzOnlyRangeConfiguration : IRangeConfiguration
    {
        public IEnumerable<int> GetRange()
        {
            return Enumerable.Range(0, 100).Where(x => x % 3 == 0 || x % 5 == 0);
        }
    }
}
