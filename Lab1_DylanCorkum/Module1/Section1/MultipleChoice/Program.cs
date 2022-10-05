using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("What is your favourite colour?");
            var colour = Console.ReadLine();

            Console.WriteLine("What is your favourite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Your name is: {0}.", name);
            Console.WriteLine("Your age is: {0}.", age);
            Console.WriteLine("Your birth month is: {0}.", month);
            Console.WriteLine("Your favourite colour is: {0}.", colour);
            Console.WriteLine("Your favourite animal is: {0}.", animal);
        }
    }
}