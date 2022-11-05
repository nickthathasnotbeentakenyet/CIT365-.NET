using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Web.Data;
using MegaDesk_Web.Models;

namespace MegaDesk_Web.Pages.Quotes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk_Web.Data.MegaDesk_WebContext _context;

        public DetailsModel(MegaDesk_Web.Data.MegaDesk_WebContext context)
        {
            _context = context;
        }

      public Desk Desk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Desk == null)
            {
                return NotFound();
            }

            var desk = await _context.Desk.FirstOrDefaultAsync(m => m.ID == id);
            if (desk == null)
            {
                return NotFound();
            }
            else 
            {
                Desk = desk;
            }
            return Page();
        }
    }
}
