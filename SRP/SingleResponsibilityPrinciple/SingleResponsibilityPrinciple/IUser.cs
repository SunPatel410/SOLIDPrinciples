using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
}
