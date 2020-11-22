using System;
using System.Collections.Generic;
using System.Text;

namespace NYT_API.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
