using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class NormalizeString
    {
        public string normalizeString(String input)
        {
            //Before normalizing 
            //var lowercased = input.ToLower();
            //var trimmed = lowercased.Trim();
            //return trimmed.Replace(",", "");

            //After normalizing to one statement
            return input.ToLower().Trim().Replace(",", "");
        }
        public void ParseContents(string s)
        {
            Console.WriteLine("Option 1");

            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
            //Access to the characters location as well as the character itself
            Console.WriteLine("Option 2");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }
        //Find if a character exists at an even index within a string
        static Boolean IsAtEvenIndex(string s, char item)
        {
            //Check if string is empty or nullk
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            //Check only the even index to cut time complexity by half
            for (int i = 0; i < s.Length / 2 + 1; i = i + 2)
            {
                //check if character matches the item
                if (s[i] == item)
                {
                    return true;
                }
            }
            //if looped and not found return false
            return false;
        }
        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            //Converts string to character array
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            //Convert character array back to string
            return new String(arr);

        }
        static String ReverseEachWord(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            StringBuilder result = new StringBuilder();
            String[] arr = input.Split();
            for(int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                //Append all except the last one word
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }
                
            }

            return result.ToString();
        }
        static void ReversePlace(int[] input)
        {
            for(int i = 0; i < input.Length /2; i++)
            {
                //swap the item at index(i) with item at index(input.Length -i -1
                int temp = input[i];//Saving item at index i before carrying out the assignment
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;//assign the item at smaller index to the larger index

            }
        }
        //static void Main(string[] args)
        //{
        //    //    String input = "HeLLo";
        //    //    Console.WriteLine(IsAtEvenIndex(input, 'l'));
        //    //    Console.WriteLine(IsAtEvenIndex(input, 'L'));
        //    //    Console.WriteLine(IsAtEvenIndex(input, 'T'));
        //    //    Console.WriteLine(IsAtEvenIndex("", 'H'));
        //    //    Console.WriteLine(IsAtEvenIndex(null, 'L'));

        //    //    //Reverse each word
        //    //    Console.WriteLine("Reverse each word");
        //    //    Console.WriteLine(Reverse("Hello World"));
        //    //    Console.WriteLine(Reverse("Hello"));
        //    //    Console.WriteLine(Reverse("tacos"));
        //    //    Console.WriteLine(Reverse(null));

        //    //    //Reverse each word in a sentence
        //    //    Console.WriteLine("Reverse each word in a sentence");
        //    //    Console.WriteLine(ReverseEachWord("Jay is a world class footballer"));
        //    //    Console.WriteLine(ReverseEachWord(null));
        //    //    Console.WriteLine(ReverseEachWord("Racer Racer Madam"));
        //    //    Console.WriteLine(ReverseEachWord("what are preparing for today"));
        //    int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    Console.WriteLine("Reversed Array");
        //    ReversePlace(arr);
        //    ReversePlace(arr);//Reverse of the reverse array
        //    Array.ForEach(arr, Console.WriteLine);
        //}
    }
}
