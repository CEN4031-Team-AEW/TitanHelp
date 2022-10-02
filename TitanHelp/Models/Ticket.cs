using System;
using System.Collections.Generic;

namespace TitanHelp.Models
{
    public class Ticket
    {
        public DateTime TicketDate { get; set; }
        public int TicketId { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
    }
}
