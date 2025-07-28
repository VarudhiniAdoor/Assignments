using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal static class StringExtensions
    {
        public static int CharecterCount(this string str)
        {
            return (str ?? "***").Length;
        }
        public static bool IsPalindrome(this string input)
        {
            input = (input ?? "***").ToLower().Replace(" ", "");
            for (int i = 0; i < input.Length / 2; i++)
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            return true;
        }
        public static string ReverseString(this string str)
        {
            if (str == null) return "***";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray); // Reverse the character array and create a new string
        }
        public static void VowelConsonantDigitSpecial(this string input, out int vowels, out int consonants, out int digits, out int special)
        {
            input = input ?? "***";
            vowels = consonants = digits = special = 0;
            foreach (char c in input)
            {
                if ("aeiouAEIOU".IndexOf(c) != -1)
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
                else if (char.IsDigit(c))
                    digits++;
                else if (!char.IsWhiteSpace(c))
                    special++;
            }
        }
        public static string ToUpperCase(this string input)
        {
            return (input ?? "***").ToUpper();
        }
        public static string ToProperCase(this string input)
        {
            input = input ?? "***";
            string[] words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > 0)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            return string.Join(" ", words);
        }

        public static string Combine(this string input, string other)
        {
            return (input ?? "***") + " " + (other ?? "***");
        }

        public static string RemoveExtraSpaces(this string input)
        {
            input = input ?? "***";
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }

        public static int WordCount(this string input)
        {
            input = input ?? "***";
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ContainsSubstring(this string input, string substring)
        {
            return (input ?? "***").Contains(substring ?? "***");
        }

        public static int CountSubstringOccurrences(this string input, string substring)
        {
            input = input ?? "***";
            substring = substring ?? "***";
            int count = 0;
            int index = 0;
            while ((index = input.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }

    }
}
