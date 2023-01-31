using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class SubContractors
    {

        private int GetSquare(int nmbr)
        {
            int sq = nmbr * nmbr;
            // Lets provide a return statement  
            return sq;
        }
        private string GetSubContractorName(string name)
        {
            string name = "James";
            return name;
        }
        private string GetContactDetails(string mobile)
        {
            string mobile = "+2547203004056";
            return mobile;
        }
        public static void Main(string[] args)
        {
            SubContractors sc = new SubContractors(); // Creating a class Object  
            int rslt = sc.GetSquare(2); //Calling the method and assigning the value to an integer type
            Console.WriteLine("Square of the given number is  " + rslt); //Printing the result

            string ans = sc.GetSubContractorName(name);
            Console.WriteLine("Name of the given number is  " + ans); //Printing the result

            string output = sc.GetContactDetails(mobile);
            Console.WriteLine("Contact of the given subcontractor is  " + ans); //Printing the result
        }
    }
}
