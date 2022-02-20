using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesEmbroidery.Models
{
    public class Embroidery
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}