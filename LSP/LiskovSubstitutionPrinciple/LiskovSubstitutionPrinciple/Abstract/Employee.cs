using System;
using LiskovSubstitutionPrinciple.Interface;

namespace LiskovSubstitutionPrinciple.Abstract
{
    public abstract class Employee: IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {
            
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;

        }

        public abstract decimal CalculateBonus(decimal salary);
        public abstract decimal GetMinimumSalary();

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
