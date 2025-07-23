 
using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Customer Purchase");
                Console.WriteLine("3. Exit");

                Console.Write("Enter Choice: ");
                int role = int.Parse(Console.ReadLine());

                if (role == 1)
                {
                    Product.DisplayProducts();
                }
                else if (role == 2)
                {
                    Product.OrderProduct();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
