using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Department
    {

        private int GetIdentifier(int departID)
        {
            int departID = 1;
            return departID;
        }
        private string GetName(string departName)
        {
            string departname = "Sales";
            return DepartName;
        }
        private string GetContact(string mobile)
        {
            string mobile = "+254700897200";
            return DepartMobile;
        }
        public static void Main(string[] args)
        {
            Department dp = new Department(); // Creating a class Object  
            int rslt = dp.GetIdentifier(departID); //Calling the method
            Console.WriteLine("ID of the given department is  " + rslt); //Printing the result

            string ans = dp.GetName(DepartName);
            Console.WriteLine("Name of the given department is  " + ans); //Printing the result

            string output = dp.GetContact(DepartMobile);
            Console.WriteLine("Contact of the given department is  " + ans); //Printing the result
        }
    }
}
