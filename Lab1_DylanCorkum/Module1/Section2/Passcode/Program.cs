using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var correctCode = "Password1";

            Console.WriteLine("What is the passcode?");
            var code = Console.ReadLine();

            if (code == correctCode)
            {
                Console.WriteLine("Access Granted.");
                Console.WriteLine("Would you like to change the passcode? (Y/N)");
                var answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Please enter new passcode.");
                    correctCode = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Passcode was not changed.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Password. Access Denied.");
            }

            
            
        }
    }
}