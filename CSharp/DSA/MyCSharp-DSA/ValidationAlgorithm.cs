using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
   public class ValidationAlgorithm
    {
        static Boolean startWith(string s)
        {
            return s.StartsWith("k");
        }
        //Validate password
        static Boolean ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
                foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCaseLetter = true;
                else if (char.IsLower(c)) hasLowerCaseLetter = true;
                else if (char.IsDigit(c)) hasDecimalDigit = true;
            }

            bool isValid = meetsLengthRequirements
             && hasUpperCaseLetter
             && hasLowerCaseLetter
             && hasDecimalDigit
             ;
            return isValid;
        }

        //static void Main(string [] args)
        //{
        //    Console.WriteLine(startWith("kamwana"));

        //    Console.WriteLine(ValidatePassword("Jaymantra1"));
            
        //    //Find maximum number
        //    BasicAlgorithm bs = new BasicAlgorithm();
        //    Console.WriteLine(bs.findMaximum2( 20, 4, 13));

        //    //Normalize string in one statement
        //    NormalizeString ns = new NormalizeString();
        //    Console.WriteLine(ns.normalizeString("Hello User, it's JAYJAY    "));
        //    //Search for elements in a string
        //    ns.ParseContents("Hello World");
        //}
    }
}
