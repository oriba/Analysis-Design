using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Coupons.Models
{
    class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string firstName { get; set; }
        public int lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public int age { get; set; }

    }
}
