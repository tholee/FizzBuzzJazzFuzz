using System;
using System.Collections.Generic;

namespace JazzFuzz.Services.Presenters
{
    public class ConsolePresenterService : IPresenterService
    {
        public void Present(IEnumerable<string> values)
        {
            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
