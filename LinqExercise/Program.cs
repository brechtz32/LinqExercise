using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var mySumOfNumbers = numbers.Sum();
            Console.WriteLine($"Sum: {mySumOfNumbers}");
            /*foreach (var x in mySumOfNumbers)
            {
                Console.WriteLine(x);
            }*/
            Console.WriteLine("------------------------");

            //TODO: Print the Average of numbers
            var myAverageOfNumbers = numbers.Average();
            Console.WriteLine($"Average: {myAverageOfNumbers}");
            Console.WriteLine("------------------------");

            //TODO: Order numbers in ascending order and print to the console
            var myAscendingNumbers = numbers.OrderBy(x => x);
            Console.WriteLine("Ascending");
            foreach (var x in myAscendingNumbers)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------");

            //TODO: Order numbers in descending order and print to the console
            var myDescendingNumbers = numbers.OrderByDescending(y => y);
            Console.WriteLine("Descending");
            foreach (var y in myDescendingNumbers)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------");

            //TODO: Print to the console only the numbers greater than 6
            var numberGreaterThanSix = numbers.Where(z => z > 6);
            foreach (var z in numberGreaterThanSix)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine("------------------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var printFourNumbers = numbers.OrderBy(t => t);
            foreach (var t in printFourNumbers.Take(4))
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("------------------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 28;
            var changeIndexNumber = numbers.OrderByDescending(r => r);
            foreach (var r in changeIndexNumber)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("                        ");
            Console.WriteLine("************************");
            Console.WriteLine("                        ");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var nameStartsWithCS = employees.Where(name => name.FirstName.StartsWith("C") || name.FirstName.StartsWith("S")).OrderBy(name => name.FirstName);            
            foreach (var ee in nameStartsWithCS)
            {
                Console.WriteLine($"{ee.FullName}");
            }
            Console.WriteLine("------------------------");
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var ageOverTwentySix = employees.Where(eeage => eeage.Age > 26).OrderBy(eeage => eeage.Age).ThenBy(eeage => eeage.FirstName);
            foreach (var employeeAge in ageOverTwentySix)
            {
                Console.WriteLine($"Name: {employeeAge.FullName}   Employee's Age: {employeeAge.Age}");
            }
            Console.WriteLine("------------------------");

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
                        
            var sumOfYOE = employees.Where(eeyoe => eeyoe.YearsOfExperience <= 10 && eeyoe.Age > 35);
            var theSum = sumOfYOE.Sum(emp => emp.YearsOfExperience);
            Console.WriteLine($"Sum: {theSum}");
                
            Console.WriteLine("------------------------");

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var averageOfYOE = employees.Where(avgyoe => avgyoe.YearsOfExperience <= 10 && avgyoe.Age > 35);
            var theAvg = averageOfYOE.Average(theEE => theEE.YearsOfExperience);
            Console.WriteLine($"Average: {theAvg}");
            Console.WriteLine("------------------------");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Charlie", "Edward", 32, 16)).ToList();
            foreach (var addedEmployee in employees)
            {
                Console.WriteLine($"Name: {addedEmployee.FullName}   Age: {addedEmployee.Age}   Yoe: {addedEmployee.YearsOfExperience}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
