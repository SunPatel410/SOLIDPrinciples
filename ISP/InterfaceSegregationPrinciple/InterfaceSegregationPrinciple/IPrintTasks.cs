using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// by having everthing in one class it will be a stuggle to 
    /// maintain the application and when creating a new class that 
    /// extends this interface, then you have to implement every method,
    /// thus code duplication. By seperating every function into 
    /// other interfaces, it be easier to maintain and grow the app. 
    /// </summary>
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}
