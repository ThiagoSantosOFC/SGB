using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.models
{
    public class Requesition
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string? levantamento { get; set; }
        public string? entrega { get; set; }
        public int Id { get; set; }
    }
}
