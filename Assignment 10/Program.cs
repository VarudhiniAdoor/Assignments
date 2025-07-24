namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sum: " + Operation.Sum(1, 2, null, 4));
                Console.WriteLine("Product: " + Operation.Product(1, null, 3));
                Console.WriteLine("Min: " + Operation.Min(100, null, 1, 20));
                Console.WriteLine("Max: " + Operation.Max(100, null, 1, 20));
                Console.WriteLine("Is 17 Prime? " + Operation.IsPrime(17));

                int start = 1, end = 10;
                start.DisplayEven(end);
                start.DisplayOdd(end);
                start.DisplayPrimes(end);
                5.DisplayTable();
                start.DisplayTables1To10(end);
                1.DisplayTablesInRange( 7, 2, 4);
                Console.WriteLine("Reverse of 12345: " + 12345.ReverseNumber());

                string sentence = "Madam In Eden Im Adam";
                Console.WriteLine(sentence);
                Console.WriteLine("Is Palindrome? " + sentence.IsPalindrome());
                Console.WriteLine("Reversed: " + sentence.ReverseString());
                Console.WriteLine("Character Count: " + sentence.CharecterCount());

                sentence.VowelConsonantDigitSpecial(out int v, out int c, out int d, out int s);
                Console.WriteLine($"Vowels: {v}, Consonants: {c}, Digits: {d}, Special: {s}");

                Console.WriteLine("Upper Case: " + sentence.ToUpperCase());
                Console.WriteLine("Proper Case: " + sentence.ToProperCase());
                Console.WriteLine("Combined: " + sentence.Combine("Another Sentence"));
                Console.WriteLine("Removed Spaces: " + "   This   is   a test   ".RemoveExtraSpaces());
                Console.WriteLine("Word Count: " + sentence.WordCount());
                Console.WriteLine("Contains 'Eden'? " + sentence.ContainsSubstring("Eden"));
                Console.WriteLine("Occurrences of 'a': " + sentence.CountSubstringOccurrences("a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
