using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Publisher { get; set; }
        public int Year { get; set; }
        public string? ISBN { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public string? Price { get; set; }
        public int Edition { get; set; }
    }
}
