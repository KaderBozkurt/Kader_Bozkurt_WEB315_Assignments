using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesEmbroidery.Models;

namespace RazorPageEmbroidery.Pages_Embroiderys
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesEmbroideyContext _context;

        public DeleteModel(RazorPagesEmbroideyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Embroidery Embroidery { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Embroidery = await _context.Embroidery.FirstOrDefaultAsync(m => m.ID == id);

            if (Embroidery == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Embroidery = await _context.Embroidery.FindAsync(id);

            if (Embroidery != null)
            {
                _context.Embroidery.Remove(Embroidery);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
