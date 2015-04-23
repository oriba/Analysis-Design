using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//need to change the BL to BackgroundBL???
namespace BL
{
    public class CouponMaker
    {
        //fields
        private int _ID;
        private string _name;
        private string _description;
        private int _originalPrice;
        private int _couponPrice;
        private Rating _rating;
        private string _startDate;
        private string _endDate;
        private int _quantity;
        private int _maxQuantity;
        private Status _status;

        //constructors
        public CouponMaker(int ID, string name, string description, int originalPrice, 
            int couponPrice, string startDate, string endDate, int maxQuantity)
        {
            _ID = ID;
            _name = name;
            _description = description;
            _originalPrice = originalPrice;
            _couponPrice = couponPrice;
            _rating = new Rating();
            _startDate = startDate;
            _endDate = endDate;
            _quantity = 0;
            _maxQuantity = maxQuantity;
            _status = Status.awaitsApproval;
        }
    }
}
