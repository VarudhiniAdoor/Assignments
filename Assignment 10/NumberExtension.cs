using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal static class NumberExtension
    {
        public static string DisplayEven(this int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
                if (Operation.IsEven(i))
                    sb.Append(i + " ");
           return sb.ToString();
        }

        public static string DisplayOdd(this int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
                if (Operation.IsOdd(i))
                    sb.Append(i + " ");
            return sb.ToString();
        }

        public static string DisplayPrimes(this int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
                if (Operation.IsPrime(i))
                    sb.Append(i + " ");
            return sb.ToString();
        }

        public static string DisplayTable(this int number)
        {
            StringBuilder sb = new StringBuilder();
           for (int i = 1; i <= 10; i++)
                sb.AppendLine($"{number} x {i} = {number * i}");
           return sb.ToString();
        }

        public static string DisplayTables1To10(this int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                sb.AppendLine($"\nTable for {i}:");
                sb.AppendLine(i.DisplayTable());
            }
            return sb.ToString();
        }

        public static string DisplayTablesInRange(this int tableStart, int tableEnd, int rangeStart, int rangeEnd)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                Console.WriteLine($"\nTable for {i}:");
                for (int j = tableStart; j <= tableEnd; j++)
                    sb.AppendLine($"{i} x {j} = {i * j}");
            }
            return sb.ToString();   
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
