using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("Pro Python","Troelsen","001-036");
            Book book4 = new Book("Pro Java","Java","001-037");
            
            Sector sector1 = new Sector("Sector Comedia", 1);
            Sector sector2 = new Sector("Sector Programacion", 2);
            Shelve estante1 = new Shelve(1);
            Shelve estante2 = new Shelve(2);
            Shelve estante3 = new Shelve(3);
            Shelve estante4 = new Shelve(4);
            sector1.AgregarEstante(estante1);
            sector2.AgregarEstante(estante2);
            sector2.AgregarEstante(estante3);
            sector2.AgregarEstante(estante4);
            estante2.AgregarLibro(book1);
            estante2.AgregarLibro(book2);
            estante2.AgregarLibro(book3);
            estante3.AgregarLibro(book4);
            Console.WriteLine($"El libro {book1.Title} se encuentra en el {sector1.SectorName}, en el estante {estante1.ShelveId}");
        }
    }
}