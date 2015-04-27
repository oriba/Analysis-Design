using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coupons.Models
{
   
    public class Coupon
    {
        public int couponID { get; set; }
        public bool isActive { get; set; }
        public int CouponMakerID { get; set; }
        public int CustomerID { get; set; }

        public virtual CouponMaker couponMaker { get; set; }
        public virtual Customer customer { get; set; }
    }
}