using System.Collections.Generic;

namespace JazzFuzz.Services.Generators
{
    public interface IGeneratorService
    {
        IEnumerable<string> GetValues();
    }
}