using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.models
{
    public class Requesition
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public readonly string? Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
        public string? End { get; set; }
    }
}
