using System;
using System.Collections.Generic;
using LiskovSubstitutionPrinciple.Abstract;
using LiskovSubstitutionPrinciple.Implementation;
using LiskovSubstitutionPrinciple.Interface;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        /// <summary>
        /// Liskov Principle
        /// Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
        /// the object of a derived class should be able to replace an object of the base class without bringing any errors in the system or modifying the behavior of the base class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Employee> employees =
                new List<Employee> {new PermanentEmployee(1, "John"), new TempEmployee(2, "Jason")};

            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(
                    $"Employee {employee} Bonus: {employee.CalculateBonus(100000)} MinSalary: {employee.GetMinimumSalary()}");
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TempEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(
                    $"Employee {employee}  MinSalary: {employee.GetMinimumSalary()}");
            }
            Console.ReadLine();
        }
    }
    }

