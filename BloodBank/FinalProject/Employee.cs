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
        private string _firstName;
        private string _lastName;
        


        public Employee(string username, string password, string firstName, string lastName)
        {
            _username = username;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
            
        }

        public string GetUserName()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public string GetEmployeeFirstName()
        {
            return _firstName;
        }

        public string GetEmployeeLastName()
        {
            return _lastName;
        }

      

    }
}
