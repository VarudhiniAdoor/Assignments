using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnContractEmployee : Employee
    {
        DateOnly contractDate;
        DateOnly contractDuration;
        double charges;

        public OnContractEmployee() { }
        public OnContractEmployee(int uniqueID, string name, string reportingManager, DateOnly contractDate, DateOnly contractDuration, int charges) : base ( uniqueID,name,reportingManager)
        {
            this.contractDate = contractDate;
            this.contractDuration = contractDuration;
            this.charges = charges;
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Contract Date (yyyy-mm-dd):");
            contractDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contract Duration (yyyy-mm-dd):");
            contractDuration = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Charges:");
            charges = double.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Contract Date: {contractDate}, Contract Duration: {contractDuration}, Charges: {charges}");
        }
    }
}
