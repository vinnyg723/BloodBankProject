using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Employee
    {

        private string _username;
        private string _password;

        public Employee(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUserName()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
