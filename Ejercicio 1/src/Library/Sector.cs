using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public List<Shelve> ListSector { get; set; }
        public string SectorName { get; set;}
        public int SectorId { get; set; }

        public Sector(String name, int id)
        {
            this.SectorName = name; 
            this.SectorId = id;    
            ListSector= new List<Shelve>();
        }
        public void AgregarEstante(Shelve estante)
        {
            this.ListSector.Add(estante);
        }
    }
}
