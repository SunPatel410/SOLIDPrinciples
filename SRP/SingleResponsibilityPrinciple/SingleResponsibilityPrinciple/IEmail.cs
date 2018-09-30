using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
