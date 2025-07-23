using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Assignment_10
{
    internal class Operation
    {

        public static int Sum(params int?[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num ?? 10;
            }
            return sum;
        }
        public int Subtract(params int?[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("No numbers provided for subtraction.");
                return 0;
            }
            int result = numbers[0] ?? 10;
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i] ?? 10;
            }
            return result;
        }
        public static int Product(params int?[] numbers)
        {
            int product = 1;
            foreach (var num in numbers)
            {
                product *= num ?? 10;
            }
            return product;
        }

        public static int Min(params int?[] numbers)
        {
            int min = 0;
            foreach (var num in numbers)
            {
                min = Math.Min(min, num ?? 10);
            }
            return min;
        }

        public static int Max(params int?[] numbers)
        {
            int max = 0;
            foreach (var num in numbers)
            {
                max = Math.Max(max, num ?? 10);
            }
            return max;
        }
        public static bool IsEven(int? number)
        {
            return (number ?? 10) % 2 == 0;
        }
        public static bool IsOdd(int? number)
        {
            return (number ?? 10) % 2 != 0;
        }
        public static bool IsPrime(int? number)
        {
            int num = number ?? 10;
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
    }
