namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new OnContractEmployee(1, "Alice", "Bob", new DateOnly(2023, 1, 1), new DateOnly(2024, 1, 1), 5000),
                new OnPartollEmployees(2, "Charlie", "David", new DateOnly(2022, 5, 15), 8, 30000)
            };
            string choice;

            Employee employee;
            do
            {
                Console.WriteLine("\n1. Add OnContract Employee");
                Console.WriteLine("2. Add OnPayroll Employee");
                Console.Write("Enter your choice: ");
                int option = int.Parse(Console.ReadLine());

                Employee emp;

                if (option == 1)
                {
                    emp = new OnContractEmployee();
                }
                else
                {
                    emp = new OnPartollEmployees();
                }
                emp.GetDetails();
                employees.Add(emp);

                Console.Write("\nDo you want to add another employee? (yes/no): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");
          Console.WriteLine("\nEmployee Details:");
            foreach (var emp in employees)
            {
                emp.Display();
            }
            Console.WriteLine($"Total number of employees are {employees.Count}");
        }
    }
}
