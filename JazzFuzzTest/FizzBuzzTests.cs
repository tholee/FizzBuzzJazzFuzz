using JazzFuzz.RangeConfigurations;
using JazzFuzz.ReplacementConfigurations;
using JazzFuzz.Services.Generators;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FizzBuzzTests
    {
        private IGeneratorService _generator;

        [SetUp]
        public void Setup()
        {
            var range = new AscendingRangeConfiguration();
            var replacement = new FizzBuzzReplacementConfiguration();
            _generator = new GeneratorService(range, replacement);
        }

        [Test]
        public void FizzBuzz2_Number_Number()
        {
            string numberOne = _generator.GetValues().ElementAt(1 - 1);
            Assert.AreEqual("1", numberOne);
        }

        [Test]
        public void FizzBuzz2_DivisableByThree_Fizz()
        {
            string fizz = _generator.GetValues().ElementAt(3 - 1);
            Assert.AreEqual("Fizz", fizz);
        }

        [Test]
        public void FizzBuzz2_DivisableByFive_Buzz()
        {
            string buzz = _generator.GetValues().ElementAt(5 - 1);
            Assert.AreEqual("Buzz", buzz);
        }

        [Test]
        public void FizzBuzz2_DivisableByThreeAndFive_FizzBuzz()
        {
            string fizzBuzz = _generator.GetValues().ElementAt(3*5 - 1);
            Assert.AreEqual("FizzBuzz", fizzBuzz);
        }
    }
}