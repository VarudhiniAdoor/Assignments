namespace Assignment11;

class Program
{
    static void Main(string[] args)
    {
        ClassLib11.NumericFunctions numericFunctions = new ClassLib11.NumericFunctions();
        ClassLib11.StringFunctions stringFunctions = new ClassLib11.StringFunctions();

        // Example usage of NumericFunctions
        Console.WriteLine("Numeric Functions:");
        int z = numericFunctions.Add(1, 2, 3, 4, 5);
        Console.WriteLine($"Add: {z}");
        Console.WriteLine($"Subtract: {ClassLib11.NumericFunctions.Subtract(10, 5)}");
        Console.WriteLine($"Multiply: {ClassLib11.NumericFunctions.Multiply(3, 4)}");
        Console.WriteLine($"Divide: {ClassLib11.NumericFunctions.Divide(10, 2)}");
        Console.WriteLine($"Max: {ClassLib11.NumericFunctions.FindMax(1, 2, 3, 4, 5)}");
        Console.WriteLine($"Min: {ClassLib11.NumericFunctions.FindMin(1, 2, 3, 4, 5)}");
        Console.WriteLine($"IsEven(4): {ClassLib11.NumericFunctions.IsEven(4)}");
        Console.WriteLine($"IsOdd(5): {ClassLib11.NumericFunctions.IsOdd(5)}");
        Console.WriteLine($"IsPrime(7): {ClassLib11.NumericFunctions.IsPrime(7)}");
        Console.WriteLine($"Even numbers in range 1-10: {string.Join(", ", ClassLib11.NumericFunctions.GetEvenInRange(1, 10))}");
        Console.WriteLine($"Odd numbers in range 1-10: {string.Join(", ", ClassLib11.NumericFunctions.GetOddInRange(1, 10))}");


        // Example usage of StringFunctions
        Console.WriteLine("String Functions:");
        string input = "Hello World";
        Console.WriteLine($"CountCharacters: {stringFunctions.CountCharacters(input)}");
        Console.WriteLine($"IsPalindrome: {stringFunctions.IsPalindrome(input)}");
        Console.WriteLine($"ReverseSentence: {stringFunctions.ReverseSentence(input)}");
        int vowels, consonants, digits, specials;
        stringFunctions.CountDetails(input, out vowels, out consonants, out digits, out specials);
        Console.WriteLine($"CountDetails - Vowels: {vowels}, Consonants: {consonants}, Digits: {digits}, Specials: {specials}");
        Console.WriteLine($"ToProperCase: {stringFunctions.ToProperCase(input)}");
        Console.WriteLine($"CombineWith: {stringFunctions.CombineWith("Hello", "World")}");
        Console.WriteLine($"RemoveExtraSpaces: {stringFunctions.RemoveExtraSpaces("  Hello   World  ")}");
        Console.WriteLine($"WordCount: {stringFunctions.WordCount(input)}");
        Console.WriteLine($"ContainsSubstring: {stringFunctions.ContainsSubstring(input, "World")}");
        Console.WriteLine($"SubstringOccurrences: {stringFunctions.SubstringOccurrences(input, "o")}");
        
    }
}
