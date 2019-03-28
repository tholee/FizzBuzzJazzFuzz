using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            foreach (var number in Enumerable.Range(1, 100))
            {
                Console.WriteLine(fizzBuzzService.GetFizzBuzzNumber(number));
            }
            Console.ReadLine();
        }
    }
}
