using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Customer: User
    {
        //fields
        private int _age;
        List<Category> _favoriteCategories;

        //constructors
        public Customer(string ID, string firstName, string lastName, string email, string phone, string password, int age, List<Category> favoriteCategory) : 
            base(ID, firstName, lastName, email, phone, password)
        {
            _age = age;
            _favoriteCategories = favoriteCategory;
        }

    }
}
