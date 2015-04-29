using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coupons.Models
{

    public class Business
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string ownerID { get; set; }
        public Category category;
        public string description;
        public string address;
        public string city;
        public int moneyEarned;

        public virtual Owner owner { get; set; }
    }
}