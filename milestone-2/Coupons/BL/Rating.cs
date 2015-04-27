using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rating
    {
        //fields
        private int _quantity;
        private double _currentRating;

        public double CurrentRating {
            get { return _currentRating; }
        }

        //constructors
        public Rating()
        {
            _quantity = 0;
            _currentRating = 0;
        }

        public void rate(int newRating) { //TODO: throw exception if rating is not between 1-5
            double tmp = ((_currentRating * _quantity) + newRating);
            _quantity = _quantity + 1;
            _currentRating = tmp / _quantity;
        }
    }
}
