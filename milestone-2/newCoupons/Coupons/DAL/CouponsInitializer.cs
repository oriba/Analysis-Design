using Coupons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coupons.DAL
{
    public class CouponsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CouponsContext>
    {
        protected override void Seed(CouponsContext context)
        {
            var Customer = new List<Customer>
            {
            new Customer{ID="111111111",firstName="Israel",lastName="Israeli",email="israel@gmail.com",phone="050-1111111",password="1111",age=25,},
            new Customer{ID="222222222",firstName="Dan",lastName="Daniel",email="dan@gmail.com",phone="050-2222222",password="2222",age=26,}

            };

            Customer.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();

            var Owner = new List<Owner>
            {
            new Owner{ID="333333333",firstName="Tal",lastName="Tali",email="tal@gmail.com",phone="050-3333333",password="3333",},
            new Owner{ID="444444444",firstName="Avi",lastName="Aviv",email="avi@gmail.com",phone="050-4444444",password="4444",},
            
            };
            Owner.ForEach(s => context.Owner.Add(s));
            context.SaveChanges();

            var Admin = new List<Admin>
            {
            new Admin{ID="000000000",firstName="Dana",lastName="Daniel",email="dana@gmail.com",phone="050-0000000",password="0000",}
            };
            Admin.ForEach(s => context.Admin.Add(s));
            context.SaveChanges();
            
            var Business = new List<Business>
            {
            new Business{ID=1,name="mcDonalds",ownerID="333333333",category=Coupons.Models.Category.FOOD, description="hamburgers", address="rager 20 Beer-sheva",city="Beer-Sheva",moneyEarned=100}
            };
            Business.ForEach(s => context.Business.Add(s));
            context.SaveChanges();

            var CouponMaker = new List<CouponMaker>
            {
            new CouponMaker{ID=1,name="mcCoupon",description="best price", originalPrice=50,couponPrice=25,rating=2,numOfRaters=1,startDate=DateTime.Parse("2015-04-04"),endDate=DateTime.Parse("2015-05-05"),quantity=0,maxQuantity=100,status=Coupons.Models.Status.ACTIVE}
            };
            CouponMaker.ForEach(s => context.CouponMaker.Add(s));
            context.SaveChanges();

            var Coupon = new List<Coupon>
            {
            new Coupon{ID=2,isActive=true,CouponMakerID=1,CustomerID="111111111",}
            };
            Coupon.ForEach(s => context.Coupon.Add(s));
            context.SaveChanges();
        }
    }
}