using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnPartollEmployees : Employee
    {
         DateOnly JoiningDate;
         int Experience;
         double BasicSalary;
         double DA;
         double HRA;
         double PF;
         double NetSalary;

        public OnPartollEmployees() { }
        public OnPartollEmployees(int uniqueID, string name, string reportingManager, DateOnly JoiningDate,int Experience,double BasicSalary) : base(uniqueID, name, reportingManager)
        {
            this.JoiningDate = JoiningDate;
            this.Experience = Experience;
            this.BasicSalary = BasicSalary;               
        }
        public override void GetDetails()
        {
            base.GetDetails();

            Console.Write("Enter Joining Date (yyyy-mm-dd): ");
            JoiningDate = DateOnly.Parse(Console.ReadLine());

            Console.Write("Enter Experience in years: ");
            Experience = int.Parse(Console.ReadLine());

            Console.Write("Enter Basic Salary: ");
            BasicSalary = double.Parse(Console.ReadLine());

            CalculateSalary();
        }
        private void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = 0.10 * BasicSalary;
                HRA = 0.085 * BasicSalary;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = 0.07 * BasicSalary;
                HRA = 0.065 * BasicSalary;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = 0.041 * BasicSalary;
                HRA = 0.038 * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019 * BasicSalary;
                HRA = 0.02 * BasicSalary;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Joining Date: {JoiningDate}, Experience: {Experience} years, Basic Salary: {BasicSalary}, DA: {DA}, HRA: {HRA}, PF: {PF}, Net Salary: {NetSalary}");
        }
    }
}
