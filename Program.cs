using System;

namespace EmployeeDatabase
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻");
            Console.WriteLine("  \ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70\ud83e\udd70");
            Console.WriteLine("  Welcome to Our Employee Database");
            System.Console.WriteLine("🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻");
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
        static int PromptForInteger(string prompt)
        {
            System.Console.WriteLine(prompt);
            var userInput = Console.ReadLine();
            var userInputAsInteger = int.Parse(userInput);//extra step compared with PromptForString()
            return userInputAsInteger;
        }
        static void Main(string[] args)
        {
            DisplayGreeting();
            var name = PromptForString("What is your name? ");
            var department = PromptForInteger("What is your department number? ");
            var salary = PromptForInteger("What is your yearly salary (in dollar)?");
            var salaryPerMonth = salary / 12;
            Console.WriteLine($"Hello, {name}, you make 💲{salaryPerMonth}💰 dollars per month.");
        }
    }
}
