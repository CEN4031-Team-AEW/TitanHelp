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
    public class IndexModel : PageModel
    {
        private readonly TitanHelp.Data.TitanHelpContext _context;

        public IndexModel(TitanHelp.Data.TitanHelpContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get;set; }

        public async Task OnGetAsync()
        {
            Ticket = await _context.Tickets.ToListAsync();
        }

    }
}
