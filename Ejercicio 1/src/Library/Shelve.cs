using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> ListBook { get; set; }
    

        public int ShelveId { get; set;}

        public Shelve(int id)
        {
            this.ShelveId = id;
            this.ListBook = new List<Book>();
        }
        public void AgregarLibro(Book libro)
        {
            this.ListBook.Add(libro);
        }
    }
}
