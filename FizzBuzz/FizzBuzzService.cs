namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuzzNumber(int input)
        {
            string output = null;

            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Buzz";
            }

            return output ?? input.ToString();
        }
    }
}