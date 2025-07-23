using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Product
    {
        private readonly string pcode;
        private string pname;
        private int qtyInStock;
        private int discountAllowed;
        private static string brand = "CGI";

        private static List<Product> productList = new List<Product>()
        {
            new Product("P001", "Laptop", 10, 5),
            new Product("P002", "Mouse", 50, 10),
            new Product("P003", "Keyboard", 30, 8),
            new Product("P004", "Monitor", 20, 12),
            new Product("P005", "Printer", 15, 7)
        };

        public Product(string pcode, string pname, int qty, int discount)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.qtyInStock = qty;
            this.discountAllowed = discount;
        }

        public static void DisplayProducts()
        {
            Console.WriteLine("\n--- Product List ---");
            Console.WriteLine($"Brand: {brand}");

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
                if (p.pname.Equals(searchName, StringComparison.OrdinalIgnoreCase))
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

            double pricePerUnit = 100;  // Assuming price per unit
            double total = pricePerUnit * qty;
            double discount = total * 0.5; 
            double payable = total - discount;

            Console.WriteLine("\n--- BILL ---");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Product: {found.pname}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Original Price: ₹{total}");
            Console.WriteLine($"Discount: ₹{discount} (50% Republic Day Offer)");
            Console.WriteLine($"Final Amount: ₹{payable}");
        }
    }
}
