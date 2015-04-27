using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coupons.Models
{
    public enum Status
    {
        AWAITSAPPROVAL,
        APPROVED,
        ACTIVE,
        INACTIVE //TODO: edit statuses
    }
}