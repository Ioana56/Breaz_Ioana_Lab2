using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Breaz_Ioana_Lab2.Data;
using Breaz_Ioana_Lab2.Models;

namespace Breaz_Ioana_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Breaz_Ioana_Lab2.Data.Breaz_Ioana_Lab2Context _context;

        public IndexModel(Breaz_Ioana_Lab2.Data.Breaz_Ioana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
