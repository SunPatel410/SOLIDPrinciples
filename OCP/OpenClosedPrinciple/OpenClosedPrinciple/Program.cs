using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var empJohn = new PermanentEmployee{Id = 1, Name = "John"};
            var empChris = new PermanentEmployee {Id = 2, Name = "Chris"};

            Console.WriteLine($"Employee {empJohn}, Bonus{empJohn.CalculateBonus(10000)}");

            Console.WriteLine($"Employee {empChris}, Bonus{empChris.CalculateBonus(150000)}");

            Console.ReadLine();
        }
    }
}
