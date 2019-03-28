using FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    public class FizzBuzzTests
    {
        private IFizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        public void FizzBuzz1_Number_Number()
        {
            string numberOne = _fizzBuzzService.GetFizzBuzzNumber(1);
            Assert.AreEqual("1", numberOne);
        }

        [Test]
        public void FizzBuzz1_DivisableByThree_Fizz()
        {
            string fizz = _fizzBuzzService.GetFizzBuzzNumber(3);
            Assert.AreEqual("Fizz", fizz);
        }

        [Test]
        public void FizzBuzz1_DivisableByFive_Buzz()
        {
            string buzz = _fizzBuzzService.GetFizzBuzzNumber(5);
            Assert.AreEqual("Buzz", buzz);
        }

        [Test]
        public void FizzBuzz1_DivisableByThreeAndFive_FizzBuzz()
        {
            string fizzBuzz = _fizzBuzzService.GetFizzBuzzNumber(15);
            Assert.AreEqual("FizzBuzz", fizzBuzz);
        }
    }
}