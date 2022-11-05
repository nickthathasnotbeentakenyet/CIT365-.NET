using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Web.Data;
using MegaDesk_Web.Models;

namespace MegaDesk_Web.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_Web.Data.MegaDesk_WebContext _context;

        public IndexModel(MegaDesk_Web.Data.MegaDesk_WebContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? CustomerName { get; set; }

        public async Task OnGetAsync()
        {
            var customers = from c in _context.Desk
                            select c;
                          
            if (!string.IsNullOrEmpty(SearchString))
            {
                /*customers = customers.Where(s => s.lastName.Contains(SearchString));*/
                customers = customers.Where(s => SearchString == s.firstName + " " +  s.lastName);
            }

            Desk = await customers.ToListAsync();
        }
    }
}
