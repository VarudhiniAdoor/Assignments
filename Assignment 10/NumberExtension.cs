using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    internal static class NumberExtension
    {
        public static void DisplayEven(this int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (Operation.IsEven(i))
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayOdd(this int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (Operation.IsOdd(i))
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayPrimes(this int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (Operation.IsPrime(i))
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayTable(this int number)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");
        }

        public static void DisplayTables1To10(this int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"\nTable for {i}:");
                i.DisplayTable();
            }
        }

        public static void DisplayTablesInRange(this int tableStart, int tableEnd, int rangeStart, int rangeEnd)
        {
            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                Console.WriteLine($"\nTable for {i}:");
                for (int j = tableStart; j <= tableEnd; j++)
                    Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }

        public static int ReverseNumber(this int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }
    }
}
