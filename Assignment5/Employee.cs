using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Employee
    {
        int uniqueID;
        string name;
        string reportingManager;

        public Employee() { }
        public Employee(int uniqueID, string name, string reportingManager)
        {
            this.uniqueID = uniqueID;
            this.name = name;
            this.reportingManager = reportingManager;
        }
        virtual public void GetDetails()
        {
            Console.WriteLine("enter Unique ID");
            uniqueID = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter Reporting Manager");
            reportingManager = Console.ReadLine();
        }
        virtual public void Display()
        {
            Console.WriteLine($"Employee ID: {uniqueID}, Name: {name}, Reporting Manager: {reportingManager}");
        }

    }
}
