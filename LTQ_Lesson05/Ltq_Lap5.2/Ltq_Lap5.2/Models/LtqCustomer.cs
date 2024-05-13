using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ltq_Lap5._2.Models
{
    public class LtqCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
}