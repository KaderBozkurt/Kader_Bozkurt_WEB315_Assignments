using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEmbroidery.Models;

namespace RazorPageEmbroidery.Pages_Embroiderys
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesEmbroideyContext _context;

        public CreateModel(RazorPagesEmbroideyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Embroidery Embroidery { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Embroidery.Add(Embroidery);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
