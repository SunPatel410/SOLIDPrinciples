using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Client
{
    public class CannonMg240 : IPrintSegregrated
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {

            Console.WriteLine("Scan Done");
            return true;
        }
        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
