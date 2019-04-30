using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Persona5Mvc.Models
{
    public class Persona5DbContext : DbContext
    {
        public DbSet<Confidant> Confidants { get; set; }
        public DbSet<ConfidantRank> ConfidantRanks { get; set; }
        public DbSet<ConfidantRankDialogue> ConfidantRankDialogues { get; set; }
        public DbSet<DialogueOption> DialogueOptions { get; set; }
        public DbSet<Persona> Personas { get; set; }

        public Persona5DbContext()
        {
        }
    }
}