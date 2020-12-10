using System;
 
namespace ConsoleApplication1
{
    class Program
    {
        public static stringUtility.StringLibrary clsString = new stringUtility.StringLibrary();
 
        static void Main(string[] args)
        {
            //When the program starts, all that happens in the main method is it runs the ChooseOption method, which prompts the user to choose 1 or 2 (choices are on the terminal)
            ChooseOption();
        }
         
        static string ChooseString()
        {
            //ChooseString gets the user to type in something and returns what the user types
            Console.Clear();
            Console.WriteLine("\nType anything \n");
            return Console.ReadLine();
        }
 
        static void ChooseOption()
        {
            //ChooseOption stays under ChooseString to ensure there is an output for what the user typed
            //ChooseOption sets a variable called end to false then runs a while loop until an event triggers end to true
            string choice = ChooseString();
            bool end = false;
            while (!end)
            {
                //Clears the console from annoying lines and creates a menu that the user can respond to by typing 1 or 2 then reads the user input
                Console.Clear();
                Console.WriteLine("\nWould you like to check if \n\"" + choice + "\" is:\n\n1) Starts With a Uppercase\n\n2) Palindrome");
                switch (Console.ReadLine())
                {
                    //Case Uppercase: ends the while loop, clears the console, writes a message if the message is uppercase and a different one if it detects anything else, such as a number
                    case "1":
                        end = true;
                        Console.Clear();
                        if (clsString.StartsWithUpper(choice)) Console.WriteLine("It does start with a Uppercase");
                        else Console.WriteLine("It does not start with a Uppercase");
                        Exit();
                        break;
 
                    //Case Palindrome: ends the while loop, clears the console, in the other file Josh helped me to reverse the user input and it does a check if the reversed input is the same as the original, then says it is or says it isnt if it detects anything else
                    case "2":
                        end = true;
                        Console.Clear();
                        if (clsString.IsStringPalindrome(choice)) Console.WriteLine("It is palindrome\n");
                        else Console.WriteLine("It is not palindrome\n");
                        //Calls the exit function
                        Exit();
                        break;
                }
            }
        }
        static void Exit()
        {
            //Variable named exit is set to false, followed by a while exit isn't true FOR loop
            bool exit = false;
            while (!exit)
            {
                //Again prompts the user with a message, and checks if the user types 1 or 2
                Console.WriteLine("\nWould you like to: \n\n1) Exit\n\n2) Start again with a new choice\n");
                switch (Console.ReadLine())
                {
                    //If the user types 1, exit the environment
                    case "1":
                        exit = true;
                        Environment.Exit(0);
                        break;
                    //if the user types 2, run ChooseOption which clears the console and runs the function all over again
                    case "2":
                        exit = true;
                        ChooseOption();
                        break;
                    default:
                    //Clears it on default, I don't know what else to put here
                    Console.Clear();
                    break;
                }
            }
 
        }
    }
}
//END