using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ltq_Lesson5.Models
{
    public class LtqCustomer
    {
        public int CustomerId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}