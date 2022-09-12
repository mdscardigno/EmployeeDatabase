﻿using System;
using System.Collections.Generic;

namespace EmployeeDatabase
{
    //
    //Class keyword
    //|
    //|
    //|     Name of classes (PascalCase)
    //|    |
    //|    |
    //v    v
    class Employee
    {
        // public means "this can be seen outside of the class"
        // |
        // |   Type
        // |   |
        // |   |      Name of property
        // |   |      |
        // |   |      |
        // |   |      |
        // v   v      v
        public string Name;
        public int Department;
        public int Salary;
        public int MonthlySalary;
        //The Properties of a class is the state that is keeping track of.   
        // This is a *special* method known as a "constructor"
        // The constructor is called when we write a line like: `var bob = new Employee(`
        // The arguments to the method should line up to those below
        //
        //              This will become the employee's name
        //              |               This will become the employee's department
        //              |               |                  This will become the employee's salary
        //              |               |                  |              This will become the employee's monthly salary
        //              |               |                  |              |
        //              v               v                  v              v
        public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
        {
            //there are other definitions for properties,whether they are public, private or protected.
            //Properties can be accessed by code outside the class when properties are public.
            //Private properties can only be seen from other code within the class itself. 
            //Private properties...
            //we cant use var style definition in the constructor since we must tell the code what type of information this property stores.
            //Properties by convention are named camelCase.
            // In the constructor we should setup the values for any of the properties.
            // Here we will *copy* the values given by the arguments to the corresponding property.
            //- Property  Value
            //|       |
            //v       v
            Name = newName;
            Department = newDepartment;
            Salary = newSalary;
            MonthlySalary = newMonthlySalary;
        }

    }
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
            // System.Console.WriteLine(prompt);
            // var userInput = Console.ReadLine();
            //using int.Parse
            // var userInput = PromptForString(prompt);//we can call a method within another method
            // var userInputAsInteger = int.Parse(userInput);//extra step compared with PromptForString()
            // return userInputAsInteger;
            //using try.Parse
            // System.Console.WriteLine(prompt);
            var userInput = PromptForString(prompt);
            int userInputAsInteger;
            //isThisInputGood will get a boolean
            //var isThisInputGood = int.TryParse(Console.ReadLine(), out userInput); //out argument
            //notice that methods in this language can return one thing. Some languages you can return two things.
            var isThisInputGood = int.TryParse(userInput, out userInputAsInteger); //out argument is a changable variable. it is what comes out of the function.
            if (isThisInputGood)
            {
                return userInputAsInteger;
            }
            else
            {
                System.Console.WriteLine($"Sorry, that is not a valid input. I am using 0 as your answer. ");
                return 0;
            }
        }
        static int ComputeMonthlySalaryFromYearly(int yearlySalary)
        {
            return yearlySalary / 12;
        }
        static void Main(string[] args)
        {

            var graceHopper = new Employee("Grace Hopper", 100, 240_000, 20_000); // an Employee object
            Console.WriteLine(graceHopper.Department);
            var elonMusk = new Employee("Elon Musk", 42, 120_000, 10_000);
            Console.WriteLine(elonMusk.Department);

            // var employees = new List<Employee>();
            var employees = new List<Employee>() { graceHopper, elonMusk, new Employee("Gavin Stark", 42, 12_000, 100_000) };// constructing an object in line with adding new objects
            // employees.Add(graceHopper);// first object in the list Index 0
            // employees.Add(elonMusk);// second object in the list Index 1
            employees.RemoveAt(0);
            DisplayGreeting();
            var name = PromptForString("What is your name? ");
            var department = PromptForInteger("What is your department number? ");
            var salary = PromptForInteger("What is your yearly salary (in dollar)?");
            // var salaryPerMonth = salary / 12.0;//if using a method, use a double
            var salaryPerMonth = ComputeMonthlySalaryFromYearly(salary);
            Console.WriteLine($"Hello, {name}, you make 💲{salaryPerMonth}💰 dollars per month.");
        }
    }
}
