using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Coupons.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Coupons.DAL
{
    public class CouponsContext : DbContext
    {
            public CouponsContext() : base("CouponsContext")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponMaker> CouponMakers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Business> Businesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}