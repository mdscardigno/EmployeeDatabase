using System;

namespace EmployeeDatabase
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Welcome to Our Employee Database");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            //use the argument, whatever the caller sent us
            System.Console.WriteLine(prompt);
            //get some user input
            var userInput = Console.ReadLine();
            //RETURN that value as the output of this method 
            //the value in the 'userInput' will go wherever the 
            //*CALLER* of the method has specified.
            return userInput;
        }

        static void Main(string[] args)
        {
            DisplayGreeting();
            var name = PromptForString("What is your name? ");
            var department = int.Parse(PromptForString("What is your department number? "));
            var salary = int.Parse(PromptForString("What is your yearly salary (in dollar)?"));
            var salaryPerMonth = salary / 12;
            Console.WriteLine($"Hello, {name}, you make {salaryPerMonth} dollars per month.");
        }
    }
}
