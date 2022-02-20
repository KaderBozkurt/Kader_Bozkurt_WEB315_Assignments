using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesEmbroidery.Models;

    public class RazorPagesEmbroideyContext : DbContext
    {
        public RazorPagesEmbroideyContext (DbContextOptions<RazorPagesEmbroideyContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesEmbroidery.Models.Embroidery> Embroidery { get; set; }
    }
    public class IndexModel : Embroidery
{
    private readonly RazorPagesEmbroideyContext _context;

    public IndexModel(RazorPagesEmbroideyContext context)
    {
        _context = context;
    }
}
