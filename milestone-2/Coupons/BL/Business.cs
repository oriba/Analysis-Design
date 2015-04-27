using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Business
    {
        //fields
        private string _ID;
        private string _name;
        private Category _category;
        private string _description;
        private string _address;
        private int _moneyEarned;
        private Rating _rating;

        //constructors
        public Business(string ID, string name, Category category, string description, string address)
        {
            _ID = ID;
            _name = name;
            _category = category;
            _description = description;
            _address = address;
            _moneyEarned = 0;
            _rating = new Rating();
        }
    }
}
