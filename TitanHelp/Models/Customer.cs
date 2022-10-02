using System;
using System.Collections.Generic;

namespace TitanHelp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
