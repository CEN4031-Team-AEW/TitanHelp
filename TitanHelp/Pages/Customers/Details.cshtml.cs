using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TitanHelp.Data;
using TitanHelp.Models;

namespace TitanHelp.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly TitanHelp.Data.TitanHelpContext _context;

        public DetailsModel(TitanHelp.Data.TitanHelpContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerID == id);
            Customer = await _context.Customers
                .Include(s => s.Tickets)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
