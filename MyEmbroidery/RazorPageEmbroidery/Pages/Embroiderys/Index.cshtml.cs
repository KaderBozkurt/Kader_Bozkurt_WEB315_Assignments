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
 #pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly RazorPagesEmbroideyContext _context;

        public IndexModel(RazorPagesEmbroideyContext context)
        {
            _context = context;
        }

        public IList<Embroidery> Embroidery { get;set; }

        public async Task OnGetAsync()
        {
            Embroidery = await _context.Embroidery.ToListAsync();
        }
    }
    #pragma warning restore CS8618
#pragma warning restore CS8604
}
