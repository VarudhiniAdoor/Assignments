using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");

                Console.Write("Enter Choice: ");
                int role = int.Parse(Console.ReadLine());

                if (role == 1)
                {
                    Console.WriteLine("1. Add Product");
                    Console.WriteLine("2. Display Products");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                        Product.AddProduct();
                    else if (choice == 2)
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
