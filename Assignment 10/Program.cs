namespace Assignment_10
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
