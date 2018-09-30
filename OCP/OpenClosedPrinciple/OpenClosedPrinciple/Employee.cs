using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {
            throw new NotImplementedException();
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
