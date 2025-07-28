using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib11
{
    public class NumericFunctions
    {
        public  int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }
        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;

        public static float Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (float)a / b;
        }
        public static int FindMax(params int[] numbers) => numbers.Length == 0 ? 0 : Math.Max(numbers[0], FindMax(numbers[1..]));

        public static int FindMin(params int[] numbers) => numbers.Length == 0 ? 0 : Math.Min(numbers[0], FindMin(numbers[1..]));

        public static bool IsEven(int num) => num % 2 == 0;

        public static bool IsOdd(int num) => num % 2 != 0;

        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        // 10. Display all even numbers in range
        public static List<int> GetEvenInRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
                if (IsEven(i)) result.Add(i);
            return result;
        }

        public static List<int> GetOddInRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
                if (IsOdd(i)) result.Add(i);
            return result;
        }

        public static List<int> GetPrimeInRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
                if (IsPrime(i)) result.Add(i);
            return result;
        }

        public static List<string> GetTable(int num)
        {
            var result = new List<string>();
            for (int i = 1; i <= 10; i++)
                result.Add($"{num} x {i} = {num * i}");
            return result;
        }

        public static Dictionary<int, List<string>> GetTables1To10InRange(int start, int end)
        {
            var tables = new Dictionary<int, List<string>>();
            for (int num = start; num <= end; num++)
                tables[num] = GetTable(num);
            return tables;
        }
        public static Dictionary<int, List<string>> GetTablesInCustomRange(int fromTable, int toTable, int fromNum, int toNum)
        {
            var result = new Dictionary<int, List<string>>();
            for (int num = fromNum; num <= toNum; num++)
            {
                var table = new List<string>();
                for (int i = fromTable; i <= toTable; i++)
                    table.Add($"{num} x {i} = {num * i}");
                result[num] = table;
            }
            return result;
        }

        public static int ReverseNumber(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return reversed;
        }
    }
}
