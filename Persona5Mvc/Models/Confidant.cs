using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Persona5Mvc.Models
{
    public class Confidant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Arcana { get; set; }
        public string Details { get; set; }

        [Display(Name = "Date Available")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAvailable { get; set; }

        [Display(Name = "Days Available")]
        public string DaysAvailable { get; set; }
        [Display(Name = "Time of Day")]
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
        public DbSet<ConfidantRank> ConfidantRanks { get; set; }
        public DbSet<ConfidantRankDialogue> ConfidantRankDialogues { get; set; }
        public DbSet<DialogueOption> DialogueOptions { get; set; }
    }
}