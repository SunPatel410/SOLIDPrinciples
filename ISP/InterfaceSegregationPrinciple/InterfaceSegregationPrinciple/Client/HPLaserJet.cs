using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Client
{
    public class HPLaserJet : IFaxContent,IPrintDuplex
    {
        public bool FaxContent(string content)
        {

            Console.WriteLine("Fax Done");
            return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Duplex Done");
            return true;
        }
    }
}
