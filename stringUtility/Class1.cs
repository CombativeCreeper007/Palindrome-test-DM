using System;

 

namespace stringUtility

{

    public class StringLibrary

    {
        //First part, determines if the user string starts with an uppercase letter
        public bool StartsWithUpper(String str)

        {
        //Basically checks if the string is empty
            if (String.IsNullOrWhiteSpace(str))

                return false;

 

            Char ch = str[0];
            
            return Char.IsUpper(ch);

        }


        //Second part, checks if the string is a Palindrome
        public bool IsStringPalindrome(string str)

        {

            string revs = "";
            //Reverses the string the user types
            for (int i = str.Length - 1; i >= 0; i--) 
            {

                revs += str[i].ToString();

            }

            //Checks whether string is palindrome or not, returns true only if it explicitly detects the string is palindrome, everything else is false
            if (revs == str) 

            {

                return true;

            }

            else

            {

                return false;

            }

        }

    }

 

}