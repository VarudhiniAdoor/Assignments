using System;
using System.Collections.Generic;

namespace Assignment3
{
    public class Product
    {
        private readonly string pcode;
        private string pname;
        private int qtyInStock;
        private int discountAllowed;
        private static string brand = "CGI";

        private static List<Product> productList = new List<Product>();


        public Product(string pcode, string pname, int qty, int discount)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.qtyInStock = qty;
            this.discountAllowed = discount;
        }


        public static void AddProduct()
        {

            Console.Write("Enter Product Code: ");
            string pcode = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            string pname = Console.ReadLine();

            Console.Write("Enter Quantity in Stock: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Discount Allowed (%): ");
            int discount = int.Parse(Console.ReadLine());

            Product p = new Product(pcode, pname, qty, discount);
            productList.Add(p);

            Console.WriteLine("Product Added Successfully!\n");
        }


        public static void DisplayProducts()
        {
            Console.WriteLine("\n--- Product List ---");
            Console.WriteLine($"Brand: {brand}"); //brand

            foreach (var p in productList)
            {
                Console.WriteLine($"Code: {p.pcode}, Name: {p.pname}, Stock: {p.qtyInStock}, Discount: {p.discountAllowed}%");
            }
        }

        public static void OrderProduct()
        {

            Console.Write("\nEnter Product Name to Purchase: ");
            string searchName = Console.ReadLine();

            Product found = null;

            foreach (var p in productList)
            {
                if (p.pname.Equals(searchName))
                {
                    found = p;
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Product Not Found.");
                return;
            }

            Console.WriteLine($"Available Stock: {found.qtyInStock}");
            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            if (qty > found.qtyInStock)
            {
                Console.WriteLine("Insufficient Stock.");
                return;
            }

            double pricePerUnit = 100;  //is it right to imagine our own price amount? How else are we supposed to calculate discount?
            double total = pricePerUnit * qty;
            double discount = total * 0.5;
            double payable = total - discount;

            Console.WriteLine("\n--- BILL ---");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Product: {found.pname}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Original Price: ₹{total}");
            Console.WriteLine($"Discount: ₹{discount} as today is 26th Jan, Company wants to give a discount of 50% on all the products");
            Console.WriteLine($"Final Amount: ₹{payable}");
        }
    }
}
