using System;
using System.Collections.Generic;
using System.Text;
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
            {'v', "...-"}, {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"}, {'z', "--.."}, {'0', "-----"},
            {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
            {'7', "--..."}, {'8', "---.."}, {'9', "----." }
        };

        public void Present(IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                TranslateAndPlayMorse(value);
            }
            Console.ReadLine();
        }

        private void TranslateAndPlayMorse(string value)
        {
            DisplayOriginalValue(value);
            var morseWord = TranslateMorse(value);
            PlayMorseWord(morseWord);
        }

        private string TranslateMorse(string value)
        {
            var sb = new StringBuilder();
            foreach (var character in value.ToLower())
            {
                sb.Append(_morseLookupDictionary[character] + " ");
            }
            return sb.ToString();
        }

        private void DisplayOriginalValue(string value)
        {
            Console.Write(value + ": ");
        }

        private void PlayMorseWord(string morseWord)
        {
            foreach(var character in morseWord)
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
            Console.WriteLine();
            Thread.Sleep(7*TimeUnitMs);
        }
    }
}
