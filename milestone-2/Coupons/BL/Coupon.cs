using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Coupon
    {
        //fields
        private Customer _customer;
        private CouponMaker _originalCoupon;
        private int _serialCode;
        private Boolean _isActive;

        //constructors
        public Coupon(Customer customer, CouponMaker originalCoupon, int serialCode)
        {
            _customer = customer;
            _originalCoupon = originalCoupon;
            _serialCode = serialCode;
            _isActive = true;
        }
    }
}
