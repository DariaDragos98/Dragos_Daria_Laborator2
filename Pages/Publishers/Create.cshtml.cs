﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dragos_Daria_Laborator2.Data;
using Dragos_Daria_Laborator2.Models;

namespace Dragos_Daria_Laborator2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Dragos_Daria_Laborator2.Data.Dragos_Daria_Laborator2Context _context;

        public CreateModel(Dragos_Daria_Laborator2.Data.Dragos_Daria_Laborator2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
