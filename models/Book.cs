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
        public string? Publisher { get; set; }
        public string? Year { get; set; }
        public string? ISBN { get; set; }
        public string? Category { get; set; }

        public string BookIsValid()
        {
            if (Title == null || Title == "")
                return "Titulo não pode estar vazio";
            if (Author == null || Author == "")
                return "Autor não pode estar vazio";
            if (Publisher == null || Publisher == "")
                return "Editora não pode estar vazia";
            if (Year == null || Year == "")
                return "Ano não pode estar vazio";
            if (ISBN == null || ISBN == "")
                return "ISBN não pode estar vazio";
            if (Category == null || Category == "")
                return "Categoria não pode estar vazia";

            return "";
        }
    }
}
