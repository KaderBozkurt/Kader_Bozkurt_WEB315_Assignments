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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesEmbroideyContext _context;

        public DetailsModel(RazorPagesEmbroideyContext context)
        {
            _context = context;
        }

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
    }
}
