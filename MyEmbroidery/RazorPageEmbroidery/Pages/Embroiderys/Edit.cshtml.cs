using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesEmbroidery.Models;

namespace RazorPageEmbroidery.Pages_Embroiderys
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesEmbroideyContext _context;

        public EditModel(RazorPagesEmbroideyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Embroidery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmbroideryExists(Embroidery.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmbroideryExists(int id)
        {
            return _context.Embroidery.Any(e => e.ID == id);
        }
    }
}
