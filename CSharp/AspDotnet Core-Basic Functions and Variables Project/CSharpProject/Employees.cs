using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Employees
    {

        private int GetEmployeeID(int employeeID)
        {
            int employeeID = 40100;
            return employeeID;
        }
        private string GetEmployeeName(string employeeName)
        {
            string employeeName = "Van Dyke";
            return employeeName;
        }
        private string GetEmployeeContact(string mobile)
        {
            string mobile = "+254722300400";
            return mobile;
        }
        public static void Main(string[] args)
        {
            Employees employees = new Employees(); // Creating a class Object  
            int rslt = employees.GetEmployeeID(employeeID); //Calling the method
            Console.WriteLine("ID of the given employee is  " + rslt); //Printing the result

            string ans = employees.GetEmployeeName(employeeName);
            Console.WriteLine("Name of the given employee is  " + ans); //Printing the result

            string output = employees.GetEmployeeContact(mobile);
            Console.WriteLine("Contact of the given employee is  " + ans); //Printing the result
        }
    }
}
