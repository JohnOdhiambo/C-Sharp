using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Customers
    {

        private int GetCustomerID(int customerID)
        {
            int customerID = 200300;
            return customerID;
        }
        private string GetCustomerName(string customerName)
        {
            string customerName = "PVC Water Suppliers";
            return customerName;
        }
        private string GetCustomerContact(string mobile)
        {
            string mobile = "+254710240890";
            return mobile;
        }
        public static void Main(string[] args)
        {
            Customers customers = new Department(); // Creating a class Object  
            int rslt = customers.GetCustomerID(customerID); //Calling the method
            Console.WriteLine("ID of the given customer is  " + rslt); //Printing the result

            string ans = customers.GetCustomerName(customerName);
            Console.WriteLine("Name of the given customer is  " + ans); //Printing the result

            string output = customers.GetCustomerContact(mobile);
            Console.WriteLine("Contact of the given customer is  " + ans); //Printing the result
        }
    }
}
