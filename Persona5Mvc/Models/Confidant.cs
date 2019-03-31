using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Persona5Mvc.Models
{
    public class Confidant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Arcana { get; set; }
        public string Details { get; set; }
        public DateTime DateAvailable { get; set; }
        public string DaysAvailable { get; set; }
        public string TimeOfDayAvailable { get; set; }
        public string Location { get; set; }
        public virtual ICollection<ConfidantRank> Ranks { get; set; }

        public Confidant()
        {
            Ranks = new List<ConfidantRank>();
        }
    }

    public class ConfidantDBContext : DbContext
    {
        public DbSet<Confidant> Confidants { get; set; }
    }
}