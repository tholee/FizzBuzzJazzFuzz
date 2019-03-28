using JazzFuzz.RangeConfigurations;
using JazzFuzz.ReplacementConfigurations;
using JazzFuzz.Services.Generators;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class JazzFuzzTests
    {
        private IGeneratorService _generator;

        [SetUp]
        public void Setup()
        {
            var range = new AscendingRangeConfiguration();
            var replacement = new JazzFuzzReplacementConfiguration();
            _generator = new GeneratorService(range, replacement);
        }

        [Test]
        public void JazzFuzz_Number_Number()
        {
            string numberOne = _generator.GetValues().ElementAt(1 - 1);
            Assert.AreEqual("1", numberOne);
        }

        [Test]
        public void JazzFuzz_DivisableByNine_Fizz()
        {
            string jazz = _generator.GetValues().ElementAt(9 - 1);
            Assert.AreEqual("Jazz", jazz);
        }

        [Test]
        public void JazzFuzz_DivisableByFour_Buzz()
        {
            string fuzz = _generator.GetValues().ElementAt(4 - 1);
            Assert.AreEqual("Fuzz", fuzz);
        }

        [Test]
        public void JazzFuzz_DivisableByNineAndFour_FizzBuzz()
        {
            string jazzFuzz = _generator.GetValues().ElementAt(9*4 - 1);
            Assert.AreEqual("JazzFuzz", jazzFuzz);
        }
    }
}