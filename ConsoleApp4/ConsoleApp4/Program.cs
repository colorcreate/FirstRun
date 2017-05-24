using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ToMorse(input));
            Console.Read();

        }

        // in MorseCodeTranslator class
        public static string ToMorse(string input)
        {
            List<String> output = new List<String>();

            foreach (char huruf in input.ToUpper())
            {
                string morseCode = _textToMorse[huruf];
                output.Add(morseCode);
            }

            return string.Join(" ", output);
        }


        // in MorseCodeTranslator class
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>()
        {
          {' ', "/"},
          {'A', ".-"},
          {'B', "-..."},
          {'C', "-.-."},
          {'D', "-.."},
          {'E', "."},
          {'F', "..-."},
          {'G', "--."},
          {'H', "...."},
          {'I', ".."},
          {'J', ".---"},
          {'K', "-.-"},
          {'L', ".-.."},
          {'M', "--"},
          {'N', "-."},
          {'O', "---"},
          {'P', ".--."},
          {'Q', "--.-"},
          {'R', ".-."},
          {'S', "..."},
          {'T', "-"},
          {'U', "..-"},
          {'V', "...-"},
          {'W', ".--"},
          {'X', "-..-"},
          {'Y', "-.--"},
          {'Z', "--.."},
          {'1', ".----"},
          {'2', "..---"},
          {'3', "...--"},
          {'4', "....-"},
          {'5', "....."},
          {'6', "-...."},
          {'7', "--..."},
          {'8', "---.."},
          {'9', "----."},
          {'0', "-----"},
        };
    }
}
