using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TitanHelp.Models
{
    public class Ticket
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TicketDate { get; set; }
        public int TicketId { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
    }
}
