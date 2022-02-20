using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesEmbroidery.Models;
using System;
using System.Linq;


namespace RazorPagesEmbroidery.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesEmbroideyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesEmbroideyContext>>()))
            {
                // Look for any embroidery.
                if (context.Embroidery.Any())
                {
                    return;   // DB has been seeded
                }

                context.Embroidery.AddRange(
                    new Embroidery
                    {
                        Name = "Overall Embroidery Machine",
                        SerialNumber = "Brother SE1900",
                        Type = "Sewing and Embroidery Machine",
                        Price = 1270

                    },

                    new Embroidery
                                        {
                        Name = "Value Embroidery Machine",
                        SerialNumber = "Brother SE600 ",
                        Type = "Sewing Machine",
                        Price = 550

                    },

                    new Embroidery
                    {
                        Name = " Embroidery Machine for Home Business",
                        SerialNumber = " Janome MB-7 Seven-Needle",
                        Type = "Embroidery Machine",
                        Price = 6600

                    },

                    new Embroidery
                    {
                         Name = "Embroidery Machine for Designs",
                        SerialNumber = " Bernette B79",
                        Type = "Sewing and Embroidery Machine",
                        Price = 2000

                    }
                );
                context.SaveChanges();
            }
        }
    }
}