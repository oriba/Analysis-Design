using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Owner: User
    {
        //constructors
        public Owner(string ID, string firstName, string lastName, string email, string phone, string password): 
            base(ID, firstName, lastName, email, phone, password)
        {
        }
    }
}
