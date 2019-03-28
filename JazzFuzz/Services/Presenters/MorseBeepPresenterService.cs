using System;
using System.Collections.Generic;
using System.Threading;

namespace JazzFuzz.Services.Presenters
{
    class MorseBeepPresenterService : IPresenterService
    {
        // Morse code timing: http://www.codebug.org.uk/learn/step/541/morse-code-timing-rules/
        private const int TimeUnitMs = 100;
        private const int Frequency = 650;

        private readonly Dictionary<char, string> _morseLookupDictionary = new Dictionary<char, string>
        {
            {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."},
            {'h', "...."}, {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n', "-."},
            {'o', "---"}, {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"},
            {'v', "...-"}, {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"}, {'z', "--.."}, {'0', "-----"}, {'1', ".----"},
            {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----." }
        };

        public void Present(IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                TranslateAndPlayMorse(value);
            }           
        }

        private void TranslateAndPlayMorse(string value)
        {
            var morseCode = TranslateMorse(value);
            DisplayOriginalValue(value);
            PlayMorse(morseCode);
        }

        private string TranslateMorse(string value)
        {
            string output = null;
            foreach (var character in value.ToLower())
            {
                output += _morseLookupDictionary[character] + " ";
            }
            return output;
        }

        private void DisplayOriginalValue(string value)
        {
            Console.Write(value + ": ");
        }

        private void PlayMorse(string morseCode)
        {
            foreach(var character in morseCode)
            {
                Console.Write(character);
                if (character.Equals('.'))
                {
                    Console.Beep(Frequency, 1*TimeUnitMs);
                }
                else if (character.Equals('-'))
                {
                    Console.Beep(Frequency, 3*TimeUnitMs);
                }
                else if (character.Equals(' '))
                {
                    Thread.Sleep(3*TimeUnitMs);
                }
            }
            Thread.Sleep(7*TimeUnitMs);
            Console.WriteLine();
        }
    }
}
