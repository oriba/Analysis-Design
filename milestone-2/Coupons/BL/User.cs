using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class User
    {
        //fields
        private string _ID;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _password;

        //constructors
        public User(string ID, string firstName, string lastName, string email, string phone, string password) 
        {
            _ID = ID;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phone = phone;
            _password = password;
        }
    }
}
