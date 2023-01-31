using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Suppliers
    {

        private int GetSupplierID(int supplierID)
        {
            int supplierID = 200300;
            return supplierID;
        }
        private string GetSupplierName(string supplierName)
        {
            string supplierName = "PVC Water Suppliers";
            return supplierName;
        }
        private string GetSupplierContact(string mobile)
        {
            string mobile = "+254710240890";
            return mobile;
        }
        public static void Main(string[] args)
        {
            Suppliers suppliers = new Department(); // Creating a class Object  
            int rslt = suppliers.GetSupplierID(supplierID); //Calling the method
            Console.WriteLine("ID of the given supplier is  " + rslt); //Printing the result

            string ans = suppliers.GetSupplierName(supplierName);
            Console.WriteLine("Name of the given supplier is  " + ans); //Printing the result

            string output = suppliers.GetSupplierContact(mobile);
            Console.WriteLine("Contact of the given supplier is  " + ans); //Printing the result
        }
    }
}
