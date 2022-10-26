using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Data;
using My_Scripture_Journal.Models;

namespace My_Scripture_Journal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly My_Scripture_Journal.Data.My_Scripture_JournalContext _context;

        public IndexModel(My_Scripture_Journal.Data.My_Scripture_JournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? BookChapters { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from s in _context.Scripture
                                            orderby s.Book,s.DateAdded
                                            select s.Book;

            var scriptures = from s in _context.Scripture
                         select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(BookChapters))
            {
                scriptures = scriptures.Where(x => x.Book == BookChapters);
            }
            Books = new SelectList(await genreQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
