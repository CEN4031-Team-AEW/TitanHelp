using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TitanHelp.Data;
using TitanHelp.Models;

namespace TitanHelp.Pages.Tickets
{
    public class DetailsModel : PageModel
    {
        private readonly TitanHelp.Data.TitanHelpContext _context;

        public DetailsModel(TitanHelp.Data.TitanHelpContext context)
        {
            _context = context;
        }

        public Ticket Ticket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.TicketId == id);

            if (Ticket == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
