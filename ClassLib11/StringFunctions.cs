using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib11
{
    public  class StringFunctions
    {
        public int CountCharacters(string sentence) =>
            (sentence ?? "*").Length;

        public bool IsPalindrome(string input)
        {
            input = input?.Replace(" ", "").ToLower() ?? "*";
            return input == new string(input.Reverse().ToArray());
        }

        public string ReverseSentence(string input) =>
            new string((input ?? "*").Reverse().ToArray());

        public void CountDetails(string input, out int vowels, out int consonants, out int digits, out int specials)
        {
            vowels = consonants = digits = specials = 0;
            input = input ?? "*";
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
                else if (char.IsDigit(c)) digits++;
                else if (!char.IsWhiteSpace(c)) specials++;
            }
        }

        public string ToProperCase(string input)
        {
            return string.Join(" ", (input ?? "*").Split(' ', StringSplitOptions.RemoveEmptyEntries)
                           .Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower()));
        }

        public string CombineWith(string str1, string str2) =>
            (str1 ?? "") + " " + (str2 ?? "");

        public string RemoveExtraSpaces(string input) =>
            string.Join(" ", (input ?? "*").Split(' ', StringSplitOptions.RemoveEmptyEntries));

        public int WordCount(string input) =>
            (input ?? "*").Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

        public bool ContainsSubstring(string input, string substr) =>
            (input ?? "").Contains(substr ?? "");

        public int SubstringOccurrences(string input, string substr)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(substr)) return 0;
            int count = 0, index = 0;
            while ((index = input.IndexOf(substr, index)) != -1)
            {
                count++;
                index += substr.Length;
            }
            return count;
        }

    }
}
