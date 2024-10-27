using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dragos_Daria_Laborator2.Data;
using Dragos_Daria_Laborator2.Models;

namespace Dragos_Daria_Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Dragos_Daria_Laborator2.Data.Dragos_Daria_Laborator2Context _context;

        public IndexModel(Dragos_Daria_Laborator2.Data.Dragos_Daria_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
