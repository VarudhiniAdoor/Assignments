using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Admission Eligibility Checker");
        Console.WriteLine("2. Electricity Bill Calculator");
   
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("\n--- Admission Eligibility Checker ---");
                Console.Write("Enter marks in Physics: ");
                int phy = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter marks in Chemistry: ");
                int chem = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter marks in Mathematics: ");
                int math = Convert.ToInt16(Console.ReadLine());

                int total = phy + chem + math;
                int mathPhyTotal = math + phy;

                if (math >= 65 && phy >= 55 && chem >= 50)
                {
                    if (total >= 180 || mathPhyTotal >= 140)
                        Console.WriteLine("The candidate is eligible for admission.");
                    else
                        Console.WriteLine("Not eligible");
                }
                else
                {
                    Console.WriteLine("Not eligible");
                }
                break;


            case 2:
                
                Console.WriteLine("\n--- Electricity Bill Calculator ---");
                Console.Write("Enter Customer ID: ");
                int customerId = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Units Consumed: ");
                int units = Convert.ToInt16(Console.ReadLine());

                double rate = 0.0;

                if (units < 200)
                    rate = 1.20;
                else if (units >= 200 && units < 400)
                    rate = 1.50;
                else if (units >= 400 && units < 600)
                    rate = 1.80;
                else
                    rate = 2.00;

                double Amount = units * rate;
                double surcharge = (Amount > 400) ? Amount * 0.15 : 0;
                double netAmount = Amount + surcharge;

                if (netAmount < 100)
                    netAmount = 100;

                Console.WriteLine($"\nCustomer IDNO : {customerId}");
                Console.WriteLine($"Customer Name : {name}");
                Console.WriteLine($"Unit Consumed : {units}");
                Console.WriteLine($"Amount Charges @Rs. {rate} per unit : {Amount}");
                Console.WriteLine($"Surcharge Amount : {surcharge}");
                Console.WriteLine($"Net Amount Paid By the Customer : {netAmount}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
