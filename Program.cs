using System;
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
        // public string Name;
        // public int Department;
        // public int Salary;
        // public int MonthlySalary;
        public string Name
        {
            get; set; //get: I can fetch or access the property. set: I can change the property.
        }
        public int Department
        {
            get; set;
        }
        public int Salary
        {
            get; set;
        }
        //commented out as we have made this into a method since it is more like a behavior
        //so we create the method inside of the class Employee
        // public int MonthlySalary
        // {
        //     get; set;
        // }
        //using the prop shortcut. investigate other prop shortcuts
        public string IsPartTime { get; set; }
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        public double FavoriteNumber { get; set; }
        //The Properties of a class is the state that is keeping track of.   
        // // This is a *special* method known as a "constructor"
        // // The constructor is called when we write a line like: `var bob = new Employee(`
        // // The arguments to the method should line up to those below
        // //
        // //              This will become the employee's name
        // //              |               This will become the employee's department
        // //              |               |                  This will become the employee's salary
        // //              |               |                  |              This will become the employee's monthly salary
        // //              |               |                  |              |
        // //              v               v                  v              v
        // public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
        // {
        //     //there are other definitions for properties,whether they are public, private or protected.
        //     //Properties can be accessed by code outside the class when properties are public.
        //     //Private properties can only be seen from other code within the class itself. 
        //     //Private properties...
        //     //we cant use var style definition in the constructor since we must tell the code what type of information this property stores.
        //     //Properties by convention are named camelCase.
        //     // In the constructor we should setup the values for any of the properties.
        //     // Here we will *copy* the values given by the arguments to the corresponding property.
        //     //- Property  Value
        //     //|       |
        //     //v       v
        //     Name = newName;
        //     Department = newDepartment;
        //     Salary = newSalary;
        //     MonthlySalary = newMonthlySalary;
        // }
        //once we have instances of an object we can create a method inside the class
        //refactor MonthlySalary
        public int MonthlySalary()
        {
            //I do not need to pass in the salary within the method because I am inside the Employee class
            int computerMonthlySalary = Salary / 12; //not longer a property but a behavior
            //we need to consider the questions: do we need input? External data or data that the class is already has?
            // classes and object. the behaviors are shared. the data is individual. every employee will have a monthlySalary method
            //but if we ask inside of that method for instance data, is whatever that object's property is.
            //the data and state is unique.
            return computerMonthlySalary;
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
        static void Main(string[] args)
        {
            //another way of creating object with the constructor commented out bellow:
            //very similar to our List, for example: var scores = new List<int>() { 42, 36, 36, 77 };
            var graceHopper = new Employee()
            {
                //the order does not matter and I do not have to provide all the properties.
                //I can provide the properties I want
                Name = "Grace Hopper",
                Department = 100,
                Salary = 240_000,
                // MonthlySalary = 20_000
            };//using an initializer which is much like our List data structure.
            //now lets look at an initializer inside an initializer
            // var employees = new List<Employee>()
            // {
            //     new Employee(){
            //     Name = "Gavin Stark",
            //     },
            //     new Employee(){
            //         Name = "Mila Scardigno"
            //     },
            //     new Employee(){}//for a default value. If I do not add the braces, this will be a new empty Employee without a Name
            // };
            //braces free creation of a  new object
            var elonMusk = new Employee();
            elonMusk.Name = "Elon Musk";
            var gavin = new Employee();
            gavin.Name = "Gavin Stark";
            //calling the a method on these three different Employee objects 
            gavin.MonthlySalary();
            elonMusk.MonthlySalary();
            graceHopper.MonthlySalary();

            // graceHopper.Name = "Grace Hopper";
            // graceHopper.Department = 100;
            //braces using creation of a new object and initializes the object
            //
            //just like var scores = new List<int>(){1,2,3,4,5,6};
            //
            //creates a new list and puts a few numbers in it.
            var grace = new Employee()
            {
                Name = "Grace Hopper"
            };
            //Braces initialization of a list containing three employees
            var employees = new List<Employee>()
            {
                gavin, elonMusk, graceHopper
            };

            // var employeeNoBraces = new List<Employee>();
            // employeeNoBraces.Add(gavin);
            // employeeNoBraces.Add(elonMusk);
            // employeeNoBraces.Add(grace);

            //all in one
            //complex syntax to make a new list and three employees all at once
            var allInOne = new List<Employee>()
            {
new Employee(){
    Name = "Elon Musk"
},
new Employee(){
    Name = "Grace Hoppper"
},
new Employee(){
    Name = "Gavin stark"
}
            };
            //commented code with the other way of creating objects
            // var graceHopper = new Employee("Grace Hopper", 100, 240_000, 20_000); // an Employee object
            // Console.WriteLine(graceHopper.Department);
            // var elonMusk = new Employee("Elon Musk", 42, 120_000, 10_000);
            // Console.WriteLine(elonMusk.Department);
            // // elonMusk.Department = 55; if I want to be able to change Elon's Department Number.

            // // var employees = new List<Employee>();
            // var employees = new List<Employee>() {
            //     graceHopper,
            //     elonMusk,
            //     new Employee("Gavin Stark", 42, 12_000, 100_000)
            //     };// constructing an object in Åline with adding new objects
            // // employees.Add(graceHopper);// first object in the list Index 0
            // // employees.Add(elonMusk);// second object in the list Index 1
            // employees.RemoveAt(0);
            // //better ways to creating objects
            // //shortcut to making classes with getters and setters
            // //defaults

            DisplayGreeting();
            var employeeList = new List<Employee>();

            bool keepGoing = true;
            while (keepGoing)
            {
                //Loosely collect variable with info on a new employee
                Console.WriteLine($"-------You have {employeeList.Count} employees.-------");
                Console.WriteLine();
                string name = PromptForString("What is your name? ");
                int department = PromptForInteger("What is your department number? ");
                int salary = PromptForInteger("What is your yearly salary (in dollar)?");
                // var monthlySalary = salary / 12.0;//if using a method, use a double
                // int monthlySalary = ComputeMonthlySalary(salary);
                // Console.WriteLine($"Hello, {name}, you make 💲{monthlySalary}💰 dollars per month.");
                string isPartTime = PromptForString("Is this employee part time?. Y/N");

                // making a new Employee with simpler syntax and fill in their detail for the variable above
                var newEmployee = new Employee();
                newEmployee.Name = name;
                newEmployee.Salary = salary;
                System.Console.WriteLine($"By the way, their monthly salary is: {newEmployee.MonthlySalary()}");
                newEmployee.Department = department;
                newEmployee.IsPartTime = isPartTime;
                employeeList.Add(newEmployee);//slap that employee a the end of our list
                                              //maybe we can put a loop around this code
                                              //what happens if an employer doubles the employees salaries?
                                              // it now sounds like monthlySalary is more like a behavior; therefore we make it a method
                                              //every time you are calling a method on a class, you have to provide which instance.


                var answer = PromptForString("Keep going?");
                if (answer == "no".ToLower() || answer == "n".ToLower())
                {
                    keepGoing = false;
                }
                // another way to do it but the if statement with the condition is fine
                // if (string.Equals(answer, "no", StringComparison.OrdinalIgnoreCase))
                // {
                //     keepGoing = false;
                // }
            }

        }
    }
}
