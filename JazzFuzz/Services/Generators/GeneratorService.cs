using JazzFuzz.RangeConfigurations;
using JazzFuzz.ReplacementConfigurations;
using System.Collections.Generic;

namespace JazzFuzz.Services.Generators
{
    public class GeneratorService : IGeneratorService
    {
        private IRangeConfiguration _rangeConfiguration;
        private IReplacementConfiguration _replacementConfiguration;

        public GeneratorService(IRangeConfiguration rangeConfiguration, IReplacementConfiguration replacementConfiguration)
        {
            _rangeConfiguration = rangeConfiguration;
            _replacementConfiguration = replacementConfiguration;
        }

        public IEnumerable<string> GetValues()
        {
            foreach(var value in _rangeConfiguration.GetRange())
            {
                yield return GetSingleValue(value);
            }
        }

        private string GetSingleValue(int input)
        {
            string output = null;
            foreach(var (Number, Text) in _replacementConfiguration.GetReplacements())
            {
                if (input % Number == 0)
                {
                    output += Text;
                }
            }
            return output ?? input.ToString();
        }
    }
}
